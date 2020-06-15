using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException() : this("Ingreso caracteres que no se pueden " +
            "cargar como numeros, o numero ingresado fuera de rango")
        {

        }
        public DniInvalidoException(Exception e) : this("Ingreso caracteres que no se pueden " +
            "cargar como numeros, o numero ingresado fuera de rango")
        {

        }
        public DniInvalidoException(string mensaje)
            : base(mensaje)
        {

        }
        public DniInvalidoException(string mensaje, Exception e)
            : base(mensaje, e)
        {

        }
    }
}
