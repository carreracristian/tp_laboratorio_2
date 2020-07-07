using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;
using Excepciones;

namespace Entidades
{
    public class Alumno : Persona
    {
        Conexion c = new Conexion();
        int idAlumno;
        string responsable;

        public float NotaUno { get; set; }
        public float NotaDos { get; set; }
        public float NotaFinal { get; set; }

        public int IdAlumno
        {
            get { return this.idAlumno; }
            set { this.idAlumno = value; }
        }
        public string Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }
        public Alumno()
        {

        }

        public Alumno(int idAlumno, string responsable, string nombre,
            string apellido, int edad, int dni, string direccion) :
            base(nombre, apellido, dni, edad, direccion)
        {
            this.responsable = responsable;
            this.idAlumno = idAlumno;
        }
        /// <summary>
        /// Dos alumnos son iguales si compaerten mismo id
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            if (a1 != null && a2 != null)
                return (a1.IdAlumno == a2.IdAlumno);
            else
                return false;
        }
        /// <summary>
        /// Dos alumnos son distintos si no comparten mismo id
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
        /// <summary>
        /// Sobrecarga del metodo ToString para mostrar los datos del alumno
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.IdAlumno.ToString() + " - " + this.Nombre + " - " + this.Apellido;
        }
        /// <summary>
        /// Serializamos los alumnos aprobados
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool GuardarAlumnosAprobados(Alumno a)
        {
            try
            {
                string aux = System.IO.Directory.GetCurrentDirectory() + @"MisDocumentos\SegundoParcialUtn\JardinUtn\Serializaciones\APROBADOS";

                if (!System.IO.Directory.Exists(aux))
                    System.IO.Directory.CreateDirectory(aux);

                Xml<Alumno> archivo = new Xml<Alumno>();
                archivo.Guardar((aux + $@"\{a.Apellido}_{a.Nombre}_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}.xml"), a);
                return true;
            }
            catch (AlumnoNoGuardadoException ex)
            {
                MessageBox.Show(ex.Message);
                c.GuardarErrores(ex.Message);
                return false;
            }
            
        }
        /// <summary>
        /// Serializamos los alumnos desaprobados
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool GuardarAlumnosDesaprobados(Alumno a)
        {
            try
            {
                string aux = System.IO.Directory.GetCurrentDirectory() + @"MisDocumentos\SegundoParcialUtn\JardinUtn\Serializaciones\DESAPROBADOS";

                if (!System.IO.Directory.Exists(aux))
                    System.IO.Directory.CreateDirectory(aux);

                Xml<Alumno> archivo = new Xml<Alumno>();
                archivo.Guardar((aux + $@"\{a.Apellido}_{a.Nombre}_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}.xml"), a);
                return true;
            }
            catch (AlumnoNoGuardadoException ex)
            {
                MessageBox.Show(ex.Message);
                c.GuardarErrores(ex.Message);

                return false;
            }
        }
    }
}
