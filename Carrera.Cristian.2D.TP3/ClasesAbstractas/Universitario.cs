using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        public int legajo;

        public Universitario():base()
        {

        }
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        /// <summary>
        /// Mostramos los datos del universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            return $"NOMBRE COMPLETO:{Apellido}, {Nombre} " +
                   $"NACIONALIDAD: {Nacionalidad.ToString()}" +
                   $"DNI: {DNI}"+
                   $"LEGAJO NUMERO: {legajo}";
        }
        /// <summary>
        /// Creamos un metodo abstracto que muestra en que clase se participa
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();
        public override bool Equals(object obj)
        {
            if (obj is Universitario)
            {
                return (this == (Universitario)obj);
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador == para comparar dos universitarios por dni o legajo
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo);
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar dos universitarios por dni o legajo
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
    }
}
