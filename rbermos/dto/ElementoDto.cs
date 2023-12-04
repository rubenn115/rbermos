/***
 * Rubén Bernal Ramos, CSI1 (Exámen 2º Evaluación)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace rbermos.dto
{
    /// <summary>
    /// Clase que utilizaremos como tipo objeto para crear los elementos de la lista de stock
    /// de la empresa de catering
    /// rbr - 041223
    /// </summary>
    internal class ElementoDto
    {
        //Atributos
        Int64 id = 0;
        string codigoElemento = "aaaaa";
        string nombreElemento = "aaaaa";
        string descripcionElemento = "aaaaa";
        int cantidadElemento = 0;

        //Getters y setters
        public long Id { get => id; set => id = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        //Constructores

        public ElementoDto(long id, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.id = id;
            this.codigoElemento = id+nombreElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        public ElementoDto()
        {
        }
    }
}
