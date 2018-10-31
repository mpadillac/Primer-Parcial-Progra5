using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Primer.Examen.PrograwebAvanzadaTest
{
    [TestClass]
    public class Examen1b
    {
        [TestMethod]
        public void Examen1B()
        {
            // preparación del escenario
            var mia = 18.0;
            var mib = 15.0;
            var mic = 8.0;
            var miValorEsperado = 360.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new Primer.Examen.PrograwebAvanzadaServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Examen1B(mia, mib, mic);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
