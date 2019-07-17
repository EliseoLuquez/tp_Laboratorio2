using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TextUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestListaInstanciada()
        {
            //arrange
            Correo correo;
            //act
            correo = new Correo();
            //assert
            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void TestTrackinIdRepetido()
        {
            //arrange
            Correo correo;
            Paquete paqueteUno;
            Paquete paqueteDos;
            //act
            correo = new Correo();
            paqueteUno = new Paquete("Av. Mitre 505", "001-001-0001");
            paqueteDos = new Paquete("Av. Mitre 5000", "001-001-0001");
            correo += paqueteUno;
            correo += paqueteDos;
            //assert

        }
    }
}
