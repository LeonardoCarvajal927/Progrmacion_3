using SistemaMovimientoTierra.Controllers;
using System;
using System.Windows.Forms;

namespace SistemaMovimientoTierra
{
    public partial class FrmCambiarPassword : Form
    {
        private UsuarioController usuarioController = new UsuarioController();
        private string usuarioActual;

        public FrmCambiarPassword()
        {
            InitializeComponent();
        }

        public FrmCambiarPassword(string nombreUsuario)
        {
            InitializeComponent();
            usuarioActual = nombreUsuario;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string passwordActual = txtPasswordActual.Text;
            string nuevoPassword = txtNuevoPassword.Text;
            string confirmarPassword = txtConfirmarPassword.Text;

            if (passwordActual == "" || nuevoPassword == "" || confirmarPassword == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (nuevoPassword != confirmarPassword)
            {
                MessageBox.Show("La nueva contraseña y la confirmación no coinciden.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool resultado = usuarioController.CambiarPassword(
                usuarioActual,
                passwordActual,
                nuevoPassword
            );

            if (resultado)
            {
                MessageBox.Show("Contraseña cambiada correctamente.",
                                "Cambio exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("La contraseña actual no es correcta.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}