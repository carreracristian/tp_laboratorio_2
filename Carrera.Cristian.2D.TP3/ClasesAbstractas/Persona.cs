using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }
        #region Atributos
        string nombre;
        string apellido;
        int dni;
        ENacionalidad nacionalidad;

        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (ValidarNombreApellido(value) != null)
                {
                    this.nombre = value;
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
            set
            {
                try
                {
                    ValidarDni(value, this.dni);
                    this.nacionalidad = value;
                }
                catch (DniInvalidoException)
                {

                    throw new NacionalidadInvalidaException("La nacionalidad no coincide con el numero de dni");
                }
            }
        }
        public string StringToDNI
        {
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }
        #endregion

        #region Metodos
        public Persona()
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
                       : this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
                       : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        /// <summary>
        /// Validamos que el numero de dni coincida con un extranjero o un argentino
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        public int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int dniValidado = 0;
            if ((dato >= 1 && dato <= 89999999)&&(nacionalidad == ENacionalidad.Argentino))
            {
                dniValidado = dato;

            }
            else if ((dato >= 90000000 && dato <= 99999999)&&(nacionalidad == ENacionalidad.Extranjero))
            {
                dniValidado = dato;

            }
            else
                throw new NacionalidadInvalidaException("Numero fuera de rango");
            return dniValidado;

        }
        /// <summary>
        /// Validamos que no se ingresen caracteres incorrectos al dni
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        public int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dniValidado = 0;
            if ((!int.TryParse(dato, out dniValidado)) || (int.Parse(dato) <= 0 || int.Parse(dato) > 99999999))
            {
                throw new DniInvalidoException("Ingreso de caracteres no permitidos");
            }

            return dniValidado;
        }
        /// <summary>
        /// Validamos que solo se ingresen letras
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public string ValidarNombreApellido(string dato)
        {
            string cadenaAEvaluar;
            if (!dato.All(char.IsLetter))
            {
                cadenaAEvaluar = dato;
                return cadenaAEvaluar;
            }
            else
            {
                Console.WriteLine("No se puede guardar el nombre");
                return null;
            }
        }
        public override string ToString()
        {
            return $"NOMBRE COMPLETO:{Apellido}, {Nombre} " +
                   $"NACIONALIDAD: {Nacionalidad.ToString()}"+
                   $"DNI: {DNI}";
        }

        #endregion


    }
}
