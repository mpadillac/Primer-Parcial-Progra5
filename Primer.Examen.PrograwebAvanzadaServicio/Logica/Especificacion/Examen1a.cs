using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Primer.Examen.PrograwebAvanzadaServicio.Logica.Especificacion
{
    public class Examen1a
    {
        public double Examen1A(double a, double b, double c)
        {
            var laAccion = new Primer.Examen.PrograwebAvanzadaServicio.Logica.Accion.Examen1a();
                
            double elResultado = laAccion.Examen1A(a, b, c);

            return elResultado;
        }
    }
}