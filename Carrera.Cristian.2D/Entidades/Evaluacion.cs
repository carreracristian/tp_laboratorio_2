using System;
using Archivos;

namespace Entidades
{
    public class Evaluacion
    {
        int idEvaluacion;
        int idAlumno;
        int idDocente;
        int idAula;
        int nota1;
        int nota2;
        float notaFinal;
        string observaciones;

        #region Propiedades
        public int IdAlumno
        {
            get { return this.idAlumno; }
            set { this.idAlumno = value; }
        }
        public int IdDocente
        {
            get { return this.idDocente; }
            set { this.idDocente = value; }
        }
        public int IdEvaluacion
        {
            get { return this.idEvaluacion; }
            set { this.idEvaluacion = value; }
        }
        public int IdAula
        {
            get { return this.idAula; }
            set { this.idAula = value; }
        }
        public int Nota1
        {
            get { return this.nota1; }
            set { this.nota1 = value; }
        }
        public int Nota2
        {
            get { return this.nota2; }
            set { this.nota2 = value; }
        }
        public float NotaFinal
        {
            get { return this.notaFinal; }
            set { this.notaFinal = value; }
        }
        public string Observaciones
        {
            get { return this.observaciones; }
            set { this.observaciones = value; }
        }
        #endregion

        public Evaluacion()
        {

        }

        public Evaluacion(int idAlumno, int idDocente, int idAula,
            int nota1, int nota2, float notaFinal, string observaciones) :
            this(idAlumno, idDocente, idAula, nota1, nota2, notaFinal)
        {
            this.observaciones = observaciones;
        }

        public Evaluacion(int idAlumno, int idDocente, int idAula,
            int nota1, int nota2, float notaFinal) :
            this(nota1, nota2, notaFinal)
        {
            this.IdAlumno = idAlumno;
            this.IdDocente = idDocente;
            this.IdAula = idAula;
        }

        public Evaluacion(int nota1, int nota2, float notaFinal)
        {
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.NotaFinal = notaFinal;
        }
        /// <summary>
        /// Sobreescritura del metodo ToString para mostrar los datos de la evaluacion
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Id de Evaluacion:{IdEvaluacion}\n " +
                   $"Id del Alumno:{IdAlumno}\n " +
                   $"Id del Docente:{IdDocente}\n " +
                   $"Id del Aula: {IdAula}\n " +
                   $"Nota 1:{Nota1}\n" +
                   $"Nota 2: {Nota2} \n" +
                   $"Nota final: {NotaFinal}\n" +
                   $"Observaciones:\n{Observaciones}";
        }
    }
}
