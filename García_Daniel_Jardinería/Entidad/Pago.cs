///<author> Daniel García Albert </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class Pago
    {
        public string FormaPago { get; set; }
        public string IdTransaccion { get; set; }
        public string FechaPago { get; set; }
        public double Total { get; set; }

        public Pago() { }

        public Pago(string formaPago, string idTransaccion, string fechaPago, double total)
        {
            FormaPago = formaPago;
            IdTransaccion = idTransaccion;
            FechaPago = fechaPago;
            Total = total;
        }

        public Pago(Pago copiaPago)
        {
            FormaPago = copiaPago.FormaPago;
            IdTransaccion = copiaPago.IdTransaccion;
            FechaPago = copiaPago.FechaPago;
            Total = copiaPago.Total;
        }

        ~Pago() { }

        public override string ToString()
        {
            return FormaPago + "#" + IdTransaccion + "#" + FechaPago + "#" + Total;
        }
    }
}
