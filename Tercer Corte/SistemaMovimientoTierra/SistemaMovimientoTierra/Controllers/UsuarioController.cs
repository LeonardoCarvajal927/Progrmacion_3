using SistemaMovimientoTierra.Models;
using SistemaMovimientoTierra.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SistemaMovimientoTierra.Controllers
{
    public class UsuarioController
    {
        private readonly string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "usuarios.csv");
        private readonly PasswordService passwordService = new PasswordService();

        public UsuarioController()
        {
            CrearArchivoSiNoExiste();
        }

        private void CrearArchivoSiNoExiste()
        {
            string carpetaData = Path.GetDirectoryName(rutaArchivo);

            if (!Directory.Exists(carpetaData))
            {
                Directory.CreateDirectory(carpetaData);
            }

            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "NombreUsuario,PasswordHash,Rol,Activo" + Environment.NewLine);
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            if (!File.Exists(rutaArchivo))
            {
                CrearArchivoSiNoExiste();
                return usuarios;
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);

            for (int i = 1; i < lineas.Length; i++)
            {
                string linea = lineas[i];

                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue;
                }

                string[] datos = linea.Split(',');

                if (datos.Length >= 4)
                {
                    Usuario usuario = new Usuario
                    {
                        NombreUsuario = datos[0],
                        PasswordHash = datos[1],
                        Rol = datos[2],
                        Activo = Convert.ToBoolean(datos[3])
                    };

                    usuarios.Add(usuario);
                }
            }

            return usuarios;
        }

        private void GuardarUsuarios(List<Usuario> usuarios)
        {
            List<string> lineas = new List<string>();

            lineas.Add("NombreUsuario,PasswordHash,Rol,Activo");

            foreach (Usuario usuario in usuarios)
            {
                string linea = $"{usuario.NombreUsuario},{usuario.PasswordHash},{usuario.Rol},{usuario.Activo}";
                lineas.Add(linea);
            }

            File.WriteAllLines(rutaArchivo, lineas);
        }

        public bool RegistrarUsuario(string nombreUsuario, string password, string rol)
        {
            List<Usuario> usuarios = ObtenerUsuarios();

            bool existe = usuarios.Any(u => u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));

            if (existe)
            {
                return false;
            }

            string passwordHash = passwordService.GenerarHash(password);

            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = nombreUsuario,
                PasswordHash = passwordHash,
                Rol = rol,
                Activo = true
            };

            usuarios.Add(nuevoUsuario);
            GuardarUsuarios(usuarios);

            return true;
        }

        public Usuario IniciarSesion(string nombreUsuario, string password)
        {
            List<Usuario> usuarios = ObtenerUsuarios();

            Usuario usuario = usuarios.FirstOrDefault(u =>
                u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));

            if (usuario == null)
            {
                return null;
            }

            if (!usuario.Activo)
            {
                return null;
            }

            bool passwordCorrecta = passwordService.VerificarPassword(password, usuario.PasswordHash);

            if (!passwordCorrecta)
            {
                return null;
            }

            return usuario;
        }

        public bool CambiarEstadoUsuario(string nombreUsuario, bool activo)
        {
            List<Usuario> usuarios = ObtenerUsuarios();

            Usuario usuario = usuarios.FirstOrDefault(u =>
                u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));

            if (usuario == null)
            {
                return false;
            }

            usuario.Activo = activo;
            GuardarUsuarios(usuarios);

            return true;
        }

        public bool CambiarRolUsuario(string nombreUsuario, string nuevoRol)
        {
            List<Usuario> usuarios = ObtenerUsuarios();

            Usuario usuario = usuarios.FirstOrDefault(u =>
                u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));

            if (usuario == null)
            {
                return false;
            }

            usuario.Rol = nuevoRol;
            GuardarUsuarios(usuarios);

            return true;
        }

        public bool CambiarPassword(string nombreUsuario, string passwordActual, string nuevoPassword)
        {
            List<Usuario> usuarios = ObtenerUsuarios();

            Usuario usuario = usuarios.FirstOrDefault(u =>
                u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));

            if (usuario == null)
            {
                return false;
            }

            bool passwordActualCorrecta = passwordService.VerificarPassword(passwordActual, usuario.PasswordHash);

            if (!passwordActualCorrecta)
            {
                return false;
            }

            usuario.PasswordHash = passwordService.GenerarHash(nuevoPassword);
            GuardarUsuarios(usuarios);

            return true;
        }

        public bool RestablecerPassword(string nombreUsuario, string nuevoPassword)
        {
            List<Usuario> usuarios = ObtenerUsuarios();

            Usuario usuario = usuarios.FirstOrDefault(u =>
                u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));

            if (usuario == null)
            {
                return false;
            }

            usuario.PasswordHash = passwordService.GenerarHash(nuevoPassword);
            GuardarUsuarios(usuarios);

            return true;
        }
    }
}