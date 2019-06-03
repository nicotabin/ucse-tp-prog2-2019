using Contratos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Principal
    {
        /*
         public void EscribirSucursales(List<Sucursal> sucursales)
        {
            string path = @"C:\Datos\ArchivoSucursales.txt";
            using (StreamWriter archivo = new System.IO.StreamWriter(path, false))
            {
                string output = JsonConvert.SerializeObject(sucursales);
                archivo.Write(output);
            }
        }

        public List<Sucursal> ObtenerSucursales()
        {
            string path = @"C:\Datos\ArchivoSucursales.txt";
            List<Sucursal> lista = new List<Sucursal>();
            using (StreamReader leer = new StreamReader(path))
            {
                string contenido = leer.ReadToEnd();
                lista = JsonConvert.DeserializeObject<List<Sucursal>>(contenido);
            }
            if (lista == null)// ==> devolver 
                return new List<Sucursal>();
            else
                return lista.Where(x => x.Eliminado == false).ToList();
        } 


        public Mensaje AltaDeSucursal(Sucursal sucursal)
        {
            Mensaje mensaje = new Mensaje() { Realizado = false, Descripción="Hay campos vacíos."};
            if (sucursal.Ciudad != "" & sucursal.CodigoPostal != 0 & sucursal.Direccion != "" & sucursal.TasaDeInteres != 0)
            {
                Sucursales = ObtenerSucursales();
                int c = Sucursales.Count() + 1;
                sucursal.ID = c;
                Sucursales.Add(sucursal);
                EscribirSucursales(Sucursales);
                mensaje.Realizado = true;
                mensaje.Descripción = "Se ha completado la acción correctamente.";
            }
            
            return mensaje;
        }
         
         
         */

        public List<Usuario> ObtenerUsuarios()
        {
            string path = @"C:\Datos\ArchivoUsuarios.txt";
            List<Usuario> lista = new List<Usuario>();
            using (StreamReader leer = new StreamReader(path))
            {
                string contenido = leer.ReadToEnd();
                lista = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
            }
            if (lista == null)// ==> devolver 
                return new List<Usuario>();
            else
                return lista;
        }

        public void EscribirUsuarios(List<Usuario> usuarios)
        {
            string path = @"C:\Datos\ArchivoUsuarios.txt";
            using (StreamWriter archivo = new System.IO.StreamWriter(path, false))
            {
                string output = JsonConvert.SerializeObject(usuarios);
                archivo.Write(output);
            }
        }

        public Resultado AltaDirectora(Directora directora, UsuarioLogueado usuarioLogueado)
        {
            Resultado resultado = new Resultado();
            Roles rol = Roles.Directora;
            if (rol != usuarioLogueado.RolSeleccionado)
                resultado.Errores.Add("El rol seleccionado no es el de Directora.");
            else

            return resultado;

        }

      
    }
}
