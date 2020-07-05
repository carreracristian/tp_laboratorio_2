using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excepciones;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        #region enumerado
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion

        string nombre;
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;

        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (ValidarNombreApellido(value) != null)
                {
                    this.apellido = value;
                }
            }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                if (ValidarNombreApellido(value) != null)
                {
                    this.apellido = value;
                }
            }
        }
        public int DNI
        {
            get { return this.dni; }
            set
            {
                try
                {
                    this.dni = ValidarDni(this.nacionalidad, value);

                }
                catch (DniInvalidoException e)
                {

                    throw e;
                }
            }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        public string StringToDNI
        {
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }

        #endregion

        #region Constructores 
        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Valida que el numero dni coincida con la nacionalidad correspondiente
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (dato >= 1 && dato <= 89999999)
            {
                if (nacionalidad == ENacionalidad.Argentino)
                {
                    return dato;
                }
                throw new NacionalidadInvalidaException();
            }
            else if (dato >= 90000000 && dato <= 99999999)
            {
                if (nacionalidad == ENacionalidad.Extranjero)
                {
                    return dato;
                }
                throw new NacionalidadInvalidaException();
            }
            else
            {
                throw new NacionalidadInvalidaException("¡¡Numero Fuera de rango!!");
            }
        }
        /// <summary>
        /// Valida que los caracteres sean numeros y verifica que el numero dni coincida con la nacionalidad correspondiente
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            try
            {
                int numDni = int.Parse(dato);
                return ValidarDni(nacionalidad, numDni);
            }
            catch (FormatException)
            {

                throw new DniInvalidoException("La cadena ingresada tiene caracteres que no corresponden a un numero Dni");
            }
        }
        /// <summary>
        /// Valida que el nombre tenga solo letras y no este vacio
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            if (!string.IsNullOrWhiteSpace(dato))
            {
                Regex rx = new Regex(@"[^A-Za-z\s]");
                if (!rx.IsMatch(dato))
                {
                    return dato;
                }
            }
            return null;

        }
        /// <summary>
        /// Muestra los datos de una persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1} \n ", this.Apellido, this.Nombre);
            sb.AppendFormat("Nacionalidad: " + this.Nacionalidad);
            sb.AppendFormat("\n DNI: " + this.DNI);

            return sb.ToString();
        }
        #endregion

    }

}


