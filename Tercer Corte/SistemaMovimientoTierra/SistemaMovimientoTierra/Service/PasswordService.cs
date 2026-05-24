using System.Linq;

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

        public bool ValidarPasswordSegura(string password, out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                mensaje = "La contraseña no puede estar vacía.";
                return false;
            }

            if (password.Length < 8)
            {
                mensaje = "La contraseña debe tener mínimo 8 caracteres.";
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                mensaje = "La contraseña debe contener al menos una letra mayúscula.";
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                mensaje = "La contraseña debe contener al menos un número.";
                return false;
            }

            if (!password.Any(c => !char.IsLetterOrDigit(c)))
            {
                mensaje = "La contraseña debe contener al menos un carácter especial, por ejemplo: *, @, #, $, %, !";
                return false;
            }

            mensaje = "Contraseña válida.";
            return true;
        }
    }
}