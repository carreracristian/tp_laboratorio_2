    using System.Text;

namespace Entidades
{
    public enum EParentesco
    {
        Madre, Padre, Tia, Tio, Abuela, Abuelo, Otro
    }
    public class Responsable:Persona
    {
        #region Atributos
        public EParentesco parentesco;
        public string telefono;
        #endregion

        #region Encapsulamiento
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
        #endregion

        #region Constructores
        public Responsable(string nombre,string apellido,int dni,
                            bool femenino,EParentesco parentesco,
                            string telefono):base(nombre,apellido,
                            dni,femenino)
        {
            this.telefono = telefono;
            this.parentesco = parentesco;
        }
        #endregion

        #region Metodos
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
        #endregion
    }
}
