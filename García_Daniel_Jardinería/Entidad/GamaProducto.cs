///<author> Daniel García Albert </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class GamaProducto
    {
        public string Gama { get; set; }
        public string DescripcionTexto { get; set; }
        public string DescripcionHTML { get; set; }
        public string Imagen { get; set; }

        public GamaProducto() { }

        public GamaProducto(string gama, string descripcionTexto, string descripcionHTML, string imagen)
        {
            Gama = gama;
            DescripcionTexto = descripcionTexto;
            DescripcionHTML = descripcionHTML;
            Imagen = imagen;
        }

        public GamaProducto(GamaProducto copiaGamaProducto)
        {
            Gama = copiaGamaProducto.Gama;
            DescripcionTexto = copiaGamaProducto.DescripcionTexto;
            DescripcionHTML = copiaGamaProducto.DescripcionHTML;
            Imagen = copiaGamaProducto.Imagen;
        }

        ~GamaProducto() { }

        public override string ToString()
        {
            return Gama + "#" + DescripcionTexto + "#" + DescripcionHTML + "#" + Imagen;
        }
    }
}
