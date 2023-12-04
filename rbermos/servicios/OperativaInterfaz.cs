/***
 * Rubén Bernal Ramos, CSI1 (Exámen 2º Evaluación)
 */

using rbermos.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rbermos.servicios
{
    /// <summary>
    /// Interfaz para la operativa de la aplicación
    /// rbr - 041223
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Enunciado de los métodos que tendrá la implementación
        /// rbr - 041223
        /// </summary>
        public void altaElemento(List<ElementoDto> listaAntigua);
        public void bajaElemento(List<ElementoDto> listaAntigua);
    }
}
