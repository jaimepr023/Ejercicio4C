using Ejercicio4C.Servicios;

namespace Ejercicio4C
{
    /// <summary>
    /// Clase principal de nuestro programa 
    /// <author>jpr-301023</author>
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo main de nuestro programa
        /// <author>jpr-301023</author>
        /// </summary>
        /// <param name="Args"></param>
        public static void Main(String[] Args)
        {
            BucleInterfaz bi = new BucleImplementacion();
            bi.menuFinal();
           
        }
    }
}
