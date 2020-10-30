///<author> Daniel García Albert </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente
    {
        public int Codigo_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string? Nombre_Contacto { get; set; }
        public string? Apellido_Contacto { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Linea_Direccion1 { get; set; }
        public string? Linea_Direccion2 { get; set; }
        public string Ciudad { get; set; }
        public string? Region { get; set; }
        public string? Pais { get; set; }
        public string? Codigo_Postal { get; set; }
        public string? Codigo_Empleado_Rep_Ventas { get; set; }
        public double? Limite_Credito { get; set; }
        public string Pass { get; set; }

        public Cliente () { }

        public Cliente(string nombre, string nombreContacto, 
            string apellidoContacto, string telefono, string fax, 
            string lineaDireccion1, string lineaDireccion2, string ciudad, 
            string region, string pais, string codigoPostal, 
            string codigoEmpleadoRepVentas, double limiteCredito, string pass)
        {
            Nombre_Cliente = nombre;
            Nombre_Contacto = nombreContacto;
            Apellido_Contacto = apellidoContacto;
            Telefono = telefono;
            Fax = fax;
            Linea_Direccion1 = lineaDireccion1;
            Linea_Direccion2 = lineaDireccion2;
            Ciudad = ciudad;
            Region = region;
            Pais = pais;
            Codigo_Postal = codigoPostal;
            Codigo_Empleado_Rep_Ventas = codigoEmpleadoRepVentas;
            Limite_Credito = limiteCredito;
            Pass = pass;
        }

        public Cliente(Cliente clienteCopia)
        {
            Nombre_Cliente = clienteCopia.Nombre_Cliente;
            Nombre_Contacto = clienteCopia.Nombre_Contacto;
            Apellido_Contacto = clienteCopia.Apellido_Contacto;
            Telefono = clienteCopia.Telefono;
            Fax = clienteCopia.Fax;
            Linea_Direccion1 = clienteCopia.Linea_Direccion1;
            Linea_Direccion2 = clienteCopia.Linea_Direccion2;
            Ciudad = clienteCopia.Ciudad;
            Region = clienteCopia.Region;
            Pais = clienteCopia.Pais;
            Codigo_Postal = clienteCopia.Codigo_Postal;
            Codigo_Empleado_Rep_Ventas = clienteCopia.Codigo_Empleado_Rep_Ventas;
            Limite_Credito = clienteCopia.Limite_Credito;
            Pass = clienteCopia.Pass;
        }

        ~Cliente() { }



        public override string ToString()
        {
            return Codigo_Cliente + "#" + Nombre_Cliente + "#" + Nombre_Contacto + "#" + Apellido_Contacto
                + "#" + Telefono + "#" + Fax + "#" + Linea_Direccion1 + "#" + Linea_Direccion2
                + "#" + Ciudad + "#" + Region + "#" + Pais + "#" + Codigo_Postal + "#" +
                Codigo_Empleado_Rep_Ventas + "#" + Limite_Credito;
        }
    }
}
