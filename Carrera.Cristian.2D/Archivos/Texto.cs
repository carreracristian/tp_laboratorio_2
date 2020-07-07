using System;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivos<string>
    {
        /// <summary>
        /// sobreescribe un archivo txt
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    writer.WriteLine(datos);

                    return true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// obtiene los datos de un archivo txt
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader read = new StreamReader(archivo))
                {
                    datos = " ";
                    datos = read.ReadToEnd();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    
    }
}
