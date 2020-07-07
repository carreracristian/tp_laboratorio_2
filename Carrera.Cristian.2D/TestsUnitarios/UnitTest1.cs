using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
using Archivos;
using Excepciones;

namespace TestsUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Verificamos que el alumn o sea serializado
        /// </summary>
        [TestMethod]
        public void PruebaSerializarAlumnos()
        {
            Alumno a = new Alumno(1, "5", "Juan", "Perez", 4, 34334432, "Lima 2234");
            a.NotaUno = 8;
            a.NotaDos = 6;
            a.NotaFinal = (a.NotaUno + a.NotaDos) / 2;

            if (a.NotaFinal >= 6)
                a.GuardarAlumnosAprobados(a);
            else
                a.GuardarAlumnosDesaprobados(a);
        }
        /// <summary>
        /// Verificamos que los docentes sean deserializados
        /// </summary>
        [TestMethod]
        public void PruebaDeserializarDocentes()
        {
            List<Docente> docentes = new List<Docente>();
            docentes = Docente.Deserializar<List<Docente>>($@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\Docentes.xml");

        }
        /// <summary>
        /// Verifica que se lance la excepcion al intentar leer un archivo cuando no se encuntra el directorio
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void LeerArchivoTexto()
        {
            Texto texto = new Texto();
            texto.Leer("", out string datos);


        }
        /// <summary>
        /// Verificamos que los docentes se carguen en la base de datos
        /// </summary>
        [TestMethod]
        public void CargaDeDocentesABaseDeDatos()
        {
            Conexion c = new Conexion();
            Docente d = new Docente(1, "Correa", "Pedro", 25, "masculino", 2434343, "Callao 3223", "correaP@gmail.com");
            c.InsertarDocentesXml(d.Nombre,d.Apellido,d.Edad,d.Sexo,d.Dni,d.Direccion,d.Email);
        }
        /// <summary>
        /// Verificamos que las evaluaciones se carguen en la base de datos
        /// </summary>
        [TestMethod]
        public void CargaDeEvaluacionesEnBaseDeDatos()
        {
            Conexion c = new Conexion();
            Evaluacion d = new Evaluacion(1,4,6,5,8,7,"Aprobado");
            c.GuardarEvaluaciones(d);
        }



    }
}
