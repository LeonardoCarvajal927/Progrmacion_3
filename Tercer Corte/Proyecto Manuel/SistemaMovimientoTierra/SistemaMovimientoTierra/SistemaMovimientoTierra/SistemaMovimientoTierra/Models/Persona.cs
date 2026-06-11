namespace SistemaMovimientoTierra.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, string documento, string correo, string telefono, string sexo, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Correo = correo;
            Telefono = telefono;
            Sexo = sexo;
            Direccion = direccion;
        }
    }
}
