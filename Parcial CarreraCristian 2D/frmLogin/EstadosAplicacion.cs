using Entidades;
using System.Collections.Generic;

namespace frmLogin
{
    public static class EstadosAplicacion
    {
        //Almacenamos el hardcodeo y las altas
        public static List<Alumno> AlumnosSinAula { get; set; } = new List<Alumno>();
        public static List<Alumno> AlumnosConAula { get; set; } = new List<Alumno>();
        public static List<Aula> Aulas { get; set; } = new List<Aula>();
        public static List<Docente> ProfesoresSinaulas { get; set; } = new List<Docente>();
        public static List<Docente> ProfesoresConaulas { get; set; } = new List<Docente>();
        public static List<Responsable> Responsables { get; set; } = new List<Responsable>();
        public static List<Administrativo> Administrativos { get; set; } = new List<Administrativo>();

    }
}