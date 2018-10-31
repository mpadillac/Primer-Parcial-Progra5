using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Primer.Examen.PrograwebAvanzadaServicio.Logica.Accion
{
    public class Examen1b
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Examen1B(double a, double b, double c)
        {
            // valide que los parámetros sean correctos

            double mayor = Encontrarelmayor(a,b,c);
            double menor = Encontrarelmenor(a,b,c);
            double mcd = MCD(a,b,c);

            var laValidacion = new Logica.Validacion.Examen1a();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(a, b, c))

                
            elResultado = MCM(a,b,c);

            else
                MiListaDeErrores.Add("los valores no pueden ser 0 o menor");
            return elResultado;
        }



     

        internal double MCM(double a, double b, double c)
        {
            double div = 2;
            double mcm = 1;

            while (div <= a || div <= b || div <= c)
            {
                while ((div <= a && a%div == 0) || (div <= b && b % div == 0) || (div <= c && c % div == 0) )

                {
                    mcm = mcm * div;

                    if (div <= a && a % div == 0)
                        a = a / div;
                    if (div <= b && b % div == 0)
                        b = b / div;
                    if (div <= c && c % div == 0)
                        c = c / div;
                }
                div = div + 1;
            }

            return mcm;
        }
    }
}