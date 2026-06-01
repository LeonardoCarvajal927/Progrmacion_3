namespace SistemaMovimientoTierra.Models
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }

        public Cliente()
        {
        }

        public Cliente(int idCliente, string nombre, string apellido, string documento, string correo, string telefono, string sexo, string direccion)
            : base(nombre, apellido, documento, correo, telefono, sexo, direccion)
        {
            IdCliente = idCliente;
        }
    }
}
