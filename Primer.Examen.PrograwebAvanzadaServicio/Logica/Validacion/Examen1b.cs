using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Primer.Examen.PrograwebAvanzadaServicio.Logica.Validacion
{
    public class Examen1b
    {
        public bool LosOperadoresSonCorrectos(double a, double b, double c)
        {
            bool elResultado = true;
            // valido que los lados sean positivos

            elResultado = !(a <= 0 || b <= 0 || c <= 0);

            return elResultado;
        }
    }
}