using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrackingIDRepetidoException : Exception
    {
        /// <summary>
        /// se lanza una excepcion en caso de que el id se repita
        /// </summary>
        /// <param name="mensaje"></param>
        public TrackingIDRepetidoException(string mensaje) : base(mensaje)
        {

        }
        /// <summary>
        /// se lanza una excepcion en caso de que el id se repita
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="inner"></param>
        public TrackingIDRepetidoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
