using System;

namespace SistemaMovimientoTierra.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdCotizacion { get; set; }
        public string Cliente { get; set; }
        public string Material { get; set; }
        public decimal Volumen { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha { get; set; }

        public Factura()
        {
        }
    }
}