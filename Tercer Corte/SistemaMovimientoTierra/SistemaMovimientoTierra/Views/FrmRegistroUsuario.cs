using SistemaMovimientoTierra.Controllers;
using System;
using System.Windows.Forms;

namespace SistemaMovimientoTierra
{
    public partial class FrmRegistroUsuario : Form
    {
        UsuarioController usuarioController = new UsuarioController();

        public FrmRegistroUsuario()
        {
            InitializeComponent();

            cmbRol.Items.Clear();
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Usuario");
            cmbRol.SelectedIndex = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;
            string confirmarPassword = txtConfirmarPassword.Text;
            string rol = cmbRol.Text;

            if (usuario == "" || password == "" || confirmarPassword == "" || rol == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmarPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool registrado = usuarioController.RegistrarUsuario(usuario, password, rol);

            if (registrado)
            {
                MessageBox.Show("Usuario registrado correctamente.",
                                "Registro exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario ya existe.",
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
