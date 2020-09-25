///<author> Daniel García Albert </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class Empleado
    {
        public int CodigoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string CodigoOficina { get; set; }
        public int CodigoJefe { get; set; }
        public string Puesto { get; set; }

        public Empleado () { }

        public Empleado(int codigoEmpleado, string nombre, string apellido1, 
            string apellido2, string extension, string email, string codigoOficina, 
            int codigoJefe, string puesto)
        {
            CodigoEmpleado = codigoEmpleado;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Extension = extension;
            Email = email;
            CodigoOficina = codigoOficina;
            CodigoJefe = codigoJefe;
            Puesto = puesto;
        }

        public Empleado (Empleado copiaEmpleado)
        {
            CodigoEmpleado = copiaEmpleado.CodigoEmpleado;
            Nombre = copiaEmpleado.Nombre;
            Apellido1 = copiaEmpleado.Apellido1;
            Apellido2 = copiaEmpleado.Apellido2;
            Extension = copiaEmpleado.Extension;
            Email = copiaEmpleado.Email;
            CodigoOficina = copiaEmpleado.CodigoOficina;
            CodigoJefe = copiaEmpleado.CodigoJefe;
            Puesto = copiaEmpleado.Puesto;
        }

        ~Empleado() { }

        public override string ToString()
        {
            return CodigoEmpleado + "#" + Nombre + "#" + Apellido1 + "#" + Apellido2
                + "#" + Extension + "#" + Email + "#" + CodigoOficina + "#" + CodigoJefe
                + "#" + Puesto;
        }
    }
}
