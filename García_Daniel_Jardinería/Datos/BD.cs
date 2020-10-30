using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

// Para contactar con la WEB API
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using AspNetCore.Http.Extensions;

namespace Datos
{
    public class BD
    {
        static HttpClient client = new HttpClient();

        public BD()
        {
            client.BaseAddress = new Uri("http://localhost:51829/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(10);

        }

        // Leo todos los usuarios de la BD
        public List<Empleado> Lee_empleado()
        {
            List<Empleado> listaEmpleados = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/Empleados").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaEmpleados = JsonConvert.DeserializeObject<List<Empleado>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaEmpleados;
        }

        public List<Cliente> Lee_Cliente()
        {
            List<Cliente> listaClientes = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/Clientes").Result;
                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;
                    listaClientes = JsonConvert.DeserializeObject<List<Cliente>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaClientes;
        }

        // Creo un nuevo cliente en la BD
        public bool nuevoUsuario(Cliente cliente)
        {
            try
            {
                HttpResponseMessage response = client.PostAsJsonAsync("api/Clientes", cliente).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        /*

        // Modificamos un usuario
        public bool modificar(int id, string nom, string pas)
        {
            try
            {
                Usuario usu = new Usuario(nom, pas);
                HttpResponseMessage response = client.PutAsJsonAsync($"api/usuarios/{id}", usu).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        // Eliminamos un usuario
        public bool eliminamos(int id, string nom, string pas)
        {
            try
            {
                HttpResponseMessage response = client.DeleteAsync($"api/usuarios/{id}").Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }
        **/
    }
}
