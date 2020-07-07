using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorDirectorioException:Exception
    {
        public ErrorDirectorioException():base("La ruta no existe, sera creada para almacenar los datos")
        {

        }
    }
}
