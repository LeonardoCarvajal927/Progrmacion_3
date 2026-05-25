using SistemaMovimientoTierra.Controllers;
using SistemaMovimientoTierra.Models;
using System;
using System.Windows.Forms;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmRegistroCliente : Form
    {
        private ClienteController clienteController = new ClienteController();

        public FrmRegistroCliente()
        {
            InitializeComponent();
        }

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {
            CargarComboSexo();
            GenerarIdCliente();
        }

        private void CargarComboSexo()
        {
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");
            cmbSexo.Items.Add("Otro");
            cmbSexo.Items.Add("Prefiere no decir");

            cmbSexo.SelectedIndex = 0;
        }

        private void GenerarIdCliente()
        {
            txtIdCliente.Text = clienteController.GenerarNuevoId().ToString();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
                txtApellido.Text.Trim() == "" ||
                txtDocumento.Text.Trim() == "" ||
                txtCorreo.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "" ||
                cmbSexo.Text == "" ||
                txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = new Cliente
            {
                IdCliente = Convert.ToInt32(txtIdCliente.Text),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Documento = txtDocumento.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Sexo = cmbSexo.Text,
                Direccion = txtDireccion.Text.Trim()
            };

            bool registrado = clienteController.RegistrarCliente(cliente);

            if (registrado)
            {
                MessageBox.Show("Cliente registrado correctamente.",
                                "Registro exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                FrmListaClientes lista = new FrmListaClientes();
                lista.ShowDialog();

                LimpiarCampos();
                GenerarIdCliente();
            }
            else
            {
                MessageBox.Show("Ya existe un cliente con ese documento.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnVerListaClientes_Click(object sender, EventArgs e)
        {
            FrmListaClientes lista = new FrmListaClientes();
            lista.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            GenerarIdCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            if (cmbSexo.Items.Count > 0)
            {
                cmbSexo.SelectedIndex = 0;
            }
        }
    }
}