using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    
    public sealed class Alumno : Universitario
    {

        public enum EEstadoCuenta
        {
            AlDia, Deudor, Becado
        }

        public EEstadoCuenta estadoCuenta;
        public Universidad.EClases claseQueToma;
        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        /// <summary>
        /// Mostramos datos del alumno
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            return $"LEGAJO NUMERO: {legajo}" +
                   $"CLASES DEL DIA: {claseQueToma.ToString()}" +
                   $"NOMBRE COMPLETO:{Apellido}, {Nombre} " +
                   $"ESTADO DE CUENTA:{estadoCuenta.ToString()} " +
                   $"NACIONALIDAD: {Nacionalidad.ToString()}";
        }
        /// <summary>
        /// Sobrecarga del operador == para saber si un alumno esta en una determinada clase
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor);
        }
        /// <summary>
        /// Sobrecarga del operador != para saber si un alumno esta en una determinada clase
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }
        /// <summary>
        /// Mostramos las clases en la que se encuentra el alumno
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return $"TOMA CLASE DE {claseQueToma.ToString()}";
        }
        /// <summary>
        /// Hacemos publico los datos del alumno
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        public override bool Equals(object obj)
        {
            if (obj is Alumno)
            {
                return base.Equals(obj);
            }
            return false;
        }
    }
}
