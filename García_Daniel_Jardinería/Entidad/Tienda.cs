using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Tienda
    {
        public List<Pedido> Pedidos { get; set; }
        public List<Producto> Productos { get; set; }

        public Tienda() { }

        public Tienda(List<Pedido> pedidos, List<Producto> productos)
        {
            Pedidos = pedidos;
            Productos = productos;
        }

        public Tienda(Tienda copiaTienda)
        {
            Pedidos = copiaTienda.Pedidos;
            Productos = copiaTienda.Productos;
        }

        ~Tienda() { }

        public void ListarPedidos(int CodigoClienteABuscar)
        {
            for (int i = 0; i < Pedidos.Count; i++)
            {
                if (Pedidos[i].CodigoCliente == CodigoClienteABuscar)
                {
                    //Ya tengo los pedidos de ese cliente. ¿Qué hago ahora?
                }
            }
        }

        public void ListarPedido(int CodigoPedidoABuscar)
        {
            for (int i = 0; i < Pedidos.Count; i++)
            {
                if (Pedidos[i].CodigoPedido == CodigoPedidoABuscar)
                {
                    //Ya tengo los datos de ese pedido. ¿Qué hago ahora?
                }
            }
        }

        public void ListarProductos(string CodigoProductoABuscar)
        {
            for (int i = 0; i < Productos.Count; i++)
            {
                if (Productos[i].CodigoProducto == CodigoProductoABuscar)
                {
                    //Ya tengo los datos de ese producto. ¿Qué hago ahora?
                }
            }
        }

        //Falta añadir un ToString()
    }
}
