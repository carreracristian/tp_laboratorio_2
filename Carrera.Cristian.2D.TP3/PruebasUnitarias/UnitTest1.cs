using System;
using Archivo;
using ClasesInstanciables;
using ClasesAbstractas;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void PruebaExcepcionDniInvalido()
        {
            Universidad uni = new Universidad();

            Alumno a = new Alumno(1, "juan", "Perez", "999999hgfghf99999999", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            a.ValidarDni(Persona.ENacionalidad.Argentino, "999999hgfghf99999999");
            uni += a;

        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void PruebaExcepcionNacionalidadInvalida()
        {
            Universidad uni = new Universidad();

            Alumno a = new Alumno(1, "juan", "Perez", "99999", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
            a.ValidarDni(Persona.ENacionalidad.Extranjero, 99999);
            uni += a;
        }
        [TestMethod]
        public void PruebaDeCargaDeValoresNull()
        {
            Profesor p = new Profesor(5, null, null, "99999999", Persona.ENacionalidad.Extranjero);
            string s = p.ToString();
        }
    }
}
