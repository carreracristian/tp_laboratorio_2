using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ConexionBaseDeDatosException:Exception
    {
        public ConexionBaseDeDatosException() : base("Problemas con la conexion en la base de datos")
        {

        }

    }
}
