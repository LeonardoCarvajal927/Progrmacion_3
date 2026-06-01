using SistemaMovimientoTierra.Controllers;
using SistemaMovimientoTierra.Models;
using System;
using System.Windows.Forms;

namespace SistemaMovimientoTierra
{
    public partial class FrmLogin : Form
    {
        private UsuarioController usuarioController = new UsuarioController();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            if (nombreUsuario == "" || password == "")
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.",
                                "Campos obligatorios",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = usuarioController.IniciarSesion(nombreUsuario, password);

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos, o usuario inactivo.",
                                "Acceso denegado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Bienvenido " + usuario.NombreUsuario,
                            "Acceso correcto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            FrmMenuPrincipal menu = new FrmMenuPrincipal(usuario);
            menu.Show();

            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario registro = new FrmRegistroUsuario();
            registro.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}