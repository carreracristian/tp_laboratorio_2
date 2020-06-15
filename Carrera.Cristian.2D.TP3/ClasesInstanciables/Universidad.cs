using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivo;

namespace ClasesInstanciables
{
    public class Universidad
    {
        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }

        public List<Alumno> alumnos;
        public List<Profesor> profesores;
        public List<Jornada> jornada;

        public List<Alumno> Alumnos
        {
            get { return this.alumnos;}
            set { this.alumnos = value; }
        }
        public List<Profesor> Profesores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }
        public List<Jornada> Jornadas
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }
        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this.jornada.Count)
                {
                    return this.jornada[i];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    this.Jornadas[i] = value;
                }
            }
        }
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }
        public static bool operator ==(Universidad u, Alumno a)
        {
            foreach (Alumno item in u.Alumnos)
            {
                if (item.Equals(a))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Universidad u, Alumno a)
        {
            return !(u == a);
        }
        public static bool operator ==(Universidad u, Profesor p)
        {
            foreach (Profesor item in u.Profesores)
            {
                if (item.Equals(p))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Universidad u, Profesor p)
        {
            return !(u == p);
        }
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Universidad u = new Universidad();
            Jornada j = new Jornada();
            j.Clase = clase;

            foreach (Alumno item in g.Alumnos)
            {
                if (item.claseQueToma == clase)
                    j.Alumnos.Add(item);
            }
            foreach (Profesor item in g.Profesores)
            {
                foreach (EClases item2 in item.clasesDelDia)
                {
                    if (item2 == clase)
                        j.Instructor = item;
                    break;
                }
                
            }
            u.Alumnos = j.Alumnos;
            u.Profesores.Add(j.Instructor);
            u.Jornadas.Add(j);

            return u;
        }
        public static Universidad operator +(Universidad u, Alumno a)
        {
            foreach (Alumno item in u.Alumnos)
            {
                if (a != item)
                    u.Alumnos.Add(a);
                else
                    throw new AlumnoRepetidoException("El alumno ya se encuentra en el sistema");
            }
            return u;
        }
        public static Universidad operator +(Universidad u, Profesor p)
        {
            foreach (Profesor item in u.Profesores)
            {
                if (p != item)
                    u.Profesores.Add(p);
            }
            return u;
        }
        public static Profesor operator ==(Universidad g,EClases clase)
        {
            Profesor p = new Profesor();
            try
            {
                foreach (Profesor item in g.Profesores)
                {
                    foreach (EClases item2 in item.clasesDelDia)
                    {
                        if (item2 == clase)
                            p = item;
                        break;
                    }

                }
                return p;
            }
            catch(SinProfesorException ex)
            {
                Console.WriteLine("No hay profesor disponible" + ex.Message);
            }
            return p;
            
        }
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            Profesor p = new Profesor();

            foreach (Profesor item in g.Profesores)
            {
                foreach (EClases item2 in item.clasesDelDia)
                {
                    if (item2 != clase)
                        p = item;
                    break;
                }

            }
            return p;
        }
        private static string Mostrardatos(Universidad uni)
        {
            StringBuilder a = new StringBuilder();

            a.AppendLine("JORNADA: ");
            /*foreach (Alumno item in uni.Alumnos)
            {
                a.AppendLine(item.ToString());
            }
            foreach (Profesor item in uni.Profesores)
            {
                a.AppendLine(item.ToString());
            }*/
            foreach (Jornada item in uni.Jornadas)
            {
                a.AppendFormat("{0}",item.ToString());
                a.AppendLine("<------------------------------------------------------------------------------>");
            }

            return a.ToString();
        }
        public override string ToString()
        {
            return Mostrardatos(this);
        }
        /// <summary>
        /// Toma los datos de la universidad y los guarda en xml
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            try
            {
                string aux = System.IO.Directory.GetCurrentDirectory() + @"\Archivos";
                System.IO.Directory.CreateDirectory(aux);
                Xml<Universidad> archivo = new Xml<Universidad>();
                archivo.Guardar((aux + @"\Universidad.xml"), uni);
                return true;
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// Toma los datos de un xml de los datos de la universidad y los lee
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            try
            {
                Universidad universidad = new Universidad();
                Xml<Universidad> archivo = new Xml<Universidad>();
                archivo.Leer((System.IO.Directory.GetCurrentDirectory() + @"\Archivo\Universidad.xml"), out universidad);
                return universidad;

            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        }
    }
}
