using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;
        /// <summary>
        /// Inicializa por defecto la instancia numero en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Inicializa una instancia numero con el valor pasado por parametro
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Inicializa una instancia numero con valor numero
        /// Valida que sea un numero valido 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            SetNumero = numero;
        }


        /// <summary>
        /// Valida e inicializa un objeto Numero
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
  
        /// <summary>
        /// Valida que el string sea convertible en un double
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>El string convertido a double o 0, si no pudo realizarse la conversion</returns>
        private double ValidarNumero(string strNumero)
        {
            double retornar = new double();

            if (double.TryParse(strNumero, out retornar))

                return retornar;
            else

                return 0;
        }

        /// <summary>
        /// Realiza la conversion de numero binario a decimal
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>String del numero binario convertido a decimal</returns>
        public string BinarioDecimal(string numero)
        {
            int longBin = numero.Length;

            for (int i = 0; i < longBin; i++)
            {
                if (numero[i] != '1' && numero[i] != '0')
                {
                    return "Valor invalido";
                }
            }

            return Convert.ToInt32(numero, 2).ToString();
        }

        /// <summary>
        /// Valida numero decimal recibido como un string
        /// Asigna -1 si no se pudo realizar la conversion
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>La convercion de un decimal a un numero binario</returns>
        public string DecimalBinario(string numero)
        {
            double numValidado;

            if (double.TryParse(numero, out numValidado))
                return DecimalBinario(numValidado);
            else
                return DecimalBinario(-1);
        }

        /// <summary>
        /// Valida el decimal y realiza su conversion a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> La conversion del decimal al binario, "Valor invalido" sino se pudo o 0 si el valor era 0 </returns>
        public string DecimalBinario(double numero)
        {
            string cambio = string.Empty;
            int valor = (int)numero;

            if (valor == 0)
                cambio = "0";
            if (valor < 0)
                cambio = "Valor invalido";

            while (valor > 0)
            {
                cambio = valor % 2 + cambio;
                valor = valor / 2;
            }

            return cambio;
        }
        
        /// <summary>
        /// Sobrecarga el operador "-" para la resta entre dos instancias de tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La resta entre los atributos numero</returns>
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador "+" para la suma de dos instancias de tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La suma entre los atributos numero</returns>
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador "*" para la multiplicacion de dos instancias de tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La multiplicacion entre los atributos numero</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// Sobrecarga el operador "/" para la division de dos instancias de tipo numero
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>La division entre los atributos numero, o dobule.MinValue en caso que el num2 sea 0</returns>
        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero == 0)
                return double.MinValue;
            else
                return num1.numero / num2.numero;
        }
    }
}

