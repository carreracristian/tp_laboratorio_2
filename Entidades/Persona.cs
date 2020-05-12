using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Eturno
    {
        mañana,tarde
    }

    public enum Sexo
    {
        Masculino,
        Femenino
    }

    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected bool femenino;
        protected Persona(string nombre, string apellido, int dni, bool femenino)
            :this(nombre,apellido,dni)
        {
            this.femenino = femenino;
        }
        protected Persona(string nombre, string apellido, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }//hacer la validacion
        }
        public string Nombre 
        {
            get { return this.nombre; }
            set { this.nombre = value; }//hacer la validacion
        }
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }//hacer la validacion
        }
        public bool Femenino
        {
            get { return this.femenino; }
            set { this.femenino = value; }
        }

    }
}
