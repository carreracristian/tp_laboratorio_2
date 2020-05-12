using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        public List<Alumno> alumnos;
        public EColores colorSala;
        public Docente docente;
        public Eturno turno;

        public Aula()
        {
            alumnos= new List<Alumno>();
        }
        public Aula(EColores colorSala, Eturno turno, Docente docente):this()
        {
            this.docente = docente;
            this.turno = turno;
            this.colorSala = colorSala;
        }
        public List<Alumno> Alumnos
        {
            get{ return this.alumnos; }
            set { this.alumnos = value; }
        }
        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
        }
        public Docente Docente
        {
            get { return this.docente; }
            set { this.docente = value; }
        }
        public Eturno Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }
        public static bool operator +(Aula aula,Alumno alumno)
        {
            bool aux=false;
            if(aula.Alumnos.Count < 30)
            {   
                foreach (Alumno item in aula.Alumnos)
                {
                    if (alumno == item)
                    {
                        break;
                    }
                }
                aux = true;
            }
            if (aux)
            {
                aula.Alumnos.Add(alumno);
            }
            return aux;     
        }
        public string MostrarAlumnosDeLista()
        {
            string alum=null;
            foreach (Alumno item in alumnos)
            {
               alum = Convert.ToString(item);
            }
            return alum;
        }
        public override string ToString()
        {
            return $" Color:{colorSala}\n Turno:{turno}\n Docente:{docente}\n\n ALUMNOS:\n{MostrarAlumnosDeLista()}";
        }
    }
}
