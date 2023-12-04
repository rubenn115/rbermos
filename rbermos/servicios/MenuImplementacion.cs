/***
 * Rubén Bernal Ramos, CSI1 (Exámen 2º Evaluación)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rbermos.servicios
{
    /// <summary>
    /// Implementación de la interfaz Menu
    /// rbr - 041223
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Método que mostrará el menú por consola
        /// rbr - 041223
        /// </summary>
        public void mostrarMenu()
        {
            Console.WriteLine("###############################");
            Console.WriteLine("              MENÚ             ");
            Console.WriteLine("###############################");
            Console.WriteLine("1.Cerrar Menú                  ");
            Console.WriteLine("2.Dar de alta un nuevo elemento");
            Console.WriteLine("3.Dar de baja un elemento      ");
            Console.WriteLine("###############################");
            Console.WriteLine("###############################");
        }
    }
}
