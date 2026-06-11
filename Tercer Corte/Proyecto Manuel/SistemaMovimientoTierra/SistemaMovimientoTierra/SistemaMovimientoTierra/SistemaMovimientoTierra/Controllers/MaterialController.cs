using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SistemaMovimientoTierra.Controllers
{
    public class MaterialController
    {
        private readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "materiales.csv");

        public MaterialController()
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
                File.WriteAllText(rutaArchivo, "IdMaterial,Nombre,TipoMaterial,UnidadMedida,PrecioUnitario,Estado,Descripcion" + Environment.NewLine);
            }
        }

        public List<Material> ObtenerMateriales()
        {
            List<Material> materiales = new List<Material>();

            if (!File.Exists(rutaArchivo))
            {
                CrearArchivoSiNoExiste();
                return materiales;
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

                if (datos.Length >= 7)
                {
                    Material material = new Material
                    {
                        IdMaterial = Convert.ToInt32(datos[0]),
                        Nombre = datos[1],
                        TipoMaterial = datos[2],
                        UnidadMedida = datos[3],
                        PrecioUnitario = Convert.ToDecimal(datos[4]),
                        Estado = datos[5],
                        Descripcion = datos[6]
                    };

                    materiales.Add(material);
                }
            }

            return materiales;
        }

        private void GuardarMateriales(List<Material> materiales)
        {
            List<string> lineas = new List<string>();

            lineas.Add("IdMaterial,Nombre,TipoMaterial,UnidadMedida,PrecioUnitario,Estado,Descripcion");

            foreach (Material material in materiales)
            {
                string linea = $"{material.IdMaterial},{material.Nombre},{material.TipoMaterial},{material.UnidadMedida},{material.PrecioUnitario},{material.Estado},{material.Descripcion}";
                lineas.Add(linea);
            }

            File.WriteAllLines(rutaArchivo, lineas);
        }

        public int GenerarNuevoId()
        {
            List<Material> materiales = ObtenerMateriales();
            Random random = new Random();

            int nuevoId;

            do
            {
                nuevoId = random.Next(1000, 10000);
            }
            while (materiales.Any(m => m.IdMaterial == nuevoId));

            return nuevoId;
        }

        public bool RegistrarMaterial(Material nuevoMaterial)
        {
            List<Material> materiales = ObtenerMateriales();

            bool existe = materiales.Any(m =>
                m.Nombre.Equals(nuevoMaterial.Nombre, StringComparison.OrdinalIgnoreCase));

            if (existe)
            {
                return false;
            }

            materiales.Add(nuevoMaterial);
            GuardarMateriales(materiales);

            return true;
        }

        public List<Material> BuscarMateriales(string texto)
        {
            List<Material> materiales = ObtenerMateriales();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return materiales;
            }

            texto = texto.ToLower();

            return materiales.Where(m =>
                m.IdMaterial.ToString().Contains(texto) ||
                m.Nombre.ToLower().Contains(texto) ||
                m.TipoMaterial.ToLower().Contains(texto) ||
                m.UnidadMedida.ToLower().Contains(texto) ||
                m.Estado.ToLower().Contains(texto)
            ).ToList();
        }

        public bool EliminarMaterial(int idMaterial)
        {
            List<Material> materiales = ObtenerMateriales();

            Material material = materiales.FirstOrDefault(m => m.IdMaterial == idMaterial);

            if (material == null)
            {
                return false;
            }

            materiales.Remove(material);
            GuardarMateriales(materiales);

            return true;
        }
    }
}