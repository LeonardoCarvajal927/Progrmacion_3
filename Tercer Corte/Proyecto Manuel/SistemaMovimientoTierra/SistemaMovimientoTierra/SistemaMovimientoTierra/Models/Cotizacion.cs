using System;

namespace SistemaMovimientoTierra.Models
{
    public class Cotizacion
    {
        public int IdCotizacion { get; set; }
        public string Cliente { get; set; }
        public string Material { get; set; }
        public decimal Volumen { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha { get; set; }

        public Cotizacion()
        {
        }

        public Cotizacion(int idCotizacion, string cliente, string material, decimal volumen,
                          decimal precioUnitario, decimal total, string estado,
                          string observacion, DateTime fecha)
        {
            IdCotizacion = idCotizacion;
            Cliente = cliente;
            Material = material;
            Volumen = volumen;
            PrecioUnitario = precioUnitario;
            Total = total;
            Estado = estado;
            Observacion = observacion;
            Fecha = fecha;
        }
    }
}