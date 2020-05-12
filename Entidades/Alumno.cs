using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EColores
    {
        Naranja=0, Rojo=1, Amarillo=2, Verde=3
    }
    public class Alumno:Persona
    {
        public EColores colorSala;
        public int legajo;
        public float precioCuota;
        Responsable responsable;

        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
        public float PrecioCuota
        {
            get { return this.precioCuota; }
            set { this.precioCuota = value; }
        }
        public Responsable Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }
        public Alumno(string nombre, string apellido, int dni,
                      bool femenino, float precioCuota, Responsable responsable,
                       int legajo,EColores colorSala) : base(nombre, apellido, dni, femenino)
        {
            this.legajo = legajo;
            this.precioCuota = precioCuota;
            this.responsable = responsable;
            this.colorSala = colorSala;
        }
        public Alumno(string nombre, string apellido,int dni,
                      bool femenino, float precioCuota,Responsable responsable,
                       EColores colorSala,int legajo ):base(nombre, apellido, dni, femenino)
        {
            this.colorSala = colorSala;
            this.legajo = legajo;
            this.precioCuota = precioCuota;
            this.responsable = responsable;
        }
        public static implicit operator Responsable(Alumno al)
        {
            return al.Responsable;
        }
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            if (a1 != null && a2 != null)
                return (a1.dni == a2.dni);
            else
                return false;
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
        public override string ToString()
        {
            string sexo;
            if (femenino == true)
                sexo = "Femenino";
            else
                sexo = "Masculino";
            return $" Nombre:{nombre}\n Apellido:{apellido}\n Legajo{legajo}\n DNI:{dni}\n Sexo:{sexo}\n Precio cuota:{PrecioCuota}" +
                $"\n Sala:{colorSala}\n\n RESPONSABLE:\n{responsable}";
        }
    }
}
