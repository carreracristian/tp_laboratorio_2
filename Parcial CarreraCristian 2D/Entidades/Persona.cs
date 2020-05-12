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
        #region Atributos
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected bool femenino;
        #endregion

        #region Constructores
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
        #endregion

        #region Encapsulamiento
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string Nombre 
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public bool Femenino
        {
            get { return this.femenino; }
            set { this.femenino = value; }
        }
        #endregion

    }
}
