using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Primer.Examen.PrograwebAvanzadaServicio.Logica.Especificacion
{
    public class Examen1b
    {
        public double Examen1B(double a, double b, double c)
        {
            var laAccion = new Primer.Examen.PrograwebAvanzadaServicio.Logica.Accion.Examen1b();

            double elResultado = laAccion.Examen1B(a, b, c);

            return elResultado;
        }
    }
}