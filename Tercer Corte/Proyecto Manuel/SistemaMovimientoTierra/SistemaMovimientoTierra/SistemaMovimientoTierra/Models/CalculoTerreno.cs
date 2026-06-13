using System;

namespace SistemaMovimientoTierra.Models
{
    public class CalculoTerreno
    {
        public int IdCalculo { get; set; }

        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }

        public int IdMaterial { get; set; }
        public string NombreMaterial { get; set; }

        public double Volumen { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal TotalEstimado { get; set; }

        public string Metodo { get; set; }
        public DateTime Fecha { get; set; }

        public CalculoTerreno()
        {
        }
    }
}