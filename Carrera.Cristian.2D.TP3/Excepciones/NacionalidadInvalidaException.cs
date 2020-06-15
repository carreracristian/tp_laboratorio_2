using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException()
            : this("Dni erroneo, no se puede determinar si es extranjero o Argentino")
        {

        }
        public NacionalidadInvalidaException(string mensaje)
            : base(mensaje)
        {

        }
    }
}
