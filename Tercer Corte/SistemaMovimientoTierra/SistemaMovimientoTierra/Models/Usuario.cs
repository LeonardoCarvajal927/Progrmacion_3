namespace SistemaMovimientoTierra.Models
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string PasswordHash { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }

        public Usuario()
        {
            Activo = true;
        }

        public Usuario(string nombreUsuario, string passwordHash, string rol, bool activo)
        {
            NombreUsuario = nombreUsuario;
            PasswordHash = passwordHash;
            Rol = rol;
            Activo = activo;
        }
    }
}