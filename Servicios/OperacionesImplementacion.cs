using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4C.Servicios
{
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
        public int operacion()
        {
            Console.WriteLine("Dame el valor hasta el final de la operacion:");
            int mult = 1;
           int valor1=Int32.Parse(Console.ReadLine());
            for (int i = 1;i<=valor1;i++)
            {
                mult *= i;

            }
            Console.WriteLine(mult);
            return mult;
        }
    }
}
