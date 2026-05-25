using SistemaMovimientoTierra.Controllers;
using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmListaClientes : Form
    {
        private ClienteController clienteController = new ClienteController();

        public FrmListaClientes()
        {
            InitializeComponent();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            List<Cliente> clientes = clienteController.ObtenerClientes();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;
            dgvClientes.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clienteController.BuscarClientes(texto);
            dgvClientes.ClearSelection();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarClientes();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente primero.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["IdCliente"].Value);
            string nombre = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            string apellido = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de eliminar al cliente {nombre} {apellido}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            bool eliminado = clienteController.EliminarCliente(idCliente);

            if (eliminado)
            {
                MessageBox.Show("Cliente eliminado correctamente.",
                                "Eliminación exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                CargarClientes();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el cliente.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}