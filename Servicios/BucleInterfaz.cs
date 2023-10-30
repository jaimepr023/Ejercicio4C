using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4C.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentra nuestros metodos bucles
    /// <author>jpr-301023</author>
    /// </summary>
    internal interface BucleInterfaz
    {
        /// <summary>
        /// Metodo que te pregunta si quieres seguir operando
        /// <author>jpr-301023</author>
        /// </summary>
        /// <returns>string</returns>
        public string bucleOperacion();

        /// <summary>
        /// Metodo que te opera nuevamente la operacion anterior con un nuevo numero
        /// <author>jpr-301023</author>
        /// </summary>
        public void menuFinal();

    }
}
