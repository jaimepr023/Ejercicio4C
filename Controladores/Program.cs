using Ejercicio4C.Servicios;

namespace Ejercicio4C
{
    class Program
    {
        public static void Main(String[] Args)
        {
            BucleInterfaz bi = new BucleImplementacion();
            bi.menuFinal();
           
        }
    }
}
