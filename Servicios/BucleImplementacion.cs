using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4C.Servicios
{
    internal class BucleImplementacion : BucleInterfaz
    {
        private char s;
        OperacionesInterfaz oi = new OperacionesImplementacion();
        private string afirmacion;
        public string bucleOperacion()
        {
            Console.WriteLine("¿Quieres seguir operando?. Elija entre s/n");
             afirmacion = Console.ReadLine();
            return afirmacion;
        }

        public void menuFinal()
        {
            do
            {
                oi.operacion();
                bucleOperacion();
            }
            while (afirmacion == "s");
        }
    }
}
