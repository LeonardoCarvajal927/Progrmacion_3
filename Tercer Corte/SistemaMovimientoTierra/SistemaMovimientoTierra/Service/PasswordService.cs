namespace SistemaMovimientoTierra.Service
{
    public class PasswordService
    {
        public string GenerarHash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerificarPassword(string passwordIngresada, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(passwordIngresada, passwordHash);
        }
    }
}