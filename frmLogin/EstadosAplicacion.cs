using Entidades;
using System.Collections.Generic;

namespace frmLogin
{
    public static class EstadosAplicacion
    {
        
        /*
         *  Se usa para almacenar el estado de la aplicacion,
         *  aca se puede almacenar tanto colecciones como información propia de la app
         *  por ejemplo... hora en la que se inicio la aplicacion, o lo que sea.
         */

        public static List<Alumno> AlumnosSinAula { get; set; } = new List<Alumno>();
        public static List<Alumno> AlumnosConAula { get; set; } = new List<Alumno>();
        public static List<Aula> Aulas { get; set; } = new List<Aula>();
        public static List<Docente> Profesores { get; set; } = new List<Docente>();
        public static List<Responsable> Responsables { get; set; } = new List<Responsable>();
        public static List<Administrativo> Administrativos { get; set; } = new List<Administrativo>();

        /*static EstadosAplicacion()
        {
            var responsableHarcodeado = new Responsable("Carlos", "Centurion", 123, true, EParentesco.Abuela, "123");
            Responsables.Add(responsableHarcodeado);

            var responsableHarcodeadoSegundo = new Responsable("Macarena", "Centurion", 123, true, EParentesco.Abuela, "123");
            Responsables.Add(responsableHarcodeadoSegundo);
        }*/
    }
}