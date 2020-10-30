using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;  

namespace Negocio
{
    public class Neg
    {
        private BD datos;

        public Neg()
        {
            datos = new BD();
        }

        public bool validar(string usu, string pas)
        {
            List<Empleado> lista_usuarios = datos.Lee_empleado();

            if (lista_usuarios != null)
            {
                for (int i = 0; i < lista_usuarios.Count; i++)
                {
                    if ((lista_usuarios[i].nombre == usu) &&
                        (lista_usuarios[i].pass == codifica_MD5(pas)))
                        return (true);
                }
            }

            return (false);
        }

        public bool crearUsuario(Cliente cliente)
        {
            return datos.nuevoUsuario(cliente);
        }

        public string codifica_MD5(string pas)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(pas));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }

    
}
