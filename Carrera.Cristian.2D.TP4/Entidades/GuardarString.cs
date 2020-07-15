using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// Guarda un archivo txt con la informacion del paquete en el escritorio. 
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) +
                @"\" + archivo + ".txt", true))
            {
                sw.WriteLine(string.Format("{0} \n {1} ", DateTime.Now.ToString(), texto));
                return true;
            }
        }
    }
}
