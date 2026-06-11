using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SistemaMovimientoTierra.Controllers
{
    public class ClienteController
    {
        private readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "clientes.csv");

        public ClienteController()
        {
            CrearArchivoSiNoExiste();
        }

        private void CrearArchivoSiNoExiste()
        {
            string carpetaData = Path.GetDirectoryName(rutaArchivo);

            if (!Directory.Exists(carpetaData))
            {
                Directory.CreateDirectory(carpetaData);
            }

            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "IdCliente,Nombre,Apellido,Documento,Correo,Telefono,Sexo,Direccion" + Environment.NewLine);
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            if (!File.Exists(rutaArchivo))
            {
                CrearArchivoSiNoExiste();
                return clientes;
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);

            for (int i = 1; i < lineas.Length; i++)
            {
                string linea = lineas[i];

                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue;
                }

                string[] datos = linea.Split(',');

                if (datos.Length >= 8)
                {
                    Cliente cliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(datos[0]),
                        Nombre = datos[1],
                        Apellido = datos[2],
                        Documento = datos[3],
                        Correo = datos[4],
                        Telefono = datos[5],
                        Sexo = datos[6],
                        Direccion = datos[7]
                    };

                    clientes.Add(cliente);
                }
            }

            return clientes;
        }

        private void GuardarClientes(List<Cliente> clientes)
        {
            List<string> lineas = new List<string>();

            lineas.Add("IdCliente,Nombre,Apellido,Documento,Correo,Telefono,Sexo,Direccion");

            foreach (Cliente cliente in clientes)
            {
                string linea = $"{cliente.IdCliente},{cliente.Nombre},{cliente.Apellido},{cliente.Documento},{cliente.Correo},{cliente.Telefono},{cliente.Sexo},{cliente.Direccion}";
                lineas.Add(linea);
            }

            File.WriteAllLines(rutaArchivo, lineas);
        }

        public int GenerarNuevoId()
        {
            List<Cliente> clientes = ObtenerClientes();
            Random random = new Random();

            int nuevoId;

            do
            {
                nuevoId = random.Next(1000, 10000); 
            }
            while (clientes.Any(c => c.IdCliente == nuevoId));

            return nuevoId;
        }

        public bool RegistrarCliente(Cliente nuevoCliente)
        {
            List<Cliente> clientes = ObtenerClientes();

            bool documentoExiste = clientes.Any(c => c.Documento == nuevoCliente.Documento);

            if (documentoExiste)
            {
                return false;
            }

            clientes.Add(nuevoCliente);
            GuardarClientes(clientes);

            return true;
        }

        public bool EliminarCliente(int idCliente)
        {
            List<Cliente> clientes = ObtenerClientes();

            Cliente cliente = clientes.FirstOrDefault(c => c.IdCliente == idCliente);

            if (cliente == null)
            {
                return false;
            }

            clientes.Remove(cliente);
            GuardarClientes(clientes);

            return true;
        }

        public List<Cliente> BuscarClientes(string texto)
        {
            List<Cliente> clientes = ObtenerClientes();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return clientes;
            }

            texto = texto.ToLower();

            return clientes.Where(c =>
                c.IdCliente.ToString().Contains(texto) ||
                c.Nombre.ToLower().Contains(texto) ||
                c.Apellido.ToLower().Contains(texto) ||
                c.Documento.ToLower().Contains(texto) ||
                c.Correo.ToLower().Contains(texto) ||
                c.Telefono.ToLower().Contains(texto)
            ).ToList();
        }

    }
}