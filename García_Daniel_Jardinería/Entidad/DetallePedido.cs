///<author> Daniel García Albert </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class DetallePedido
    {
        public int CodigoDetallePedido { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnidad { get; set; }
        public short NumeroLinea { get; set; }

        public DetallePedido () { }

        public DetallePedido(int codigoDetallePedido, string codigoProducto, 
            int cantidad, double precioUnidad, short numeroLinea)
        {
            CodigoDetallePedido = codigoDetallePedido;
            CodigoProducto = codigoProducto;
            Cantidad = cantidad;
            PrecioUnidad = precioUnidad;
            NumeroLinea = numeroLinea;
        }

        public DetallePedido(DetallePedido copiaDetallePedido)
        {
            CodigoDetallePedido = copiaDetallePedido.CodigoDetallePedido;
            CodigoProducto = copiaDetallePedido.CodigoProducto;
            Cantidad = copiaDetallePedido.Cantidad;
            PrecioUnidad = copiaDetallePedido.PrecioUnidad;
            NumeroLinea = copiaDetallePedido.NumeroLinea;
        }

        ~DetallePedido() { }

        public override string ToString()
        {
            return CodigoDetallePedido + "#" + CodigoProducto + "#" + Cantidad + "#" + PrecioUnidad
                + "#" + NumeroLinea;
        }
    }
}
