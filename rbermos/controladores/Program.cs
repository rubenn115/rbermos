/***
 * Rubén Bernal Ramos, CSI1 (Exámen 2º Evaluación)
 */

using rbermos.dto;
using rbermos.servicios;

namespace rbermos.controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// rbr - 041223
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal de la aplicación
        /// rbr - 041223
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Creo la lista
            List<ElementoDto> lista = new List<ElementoDto>();

            //Creo las variables
            int opcion=0;

            //Instancio las interfaces con sus implementaciones
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            //Creo el objeto elementoDto
            ElementoDto elemento = new ElementoDto();

            do
            {
                //Muestro el menú por consola
                mi.mostrarMenu();
                Console.WriteLine("Selecciona una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion < 1 || opcion>3)
                {
                    Console.WriteLine("***ERROR. Esa opción no es válida***");
                }
                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        Console.WriteLine("Has seleccionado la opción para dar de alta un nuevo elemento");
                        oi.altaElemento(lista);
                        break;
                    case 3:
                        Console.WriteLine("Has seleccionado la opción para dar de baja un elemento");
                        oi.bajaElemento(lista);
                        break;
                    default:
                        Console.WriteLine("Esa opción no es válida");
                        break;
                }
            } while (opcion != 1);
        }
    }
}