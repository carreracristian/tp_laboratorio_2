using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoNoGuardadoException:Exception
    {
        public AlumnoNoGuardadoException():base("Error al tratar de guardar al alumno")
        {

        }
    }
}
