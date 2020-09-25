///<author> Daniel García Albert </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class Cliente
    {
        public int CodigoCliente { get; set; }
        public string Nombre { get; set; }
        public string NombreContacto { get; set; }
        public string ApellidoContacto { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string LineaDireccion1 { get; set; }
        public string LineaDireccion2 { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public string CodigoEmpleadoRepVentas { get; set; }
        public double LimiteCredito { get; set; }

        public Cliente () { }

        public Cliente(int codigoCliente, string nombre, string nombreContacto, 
            string apellidoContacto, string telefono, string fax, 
            string lineaDireccion1, string lineaDireccion2, string ciudad, 
            string region, string pais, string codigoPostal, 
            string codigoEmpleadoRepVentas, double limiteCredito)
        {
            CodigoCliente = codigoCliente;
            Nombre = nombre;
            NombreContacto = nombreContacto;
            ApellidoContacto = apellidoContacto;
            Telefono = telefono;
            Fax = fax;
            LineaDireccion1 = lineaDireccion1;
            LineaDireccion2 = lineaDireccion2;
            Ciudad = ciudad;
            Region = region;
            Pais = pais;
            CodigoPostal = codigoPostal;
            CodigoEmpleadoRepVentas = codigoEmpleadoRepVentas;
            LimiteCredito = limiteCredito;
        }

        public Cliente(Cliente clienteCopia)
        {
            CodigoCliente = clienteCopia.CodigoCliente;
            Nombre = clienteCopia.Nombre;
            NombreContacto = clienteCopia.NombreContacto;
            ApellidoContacto = clienteCopia.ApellidoContacto;
            Telefono = clienteCopia.Telefono;
            Fax = clienteCopia.Fax;
            LineaDireccion1 = clienteCopia.LineaDireccion1;
            LineaDireccion2 = clienteCopia.LineaDireccion2;
            Ciudad = clienteCopia.Ciudad;
            Region = clienteCopia.Region;
            Pais = clienteCopia.Pais;
            CodigoPostal = clienteCopia.CodigoPostal;
            CodigoEmpleadoRepVentas = clienteCopia.CodigoEmpleadoRepVentas;
            LimiteCredito = clienteCopia.LimiteCredito;
        }

        ~Cliente() { }

        public override string ToString()
        {
            return CodigoCliente + "#" + Nombre + "#" + NombreContacto + "#" + ApellidoContacto
                + "#" + Telefono + "#" + Fax + "#" + LineaDireccion1 + "#" + LineaDireccion2
                + "#" + Ciudad + "#" + Region + "#" + Pais + "#" + CodigoPostal + "#" +
                CodigoEmpleadoRepVentas + "#" + LimiteCredito;
        }
    }
}
