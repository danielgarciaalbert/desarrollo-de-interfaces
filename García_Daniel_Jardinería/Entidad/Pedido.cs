///<author> Daniel García Albert </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class Pedido : IComparable
    {
        public int CodigoPedido { get; set; }
        public string FechaPedido { get; set; }
        public string FechaEsperada { get; set; }
        public string FechaEntrega { get; set; }
        public string Estado { get; set; }
        public string Comentarios { get; set; }
        public int CodigoCliente { get; set; }

        public Pedido() { }

        public Pedido(int codigoPedido, string fechaPedido, string fechaEsperada, 
            string fechaEntrega, string estado, string comentarios, int codigoCliente)
        {
            CodigoPedido = codigoPedido;
            FechaPedido = fechaPedido;
            FechaEsperada = fechaEsperada;
            FechaEntrega = fechaEntrega;
            Estado = estado;
            Comentarios = comentarios;
            CodigoCliente = codigoCliente;
        }

        public Pedido(Pedido copiaPedido)
        {
            CodigoPedido = copiaPedido.CodigoPedido;
            FechaPedido = copiaPedido.FechaPedido;
            FechaEsperada = copiaPedido.FechaEsperada;
            FechaEntrega = copiaPedido.FechaEntrega;
            Estado = copiaPedido.Estado;
            Comentarios = copiaPedido.Comentarios;
            CodigoCliente = copiaPedido.CodigoCliente;
        }

        ~Pedido() { }

        public override string ToString()
        {
            return CodigoPedido + "#" + FechaPedido + "#" + FechaEsperada + "#" + FechaEntrega
                + "#" + Estado + "#" + Comentarios + "#" + CodigoCliente;
        }

        public int CompareTo(Object pedido)
        {
            return this.FechaPedido.CompareTo((pedido as Pedido).FechaPedido);
        }
    }
}
