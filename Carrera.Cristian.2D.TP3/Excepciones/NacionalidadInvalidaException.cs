using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException:Exception
    {
        public NacionalidadInvalidaException():this("Numero de dni incorrecto, fuera de rango")
        {

        }
        public NacionalidadInvalidaException(string message):base(message)
        {

        }
    }
}
