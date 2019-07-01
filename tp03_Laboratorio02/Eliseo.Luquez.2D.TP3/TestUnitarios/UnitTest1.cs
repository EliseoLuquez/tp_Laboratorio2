using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Archivos;
using Entidades;
using Entidades_Abstractas;


namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidException))]
        public void TestDniIvalidException()
        {
            Alumno a2 = new Alumno(2, "Juana", "Martinez", "1234657897", Persona.ENacionalidad.Extranjero,
                    Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.Deudor);
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidException))]
        public void TestNacionalidadException()
        {
            Alumno a2 = new Alumno(2, "Juana", "Martinez", "12234458", Persona.ENacionalidad.Extranjero,
                    Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.Deudor);
        }

        [TestMethod]
        public void TestValorNumerico()
        {
            string dni = "12234458";
            Alumno a2 = new Alumno(2, "Juana", "Martinez", dni, Persona.ENacionalidad.Argentino,
                    Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.Deudor);

            Assert.AreEqual(int.Parse(dni), a2.DNI);
        }


        [TestMethod]
        public void TestValorNull()
        {
            string dni = "12234458";
            Alumno a2 = new Alumno(2, "Juana", "Martinez", dni, Persona.ENacionalidad.Argentino,
                    Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.Deudor);

            Assert.IsNotNull(a2.Nombre);
        }



    }
}
