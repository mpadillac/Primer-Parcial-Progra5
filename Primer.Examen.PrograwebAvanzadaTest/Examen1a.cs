using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Primer.Examen.PrograwebAvanzadaTest
{
    [TestClass]
    public class Examen1a
    {
        [TestMethod]
        public void Examen1A()
        {
            // preparación del escenario
            var mia = 15.0;
            var mib = 20.0;
            var mic = 10.0;
            var miValorEsperado = 5.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new Primer.Examen.PrograwebAvanzadaServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Examen1A(mia, mib, mic);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
