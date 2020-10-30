///<author> Daniel García Albert </author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Empleado
    {
        public int codigo_Empleado { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string? apellido2 { get; set; }
        public string extension { get; set; }
        public string email { get; set; }
        public string codigo_Oficina { get; set; }
        public int? codigo_Jefe { get; set; }
        public string? puesto { get; set; }
        public string pass { get; set; }

        public Empleado () { }

        public Empleado(int codigoEmpleado, string nombre, string apellido1, 
            string apellido2, string extension, string email, string codigoOficina, 
            int codigoJefe, string puesto, string contrasenya)
        {
            codigo_Empleado = codigoEmpleado;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.extension = extension;
            this.email = email;
            codigo_Oficina = codigoOficina;
            codigo_Jefe = codigoJefe;
            this.puesto = puesto;
            pass = contrasenya;
        }

        public Empleado (Empleado copiaEmpleado)
        {
            codigo_Empleado = copiaEmpleado.codigo_Empleado;
            nombre = copiaEmpleado.nombre;
            apellido1 = copiaEmpleado.apellido1;
            apellido2 = copiaEmpleado.apellido2;
            extension = copiaEmpleado.extension;
            email = copiaEmpleado.email;
            codigo_Oficina = copiaEmpleado.codigo_Oficina;
            codigo_Jefe = copiaEmpleado.codigo_Jefe;
            puesto = copiaEmpleado.puesto;
            pass = copiaEmpleado.pass;
        }

        ~Empleado() { }

        public override string ToString()
        {
            return codigo_Empleado + "#" + nombre + "#" + apellido1 + "#" + apellido2
                + "#" + extension + "#" + email + "#" + codigo_Oficina + "#" + codigo_Jefe
                + "#" + puesto;
        }
    }
}
