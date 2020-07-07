using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        int idAula;
        string colorAula;
        public int IdAula 
        {
            get { return this.idAula; }
            set { this.idAula = value; } 
        }
        public string ColorAula
        {
            get { return this.colorAula; }
            set { this.colorAula = value; }
        }
        /// <summary>
        /// Constructor de la clase aula
        /// </summary>
        /// <param name="idAula"></param>
        /// <param name="colorAula"></param>
        public Aula(int idAula, string colorAula)
        {
            this.IdAula = idAula;
            this.ColorAula = colorAula;
        }
        /// <summary>
        /// Sobreescritura del metodo ToString() para mostrar los datos del Aula
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.IdAula.ToString() + " - " + this.ColorAula;
        }
    }
}
