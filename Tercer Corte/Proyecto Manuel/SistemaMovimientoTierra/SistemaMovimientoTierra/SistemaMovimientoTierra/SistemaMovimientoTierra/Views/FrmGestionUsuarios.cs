using SistemaMovimientoTierra.Controllers;
using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaMovimientoTierra
{
    public partial class FrmGestionUsuarios : Form
    {
        private UsuarioController usuarioController = new UsuarioController();

        public FrmGestionUsuarios()
        {
            InitializeComponent();

            cmbRolUsuario.Items.Clear();
            cmbRolUsuario.Items.Add("Administrador");
            cmbRolUsuario.Items.Add("Usuario");
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            List<Usuario> usuarios = usuarioController.ObtenerUsuarios();

            dgvUsuarios.DataSource = null;

            dgvUsuarios.DataSource = usuarios.Select(u => new
            {
                Usuario = u.NombreUsuario,
                Rol = u.Rol,
                Estado = u.Activo ? "Activo" : "Inactivo"
            }).ToList();

            dgvUsuarios.ClearSelection();
            txtUsuarioSeleccionado.Clear();
            cmbRolUsuario.SelectedIndex = -1;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string usuario = dgvUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                string rol = dgvUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();

                txtUsuarioSeleccionado.Text = usuario;
                cmbRolUsuario.Text = rol;
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioSeleccionado.Text == "")
            {
                MessageBox.Show("Seleccione un usuario primero.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool resultado = usuarioController.CambiarEstadoUsuario(txtUsuarioSeleccionado.Text, true);

            if (resultado)
            {
                MessageBox.Show("Usuario activado correctamente.",
                                "Estado actualizado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("No se pudo activar el usuario.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioSeleccionado.Text == "")
            {
                MessageBox.Show("Seleccione un usuario primero.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de inactivar este usuario?",
                                                     "Confirmar acción",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            bool resultado = usuarioController.CambiarEstadoUsuario(txtUsuarioSeleccionado.Text, false);

            if (resultado)
            {
                MessageBox.Show("Usuario inactivado correctamente.",
                                "Estado actualizado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("No se pudo inactivar el usuario.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCambiarRol_Click(object sender, EventArgs e)
        {
            if (txtUsuarioSeleccionado.Text == "")
            {
                MessageBox.Show("Seleccione un usuario primero.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (cmbRolUsuario.Text == "")
            {
                MessageBox.Show("Seleccione un rol.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool resultado = usuarioController.CambiarRolUsuario(
                txtUsuarioSeleccionado.Text,
                cmbRolUsuario.Text
            );

            if (resultado)
            {
                MessageBox.Show("Rol actualizado correctamente.",
                                "Rol actualizado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("No se pudo cambiar el rol del usuario.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnRestablecerPassword_Click(object sender, EventArgs e)
        {
            if (txtUsuarioSeleccionado.Text == "")
            {
                MessageBox.Show("Seleccione un usuario primero.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            FrmRestablecerPassword form = new FrmRestablecerPassword(txtUsuarioSeleccionado.Text);
            form.ShowDialog();
        }

        private void lblUsuarioSeleccionado_Click(object sender, EventArgs e)
        {
            // Evento vacío para evitar error del diseñador.
        }
    }
}