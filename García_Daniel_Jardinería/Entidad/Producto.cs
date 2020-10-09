///<author> Daniel García Albert </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class Producto : IComparable
    {
        public string CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Gama { get; set; }
        public string Dimensiones { get; set; }
        public string Proveedor { get; set; }
        public string Descripcion { get; set; }
        public int CantidadEnStock { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioProveedor { get; set; }

        public Producto() { }

        public Producto(string codigoProducto, string nombre, string gama, string dimensiones, 
            string proveedor, string descripcion, short cantidadEnStock, double precioVenta, 
            double precioProveedor)
        {
            CodigoProducto = codigoProducto;
            Nombre = nombre;
            Gama = gama;
            Dimensiones = dimensiones;
            Proveedor = proveedor;
            Descripcion = descripcion;
            CantidadEnStock = cantidadEnStock;
            PrecioVenta = precioVenta;
            PrecioProveedor = precioProveedor;
        }

        ~Producto() { }

        public override string ToString()
        {
            return CodigoProducto + "#" + Nombre + "#" + Gama + "#" + Dimensiones
                + "#" + Proveedor + "#" + Descripcion + "#" + CantidadEnStock + "#" + PrecioVenta
                + "#" + PrecioProveedor;
        }

        public int CompareTo(Object producto)
        {
            return this.Nombre.CompareTo((producto as Producto).Nombre);
        }
    }
}
