using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SistemaMovimientoTierra.Controllers
{
    public class CotizacionController
    {
        private readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "cotizaciones.csv");

        public CotizacionController()
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
                    "IdCotizacion,Cliente,Material,Volumen,PrecioUnitario,Total,Estado,Observacion,Fecha" + Environment.NewLine);
            }
        }

        public List<Cotizacion> ObtenerCotizaciones()
        {
            List<Cotizacion> cotizaciones = new List<Cotizacion>();

            if (!File.Exists(rutaArchivo))
            {
                CrearArchivoSiNoExiste();
                return cotizaciones;
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

                if (datos.Length >= 9)
                {
                    Cotizacion cotizacion = new Cotizacion
                    {
                        IdCotizacion = Convert.ToInt32(datos[0]),
                        Cliente = LimpiarTexto(datos[1]),
                        Material = LimpiarTexto(datos[2]),
                        Volumen = Convert.ToDecimal(datos[3], CultureInfo.InvariantCulture),
                        PrecioUnitario = Convert.ToDecimal(datos[4], CultureInfo.InvariantCulture),
                        Total = Convert.ToDecimal(datos[5], CultureInfo.InvariantCulture),
                        Estado = LimpiarTexto(datos[6]),
                        Observacion = LimpiarTexto(datos[7]),
                        Fecha = Convert.ToDateTime(datos[8])
                    };

                    cotizaciones.Add(cotizacion);
                }
            }

            return cotizaciones;
        }

        private void GuardarCotizaciones(List<Cotizacion> cotizaciones)
        {
            List<string> lineas = new List<string>();

            lineas.Add("IdCotizacion,Cliente,Material,Volumen,PrecioUnitario,Total,Estado,Observacion,Fecha");

            foreach (Cotizacion cotizacion in cotizaciones)
            {
                string linea =
                    cotizacion.IdCotizacion + "," +
                    PrepararTexto(cotizacion.Cliente) + "," +
                    PrepararTexto(cotizacion.Material) + "," +
                    cotizacion.Volumen.ToString(CultureInfo.InvariantCulture) + "," +
                    cotizacion.PrecioUnitario.ToString(CultureInfo.InvariantCulture) + "," +
                    cotizacion.Total.ToString(CultureInfo.InvariantCulture) + "," +
                    PrepararTexto(cotizacion.Estado) + "," +
                    PrepararTexto(cotizacion.Observacion) + "," +
                    cotizacion.Fecha.ToString("yyyy-MM-dd HH:mm:ss");

                lineas.Add(linea);
            }

            File.WriteAllLines(rutaArchivo, lineas);
        }

        public int GenerarNuevoId()
        {
            List<Cotizacion> cotizaciones = ObtenerCotizaciones();
            Random random = new Random();

            int nuevoId;

            do
            {
                nuevoId = random.Next(1000, 10000);
            }
            while (cotizaciones.Any(c => c.IdCotizacion == nuevoId));

            return nuevoId;
        }

        public bool RegistrarCotizacion(Cotizacion nuevaCotizacion)
        {
            List<Cotizacion> cotizaciones = ObtenerCotizaciones();

            bool existe = cotizaciones.Any(c => c.IdCotizacion == nuevaCotizacion.IdCotizacion);

            if (existe)
            {
                return false;
            }

            cotizaciones.Add(nuevaCotizacion);
            GuardarCotizaciones(cotizaciones);

            return true;
        }

        public List<Cotizacion> BuscarCotizaciones(string texto)
        {
            List<Cotizacion> cotizaciones = ObtenerCotizaciones();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return cotizaciones;
            }

            texto = texto.ToLower();

            return cotizaciones.Where(c =>
                c.IdCotizacion.ToString().Contains(texto) ||
                c.Cliente.ToLower().Contains(texto) ||
                c.Material.ToLower().Contains(texto) ||
                c.Estado.ToLower().Contains(texto) ||
                c.Fecha.ToString("yyyy-MM-dd").Contains(texto)
            ).ToList();
        }

        public bool EliminarCotizacion(int idCotizacion)
        {
            List<Cotizacion> cotizaciones = ObtenerCotizaciones();

            Cotizacion cotizacion = cotizaciones.FirstOrDefault(c => c.IdCotizacion == idCotizacion);

            if (cotizacion == null)
            {
                return false;
            }

            cotizaciones.Remove(cotizacion);
            GuardarCotizaciones(cotizaciones);

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