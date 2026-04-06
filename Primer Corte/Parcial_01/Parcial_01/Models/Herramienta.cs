using Parcial_01.Models;

namespace Parcail_01.Models
{

     // Clase que representa una herramienta
    public class Herramienta { 

        public int Id { get; set; }
        public string Descripcion { get; set; } = "";
        public Double Precio { get; set; }
        public TipoHerramienta Tipo { get; set; }

    }
}