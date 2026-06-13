using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SistemaMovimientoTierra.Controllers
{
    public class CalculoTerrenoController
    {
        private readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "calculos_terreno.csv");

        public CalculoTerrenoController()
        {
            CrearArchivoSiNoExiste();
        }

        private void CrearArchivoSiNoExiste()
        {
            string carpeta = Path.GetDirectoryName(rutaArchivo);

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo,
                    "IdCalculo,IdCliente,NombreCliente,IdMaterial,NombreMaterial,Volumen,PrecioUnitario,TotalEstimado,Metodo,Fecha" + Environment.NewLine);
            }
        }

        public List<CalculoTerreno> ObtenerCalculos()
        {
            List<CalculoTerreno> lista = new List<CalculoTerreno>();

            if (!File.Exists(rutaArchivo))
            {
                CrearArchivoSiNoExiste();
                return lista;
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                {
                    continue;
                }

                string[] datos = lineas[i].Split(',');

                if (datos.Length >= 10)
                {
                    CalculoTerreno calculo = new CalculoTerreno();

                    calculo.IdCalculo = Convert.ToInt32(datos[0]);
                    calculo.IdCliente = Convert.ToInt32(datos[1]);
                    calculo.NombreCliente = datos[2];
                    calculo.IdMaterial = Convert.ToInt32(datos[3]);
                    calculo.NombreMaterial = datos[4];
                    calculo.Volumen = Convert.ToDouble(datos[5], CultureInfo.InvariantCulture);
                    calculo.PrecioUnitario = Convert.ToDecimal(datos[6], CultureInfo.InvariantCulture);
                    calculo.TotalEstimado = Convert.ToDecimal(datos[7], CultureInfo.InvariantCulture);
                    calculo.Metodo = datos[8];
                    calculo.Fecha = Convert.ToDateTime(datos[9]);

                    lista.Add(calculo);
                }
            }

            return lista;
        }

        public int GenerarNuevoId()
        {
            List<CalculoTerreno> calculos = ObtenerCalculos();
            Random random = new Random();

            int nuevoId;

            do
            {
                nuevoId = random.Next(1000, 10000);
            }
            while (calculos.Any(c => c.IdCalculo == nuevoId));

            return nuevoId;
        }

        public void GuardarCalculo(CalculoTerreno calculo)
        {
            CrearArchivoSiNoExiste();

            string linea =
                calculo.IdCalculo + "," +
                calculo.IdCliente + "," +
                PrepararTexto(calculo.NombreCliente) + "," +
                calculo.IdMaterial + "," +
                PrepararTexto(calculo.NombreMaterial) + "," +
                calculo.Volumen.ToString(CultureInfo.InvariantCulture) + "," +
                calculo.PrecioUnitario.ToString(CultureInfo.InvariantCulture) + "," +
                calculo.TotalEstimado.ToString(CultureInfo.InvariantCulture) + "," +
                PrepararTexto(calculo.Metodo) + "," +
                calculo.Fecha.ToString("yyyy-MM-dd HH:mm:ss");

            File.AppendAllText(rutaArchivo, linea + Environment.NewLine);
        }

        private string PrepararTexto(string texto)
        {
            if (texto == null)
            {
                return "";
            }

            return texto.Replace(",", " ");
        }
    }
}