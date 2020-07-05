using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{/*Si el DNI presenta un error de formato (más caracteres de 
 * los permitidos, letras, etc.) se lanzará DniInvalidoException*/
    public class DniInvalidoException:Exception
    {
        public DniInvalidoException():this("Dni invalido, caracteres erroneos o numero fuera de rango")
        {

        }
        public DniInvalidoException(Exception e) : this("Dni invalido, caracteres erroneos o numero fuera de rango",e)
        {

        }
        public DniInvalidoException(string message):base(message)
        {

        }
        public DniInvalidoException(string message, Exception e):base(message,e)
        {

        }
    }
}
