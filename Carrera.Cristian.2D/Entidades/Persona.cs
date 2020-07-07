using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Docente))]
    public class Persona
    {
        string nombre;
        string apellido;
        int edad;
        int dni;
        string direccion;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        protected Persona()
        {

        }
        protected Persona(string nombre, string apellido, int dni, int edad, string direccion)
            : this(nombre, apellido, dni)
        {
            this.Edad = edad;
            this.Direccion = direccion;
        }
        protected Persona(string nombre, string apellido, int dni)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Dni = dni;
        }

    }
}
