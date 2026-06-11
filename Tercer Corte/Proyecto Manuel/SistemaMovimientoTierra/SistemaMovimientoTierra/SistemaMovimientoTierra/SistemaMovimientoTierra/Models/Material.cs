namespace SistemaMovimientoTierra.Models
{
    public class Material
    {
        public int IdMaterial { get; set; }
        public string Nombre { get; set; }
        public string TipoMaterial { get; set; }
        public string UnidadMedida { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }

        public Material()
        {
        }

        public Material(int idMaterial, string nombre, string tipoMaterial, string unidadMedida, decimal precioUnitario, string estado, string descripcion)
        {
            IdMaterial = idMaterial;
            Nombre = nombre;
            TipoMaterial = tipoMaterial;
            UnidadMedida = unidadMedida;
            PrecioUnitario = precioUnitario;
            Estado = estado;
            Descripcion = descripcion;
        }
    }
}