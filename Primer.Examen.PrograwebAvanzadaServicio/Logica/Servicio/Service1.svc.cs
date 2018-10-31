using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Primer.Examen.PrograwebAvanzadaServicio.Logica.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
        
        public double Examen1A(double a, double b, double c)
        {
            Logica.Especificacion.Examen1a laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Examen1a();
            var elResultado = laEspecificacion.Examen1A(a, b,c);
            return elResultado;
        }

        public double Examen1B(double a, double b, double c)
        {
            Logica.Especificacion.Examen1b laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Examen1b();
            var elResultado = laEspecificacion.Examen1B(a, b, c);
            return elResultado;
        }
    }
}
