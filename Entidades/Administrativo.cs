using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ECargo
    {
        Porteria=100,Cocina=110,Secretaria=140,Tesoreria=240,Direccion=180
    }
    public class Administrativo : Personal
    {
        public ECargo suCargo;
        public static double SalarioBase;
        public ECargo Cargos
        {
            get { return this.suCargo; }
            set { this.suCargo = value; }
        }
        static Administrativo()
        {
            Administrativo.SalarioBase = 30000;
        }
        public Administrativo(string nombre, string apellido,int dni,
                              bool femenino,DateTime horaEntrada,
                              DateTime horaSalida,ECargo suCargo)
                              :base(nombre,apellido,dni,femenino,
                                   horaEntrada,horaSalida)
        {
            this.suCargo = suCargo;
            //Administrativo.SalarioBase = salarioBase;
        }

        public override double CalcularSalario()
        {

            return Administrativo.SalarioBase * ((double)suCargo/100);
        }
        public override string ToString()
        {
            string sexo;
            if (femenino == true)
                sexo = "Femenino";
            else
                sexo = "Masculino";
            return $"Nombre:{nombre}\nApellido:{apellido}\nHora de Ingreso:{horaEntrada}\n" +
                $"Hora de Salida:{horaSalida}\nSexo:{sexo}\nDNI:{dni}\nCargo:{suCargo}\nSueldo:{CalcularSalario()}";
        }
    }
}
