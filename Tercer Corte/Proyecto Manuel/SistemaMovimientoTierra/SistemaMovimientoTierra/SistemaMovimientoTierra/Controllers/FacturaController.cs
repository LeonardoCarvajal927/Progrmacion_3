using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SistemaMovimientoTierra.Controllers
{
    public class FacturaController
    {
        private readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "facturas.csv");

        public FacturaController()
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
                File.WriteAllText(rutaArchivo,
                    "IdFactura,IdCotizacion,Cliente,Material,Volumen,Total,Estado,Observacion,Fecha" + Environment.NewLine);
            }
        }

        public List<Factura> ObtenerFacturas()
        {
            List<Factura> facturas = new List<Factura>();

            if (!File.Exists(rutaArchivo))
            {
                CrearArchivoSiNoExiste();
                return facturas;
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                {
                    continue;
                }

                string[] datos = lineas[i].Split(',');

                if (datos.Length >= 9)
                {
                    Factura factura = new Factura
                    {
                        IdFactura = Convert.ToInt32(datos[0]),
                        IdCotizacion = Convert.ToInt32(datos[1]),
                        Cliente = LimpiarTexto(datos[2]),
                        Material = LimpiarTexto(datos[3]),
                        Volumen = Convert.ToDecimal(datos[4], CultureInfo.InvariantCulture),
                        Total = Convert.ToDecimal(datos[5], CultureInfo.InvariantCulture),
                        Estado = LimpiarTexto(datos[6]),
                        Observacion = LimpiarTexto(datos[7]),
                        Fecha = Convert.ToDateTime(datos[8])
                    };

                    facturas.Add(factura);
                }
            }

            return facturas;
        }

        private void GuardarFacturas(List<Factura> facturas)
        {
            List<string> lineas = new List<string>();

            lineas.Add("IdFactura,IdCotizacion,Cliente,Material,Volumen,Total,Estado,Observacion,Fecha");

            foreach (Factura factura in facturas)
            {
                string linea =
                    factura.IdFactura + "," +
                    factura.IdCotizacion + "," +
                    PrepararTexto(factura.Cliente) + "," +
                    PrepararTexto(factura.Material) + "," +
                    factura.Volumen.ToString(CultureInfo.InvariantCulture) + "," +
                    factura.Total.ToString(CultureInfo.InvariantCulture) + "," +
                    PrepararTexto(factura.Estado) + "," +
                    PrepararTexto(factura.Observacion) + "," +
                    factura.Fecha.ToString("yyyy-MM-dd HH:mm:ss");

                lineas.Add(linea);
            }

            File.WriteAllLines(rutaArchivo, lineas);
        }

        public int GenerarNuevoId()
        {
            List<Factura> facturas = ObtenerFacturas();
            Random random = new Random();

            int nuevoId;

            do
            {
                nuevoId = random.Next(1000, 10000);
            }
            while (facturas.Any(f => f.IdFactura == nuevoId));

            return nuevoId;
        }

        public bool RegistrarFactura(Factura nuevaFactura)
        {
            List<Factura> facturas = ObtenerFacturas();

            bool yaExisteFacturaParaCotizacion = facturas.Any(f => f.IdCotizacion == nuevaFactura.IdCotizacion);

            if (yaExisteFacturaParaCotizacion)
            {
                return false;
            }

            facturas.Add(nuevaFactura);
            GuardarFacturas(facturas);

            return true;
        }

        public List<Factura> BuscarFacturas(string texto)
        {
            List<Factura> facturas = ObtenerFacturas();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return facturas;
            }

            texto = texto.ToLower();

            return facturas.Where(f =>
                f.IdFactura.ToString().Contains(texto) ||
                f.IdCotizacion.ToString().Contains(texto) ||
                f.Cliente.ToLower().Contains(texto) ||
                f.Material.ToLower().Contains(texto) ||
                f.Estado.ToLower().Contains(texto) ||
                f.Fecha.ToString("yyyy-MM-dd").Contains(texto)
            ).ToList();
        }

        public bool EliminarFactura(int idFactura)
        {
            List<Factura> facturas = ObtenerFacturas();

            Factura factura = facturas.FirstOrDefault(f => f.IdFactura == idFactura);

            if (factura == null)
            {
                return false;
            }

            facturas.Remove(factura);
            GuardarFacturas(facturas);

            return true;
        }

        private string PrepararTexto(string texto)
        {
            if (texto == null)
            {
                return "";
            }

            return texto.Replace(",", " ");
        }

        private string LimpiarTexto(string texto)
        {
            if (texto == null)
            {
                return "";
            }

            return texto.Trim();
        }
    }
}