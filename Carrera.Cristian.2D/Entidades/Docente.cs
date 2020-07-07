using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Archivos;

namespace Entidades
{
    public class Docente:Persona
    {
        int idDocente;
        string sexo;
        string eMail;

        public int Id
        { 
            get { return this.idDocente; } 
            set { this.idDocente = value; } 
        }
        public string Sexo 
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }
        public string  Email 
        {
            get { return this.eMail; }
            set { this.eMail = value; }
        }

        public Docente()
        {

        }
        public Docente(int idDcocente, string apellido, string nombre, int edad,
            string sexo,int dni, string direccion,string eMail) :
            base(nombre, apellido, dni, edad, direccion)
        {
            this.Id = idDcocente;
            this.Sexo = sexo;
            this.Email = eMail;
        }
        /// <summary>
        /// Sobreescribimos el metodo ToString para mostrar docentes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Id.ToString() + " - " + this.Nombre + " - " + this.Apellido + " - " + this.Sexo + " - " + this.Email;
        }
        /// <summary>
        /// Metodo para deserializar archivos xml 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static T Deserializar<T>(string archivo)
        {
            T objeto = default(T);

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream fStream = File.Open(archivo, FileMode.Open);
            objeto = (T)serializer.Deserialize(fStream);
            fStream.Close();
            fStream.Dispose();
            return objeto;
        }
    }
}
