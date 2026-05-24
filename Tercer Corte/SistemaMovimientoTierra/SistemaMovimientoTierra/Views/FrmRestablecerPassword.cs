using SistemaMovimientoTierra.Controllers;
using System;
using System.Windows.Forms;

namespace SistemaMovimientoTierra
{
    public partial class FrmRestablecerPassword : Form
    {
        private UsuarioController usuarioController = new UsuarioController();
        private string usuarioSeleccionado;

        public FrmRestablecerPassword(string nombreUsuario)
        {
            InitializeComponent();
            usuarioSeleccionado = nombreUsuario;
        }

        private void FrmRestablecerPassword_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = usuarioSeleccionado;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            string nuevaPassword = txtNuevaPassword.Text.Trim();
            string confirmarPassword = txtConfirmarPassword.Text.Trim();

            if (nuevaPassword == "" || confirmarPassword == "")
            {
                MessageBox.Show("Debe ingresar y confirmar la nueva contraseña.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (nuevaPassword != confirmarPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string mensajeValidacion;

            bool passwordSegura = usuarioController.ValidarPasswordSegura(nuevaPassword, out mensajeValidacion);

            if (!passwordSegura)
            {
                MessageBox.Show(mensajeValidacion,
                                "Contraseña no válida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool resultado = usuarioController.RestablecerPassword(usuarioSeleccionado, nuevaPassword);

            if (resultado)
            {
                MessageBox.Show("Contraseña restablecida correctamente.",
                                "Proceso exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo restablecer la contraseña.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblConfirmarPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblNuevaPassword_Click(object sender, EventArgs e)
        {

        }
    }
}