using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivo;

namespace ClasesInstanciables
{
    public class Jornada
    {
        public List<Alumno> alumnos;
        public Universidad.EClases clase;
        Profesor instructor;
        
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set
            {
                if (value != null)
                {
                    this.alumnos = value;
                }
            }
        }
        public Universidad.EClases Clase
        {
            get { return this.clase; }
            set
            {
                if (this.instructor == value)
                {
                    this.clase = value;
                }
                else
                {
                    throw new SinProfesorException();
                }
            }
        }
        public Profesor Instructor
        {
            get { return this.instructor; }
            set
            {
                if (value == this.clase)
                {
                    this.instructor = value;
                }
                else
                {
                    throw new SinProfesorException();
                }
            }
        }
        public Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClases clase, Profesor instructor)
        {
            this.clase = clase;
            this.instructor = instructor;
        }
        /// <summary>
        /// Sobrecarga del oerador == para saber si un alumno esta en la clase de una jornada especifica
        /// </summary>
        /// <param name="i"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada i, Alumno a)
        {
            return (i.Clase == a.claseQueToma);
        }
        /// <summary>
        /// Sobrecarga del oerador != para saber si un alumno esta en la clase de una jornada especifica
        /// </summary>
        /// <param name="i"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada i, Alumno a)
        {
            return !(i == a);
        }
        /// <summary>
        /// Sobrecarga del operador + para agregar alumnos sin asignar a la jornada indncada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j,Alumno a)
        {
            Jornada aux = new Jornada();

            foreach (Alumno item in j.Alumnos)
            {
                if (a != item)
                {
                    aux.Alumnos.Add(a);
                }
                return aux;
            }
            return aux;
        }
        /// <summary>
        /// Guarda los datos de una jornada en txt , si no existe la ruta la crea
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            try
            {
                string ruta = System.IO.Directory.GetCurrentDirectory() + @"\Archivo";
                System.IO.Directory.CreateDirectory(ruta);

                Texto txt = new Texto();


                txt.Guardar((ruta + @"\Jornada.txt"), jornada.ToString());
                return true;
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// lee el txt guardado en la carpeta \Archivos DEL TP3 el archivo de la jornada y los retorna string
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            try
            {
                string jornada = "";
                Texto txt = new Texto();
                txt.Leer((System.IO.Directory.GetCurrentDirectory() + @"\Archivo\Jornada.txt"), out jornada);
                return jornada;
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// Muestra los datos de la jornada escolar
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASE DE: {0} DIRIGIDA POR: {1}", this.Clase, this.Instructor);
            sb.AppendLine("ALUMNOS: ");
            foreach (Alumno item in this.Alumnos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
