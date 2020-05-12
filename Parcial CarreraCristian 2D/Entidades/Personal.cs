using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal:Persona
    {
        #region Atributos
        protected DateTime horaEntrada;
        protected DateTime horaSalida;
        protected double Salario;
        #endregion

        #region Encapsulamiento
        public DateTime Entrada
        {
            get { return this.horaEntrada; }
            set { this.horaEntrada = value; }
        }
        public DateTime Salida
        {
            get { return this.horaSalida; }
            set { this.horaSalida = value; }
        }
        #endregion

        #region Constructores
        protected Personal(string nombre,string apellido,int dni,
                        bool femenino,DateTime horaEntrada,
                        DateTime horaSalida)
                        : base(nombre, apellido, dni, femenino)
        {
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
        }
        #endregion

        #region Metodos
        public abstract double CalcularSalario();

        public double GetSalario()
        {
            return this.Salario;
        }
        #endregion
    }
}
