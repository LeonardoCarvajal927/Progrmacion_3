using SistemaMovimientoTierra.Controllers;
using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmCotizaciones : Form
    {
        private CotizacionController cotizacionController = new CotizacionController();
        private ClienteController clienteController = new ClienteController();
        private MaterialController materialController = new MaterialController();

        private List<Cliente> clientes = new List<Cliente>();
        private List<Material> materiales = new List<Material>();

        public FrmCotizaciones()
        {
            InitializeComponent();
        }

        private void FrmCotizaciones_Load(object sender, EventArgs e)
        {
            HabilitarCampos();

            CargarClientes();
            CargarMateriales();
            CargarEstados();
            GenerarIdCotizacion();
            ConfigurarFormulario();
            CargarCotizaciones();

            CargarPrecioMaterialSeleccionado();
        }

        private void HabilitarCampos()
        {
            // Habilitar grupos principales
            gbDatosCotizacion.Enabled = true;
            gbListaCotizaciones.Enabled = true;

            // Campos que NO se escriben manualmente
            txtIdCotizacion.Enabled = true;
            txtIdCotizacion.ReadOnly = true;
            txtIdCotizacion.TabStop = false;

            txtPrecioUnitario.Enabled = true;
            txtPrecioUnitario.ReadOnly = true;
            txtPrecioUnitario.TabStop = false;

            txtTotal.Enabled = true;
            txtTotal.ReadOnly = true;
            txtTotal.TabStop = false;

            // Campos que SÍ deben dejar escribir
            txtVolumen.Enabled = true;
            txtVolumen.ReadOnly = false;
            txtVolumen.TabStop = true;

            txtObservacion.Enabled = true;
            txtObservacion.ReadOnly = false;
            txtObservacion.TabStop = true;

            txtBuscar.Enabled = true;
            txtBuscar.ReadOnly = false;
            txtBuscar.TabStop = true;

            // Combos
            cmbCliente.Enabled = true;
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.TabStop = true;

            cmbMaterial.Enabled = true;
            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterial.TabStop = true;

            cmbEstado.Enabled = true;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.TabStop = true;

            // Botones
            btnCalcularTotal.Enabled = true;
            btnGuardarCotizacion.Enabled = true;
            btnLimpiar.Enabled = true;
            btnBuscar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminarCotizacion.Enabled = true;
            btnCerrar.Enabled = true;

            // Traer controles al frente por si algún panel quedó encima
            txtIdCotizacion.BringToFront();
            cmbCliente.BringToFront();
            cmbMaterial.BringToFront();
            txtVolumen.BringToFront();
            txtPrecioUnitario.BringToFront();
            txtTotal.BringToFront();
            cmbEstado.BringToFront();
            txtObservacion.BringToFront();
            txtBuscar.BringToFront();
        }

        private void ConfigurarFormulario()
        {
            txtIdCotizacion.ReadOnly = true;
            txtPrecioUnitario.ReadOnly = true;
            txtTotal.ReadOnly = true;

            dgvCotizaciones.RowHeadersVisible = false;
            dgvCotizaciones.AllowUserToAddRows = false;
            dgvCotizaciones.AllowUserToDeleteRows = false;
            dgvCotizaciones.ReadOnly = true;
            dgvCotizaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCotizaciones.MultiSelect = false;
            dgvCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarClientes()
        {
            clientes = clienteController.ObtenerClientes();

            cmbCliente.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                string textoCliente = cliente.Nombre + " " + cliente.Apellido + " - " + cliente.Documento;
                cmbCliente.Items.Add(textoCliente);
            }

            if (cmbCliente.Items.Count > 0)
            {
                cmbCliente.SelectedIndex = 0;
            }
        }

        private void CargarMateriales()
        {
            materiales = materialController.ObtenerMateriales();

            cmbMaterial.Items.Clear();

            foreach (Material material in materiales)
            {
                if (material.Estado == "Activo")
                {
                    cmbMaterial.Items.Add(material.Nombre);
                }
            }

            if (cmbMaterial.Items.Count > 0)
            {
                cmbMaterial.SelectedIndex = 0;
            }
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("Aprobada");
            cmbEstado.Items.Add("Rechazada");

            cmbEstado.SelectedIndex = 0;
        }

        private void GenerarIdCotizacion()
        {
            txtIdCotizacion.Text = cotizacionController.GenerarNuevoId().ToString();
        }

        private void CargarCotizaciones()
        {
            List<Cotizacion> cotizaciones = cotizacionController.ObtenerCotizaciones();

            dgvCotizaciones.DataSource = null;
            dgvCotizaciones.DataSource = cotizaciones;

            ConfigurarTablaCotizaciones();

            dgvCotizaciones.ClearSelection();
        }

        private void ConfigurarTablaCotizaciones()
        {
            dgvCotizaciones.RowHeadersVisible = false;
            dgvCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvCotizaciones.Columns["IdCotizacion"] != null)
            {
                dgvCotizaciones.Columns["IdCotizacion"].HeaderText = "ID";
                dgvCotizaciones.Columns["IdCotizacion"].FillWeight = 50;
            }

            if (dgvCotizaciones.Columns["Cliente"] != null)
            {
                dgvCotizaciones.Columns["Cliente"].HeaderText = "Cliente";
                dgvCotizaciones.Columns["Cliente"].FillWeight = 140;
            }

            if (dgvCotizaciones.Columns["Material"] != null)
            {
                dgvCotizaciones.Columns["Material"].HeaderText = "Material";
                dgvCotizaciones.Columns["Material"].FillWeight = 90;
            }

            if (dgvCotizaciones.Columns["Volumen"] != null)
            {
                dgvCotizaciones.Columns["Volumen"].HeaderText = "Volumen";
                dgvCotizaciones.Columns["Volumen"].DefaultCellStyle.Format = "N2";
                dgvCotizaciones.Columns["Volumen"].FillWeight = 80;
            }

            if (dgvCotizaciones.Columns["PrecioUnitario"] != null)
            {
                dgvCotizaciones.Columns["PrecioUnitario"].HeaderText = "Precio";
                dgvCotizaciones.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N0";
                dgvCotizaciones.Columns["PrecioUnitario"].FillWeight = 80;
            }

            if (dgvCotizaciones.Columns["Total"] != null)
            {
                dgvCotizaciones.Columns["Total"].HeaderText = "Total";
                dgvCotizaciones.Columns["Total"].DefaultCellStyle.Format = "N0";
                dgvCotizaciones.Columns["Total"].FillWeight = 90;
            }

            if (dgvCotizaciones.Columns["Estado"] != null)
            {
                dgvCotizaciones.Columns["Estado"].HeaderText = "Estado";
                dgvCotizaciones.Columns["Estado"].FillWeight = 80;
            }

            if (dgvCotizaciones.Columns["Observacion"] != null)
            {
                dgvCotizaciones.Columns["Observacion"].HeaderText = "Observación";
                dgvCotizaciones.Columns["Observacion"].FillWeight = 120;
            }

            if (dgvCotizaciones.Columns["Fecha"] != null)
            {
                dgvCotizaciones.Columns["Fecha"].HeaderText = "Fecha";
                dgvCotizaciones.Columns["Fecha"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgvCotizaciones.Columns["Fecha"].FillWeight = 90;
            }
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPrecioMaterialSeleccionado();
        }

        private void CargarPrecioMaterialSeleccionado()
        {
            if (cmbMaterial.SelectedIndex < 0)
            {
                return;
            }

            string nombreMaterial = cmbMaterial.Text;

            Material materialSeleccionado = materiales.Find(m => m.Nombre == nombreMaterial);

            if (materialSeleccionado != null)
            {
                txtPrecioUnitario.Text = materialSeleccionado.PrecioUnitario.ToString("N0");
            }
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private bool CalcularTotal()
        {
            decimal volumen;
            decimal precioUnitario;

            if (!decimal.TryParse(txtVolumen.Text.Trim(), out volumen))
            {
                MessageBox.Show("El volumen debe ser un número válido.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            string precioTexto = txtPrecioUnitario.Text.Replace(".", "").Replace(",", "");

            if (!decimal.TryParse(precioTexto, out precioUnitario))
            {
                MessageBox.Show("El precio unitario no es válido.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            if (volumen <= 0)
            {
                MessageBox.Show("El volumen debe ser mayor que cero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            if (precioUnitario <= 0)
            {
                MessageBox.Show("El precio unitario debe ser mayor que cero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            decimal total = volumen * precioUnitario;

            txtTotal.Text = total.ToString("N0");

            return true;
        }

        private void btnGuardarCotizacion_Click(object sender, EventArgs e)
        {
            if (txtIdCotizacion.Text.Trim() == "" ||
                cmbCliente.Text == "" ||
                cmbMaterial.Text == "" ||
                txtVolumen.Text.Trim() == "" ||
                txtPrecioUnitario.Text.Trim() == "" ||
                cmbEstado.Text == "")
            {
                MessageBox.Show("Complete los campos principales de la cotización.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool totalCalculado = CalcularTotal();

            if (!totalCalculado)
            {
                return;
            }

            decimal volumen = Convert.ToDecimal(txtVolumen.Text.Trim());
            decimal precioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text.Replace(".", "").Replace(",", ""));
            decimal total = Convert.ToDecimal(txtTotal.Text.Replace(".", "").Replace(",", ""));

            Cotizacion cotizacion = new Cotizacion
            {
                IdCotizacion = Convert.ToInt32(txtIdCotizacion.Text),
                Cliente = cmbCliente.Text,
                Material = cmbMaterial.Text,
                Volumen = volumen,
                PrecioUnitario = precioUnitario,
                Total = total,
                Estado = cmbEstado.Text,
                Observacion = txtObservacion.Text.Trim(),
                Fecha = DateTime.Now
            };

            bool registrado = cotizacionController.RegistrarCotizacion(cotizacion);

            if (registrado)
            {
                MessageBox.Show("Cotización registrada correctamente.",
                                "Registro exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LimpiarCampos();
                GenerarIdCotizacion();
                CargarCotizaciones();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la cotización.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            dgvCotizaciones.DataSource = null;
            dgvCotizaciones.DataSource = cotizacionController.BuscarCotizaciones(texto);

            ConfigurarTablaCotizaciones();

            dgvCotizaciones.ClearSelection();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarCotizaciones();
        }

        private void btnEliminarCotizacion_Click(object sender, EventArgs e)
        {
            if (dgvCotizaciones.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cotización primero.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idCotizacion = Convert.ToInt32(dgvCotizaciones.CurrentRow.Cells["IdCotizacion"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar la cotización " + idCotizacion + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            bool eliminado = cotizacionController.EliminarCotizacion(idCotizacion);

            if (eliminado)
            {
                MessageBox.Show("Cotización eliminada correctamente.",
                                "Eliminación exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                CargarCotizaciones();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la cotización.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            GenerarIdCotizacion();
        }

        private void LimpiarCampos()
        {
            txtVolumen.Clear();
            txtPrecioUnitario.Clear();
            txtTotal.Clear();
            txtObservacion.Clear();

            if (cmbCliente.Items.Count > 0)
            {
                cmbCliente.SelectedIndex = 0;
            }

            if (cmbMaterial.Items.Count > 0)
            {
                cmbMaterial.SelectedIndex = 0;
            }

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }

            CargarPrecioMaterialSeleccionado();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCotizaciones_Load_1(object sender, EventArgs e)
        {

        }
    }
}