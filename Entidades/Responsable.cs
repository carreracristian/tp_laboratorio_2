    using System.Text;

namespace Entidades
{
    public enum EParentesco
    {
        Madre, Padre, Tia, Tio, Abuela, Abuelo, Otro
    }
    public class Responsable:Persona
    {
        public EParentesco parentesco;
        public string telefono;

        public EParentesco Parentesco
        {
            get { return this.parentesco; }
            set { this.parentesco = value; }
        }
        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        public Responsable(string nombre,string apellido,int dni,
                            bool femenino,EParentesco parentesco,
                            string telefono):base(nombre,apellido,
                            dni,femenino)
        {
            this.telefono = telefono;
            this.parentesco = parentesco;
        }

        public override string ToString()
        {
            string sexo;
            if (femenino == true)
                sexo = "Femenino";
            else
                sexo = "Masculino";

            return $" Nombre:{nombre}\n Apellido:{apellido}\n Sexo:{sexo}\n" +
                $" Telefono:{telefono}\n DNI:{dni}\n Parentesco:{parentesco}";
        }
    }
}
