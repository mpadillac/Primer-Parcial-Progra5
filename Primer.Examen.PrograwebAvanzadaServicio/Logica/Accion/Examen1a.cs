using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Primer.Examen.PrograwebAvanzadaServicio.Logica.Accion
{
    public class Examen1a
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Examen1A(double a, double b, double c)
        {
            // valide que los parámetros sean correctos

            double e = 2; 

            var laValidacion = new Logica.Validacion.Examen1a();
            double elResultado = 1.0;
            if (laValidacion.LosOperadoresSonCorrectos(a, b, c))

                    while (e <= a && e <= b && e <= c)
                {
                       while (a%e == 0 && b%e ==0 && c%e ==0)

                    {
                        elResultado = elResultado * e;

                        a = a / e;
                        b = b / e;
                        c = c / e;
                    }
                    e = e + 1;
                }
                            
            else
                MiListaDeErrores.Add("los valores de las bases y la altura no pueden ser 0 o menor");
            return elResultado;
        }
    }
}