using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        public Universidad.EClases claseQueToma;
        public EEstadoCuenta estadoCuenta;

        #region Constructores
        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodo
        /// <summary>
        /// retorna todos los datos del alumno.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            sb.AppendLine("Estado de cuenta: " + this.estadoCuenta);

            return sb.ToString();

        }
        /// <summary>
        /// muestra la clase que toma el alumno.
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return ("TOMA CLASE DE: " + this.claseQueToma);
        }
        
        /// <summary>
        /// Muestra todos los datos del alumno publico.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion
        /// <summary>
        /// Verifica si el objeto es de tipo Alumno. Caso que sea, verifica
        /// si los alumnos contienen los mismos datos.
        /// </summary>
        /// <param name="obj">objeto a verificar.</param>
        /// <returns>True si son iguales, false caso contrario.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Alumno)
            {
                return base.Equals(obj);
            }
            return false;
        }

        #region Sobrecarga ==
        /// <summary>
        /// Valida que un alumno tome una clase
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if (a.estadoCuenta != EEstadoCuenta.Deudor && a.claseQueToma == clase)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// invoca el == e invierte su valor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma != clase)
            {
                return true;
            }
            return false;
        }
        
        #endregion
    }
}
