/***
 * Rubén Bernal Ramos, CSI1 (Exámen 2º Evaluación)
 */

using rbermos.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rbermos.servicios
{
    /// <summary>
    /// Implementación de la interfaz Operativa
    /// rbr - 041223
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        /// <summary>
        /// Método para dar de alta un nuevo elemento
        /// rbr - 041223
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void altaElemento(List<ElementoDto> listaAntigua)
        {
            //Creo el objeto elemento
            ElementoDto elemento = new ElementoDto();

            //Asigno los valores a las variables
            Console.WriteLine("Introduce el id: ");
            elemento.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el nombre del elemento: ");
            elemento.NombreElemento = Console.ReadLine();
            elemento.CodigoElemento = elemento.Id + elemento.NombreElemento;
            Console.WriteLine("Introduce una breve descripción del elemento: ");
            elemento.DescripcionElemento = Console.ReadLine();
            Console.WriteLine("Introduce la cantidad de stock del elemento: ");
            elemento.CantidadElemento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El elemento ha sido añadido satisfactoriamente");
            Console.WriteLine("Detalles del elemento \n" + 
                "Nombre: " + elemento.NombreElemento + "      Cantidad: " + elemento.CantidadElemento);

            //Guardo el elemento a la lista
            listaAntigua.Add(elemento);
        }

        /// <summary>
        /// Método para dar de baja la cantidad n de un elemento específico
        /// rbr - 041223
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void bajaElemento(List<ElementoDto> listaAntigua)
        {
            //Creo el objeto elemento
            ElementoDto elemento = new ElementoDto();

            //Declaro las variables que voy a usar
            int cantidad, cantidadAnterior;
            string codigo;
            cantidadAnterior = 0;

            Console.WriteLine("Diga el elemento que desea utilizar indicando su código: ");
            codigo = Console.ReadLine();
            Console.WriteLine("Indique la cantidad a restar del stock del elemento seleccionado: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i=0;i<=listaAntigua.Count-1;i++)
            {
                cantidadAnterior = elemento.CantidadElemento;
                if (codigo == elemento.CodigoElemento)
                {
                    elemento.CantidadElemento = cantidadAnterior - cantidad;
                }
            }
            Console.WriteLine("La cantidad ha sido restada satisfactoriamente: ");
            Console.WriteLine("Detalle de la operación realizada");
            Console.WriteLine("Nombre: " + elemento.NombreElemento + "\n" +
                "Cantidad antes de la operación: " + cantidadAnterior + "\n" +
                "Cantidad actual: " + elemento.CantidadElemento);
        }
    }
}
