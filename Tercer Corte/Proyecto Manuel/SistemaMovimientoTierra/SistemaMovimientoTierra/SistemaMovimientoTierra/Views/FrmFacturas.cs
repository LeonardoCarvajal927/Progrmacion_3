using SistemaMovimientoTierra.Controllers;
using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmFacturas : Form
    {
        private FacturaController facturaController = new FacturaController();
        private CotizacionController cotizacionController = new CotizacionController();

        private List<Cotizacion> cotizaciones = new List<Cotizacion>();

        public FrmFacturas()
        {
            InitializeComponent();
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            HabilitarCampos();
            CargarEstados();
            CargarCotizaciones();
            GenerarIdFactura();
            ConfigurarTabla();
            CargarFacturas();
        }

        private void HabilitarCampos()
        {
            gbDatosFactura.Enabled = true;
            gbListaFacturas.Enabled = true;

            txtIdFactura.Enabled = true;
            txtIdFactura.ReadOnly = true;
            txtIdFactura.TabStop = false;

            txtCliente.Enabled = true;
            txtCliente.ReadOnly = true;
            txtCliente.TabStop = false;

            txtObservacion.Enabled = true;
            txtObservacion.ReadOnly = false;
            txtObservacion.TabStop = true;

            txtBuscar.Enabled = true;
            txtBuscar.ReadOnly = false;
            txtBuscar.TabStop = true;

            cmbCotizacion.Enabled = true;
            cmbCotizacion.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbEstado.Enabled = true;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            btnGuardarFactura.Enabled = true;
            btnVerFactura.Enabled = true;
            btnLimpiar.Enabled = true;
            btnBuscar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminarFactura.Enabled = true;
            btnCerrar.Enabled = true;

            txtIdFactura.BringToFront();
            cmbCotizacion.BringToFront();
            txtCliente.BringToFront();
            cmbEstado.BringToFront();
            txtObservacion.BringToFront();
            txtBuscar.BringToFront();
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Activa");
            cmbEstado.Items.Add("Inactiva");

            cmbEstado.SelectedIndex = 0;
        }

        private void CargarCotizaciones()
        {
            cotizaciones = cotizacionController.ObtenerCotizaciones();

            cmbCotizacion.Items.Clear();

            foreach (Cotizacion cotizacion in cotizaciones)
            {
                string texto = cotizacion.IdCotizacion + " - " + cotizacion.Cliente;
                cmbCotizacion.Items.Add(texto);
            }

            if (cmbCotizacion.Items.Count > 0)
            {
                cmbCotizacion.SelectedIndex = 0;
                CargarDatosCotizacionSeleccionada();
            }
            else
            {
                txtCliente.Clear();
            }
        }

        private void GenerarIdFactura()
        {
            txtIdFactura.Text = facturaController.GenerarNuevoId().ToString();
        }

        private void cmbCotizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosCotizacionSeleccionada();
        }

        private void CargarDatosCotizacionSeleccionada()
        {
            if (cmbCotizacion.SelectedIndex < 0 || cotizaciones.Count == 0)
            {
                return;
            }

            Cotizacion cotizacion = cotizaciones[cmbCotizacion.SelectedIndex];

            txtCliente.Text = cotizacion.Cliente;
        }

        private void ConfigurarTabla()
        {
            dgvFacturas.RowHeadersVisible = false;
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.ReadOnly = true;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.MultiSelect = false;
            dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFacturas.BackgroundColor = System.Drawing.Color.White;
        }

        private void CargarFacturas()
        {
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = facturaController.ObtenerFacturas();

            ConfigurarColumnas();
            dgvFacturas.ClearSelection();
        }

        private void ConfigurarColumnas()
        {
            dgvFacturas.RowHeadersVisible = false;
            dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvFacturas.Columns["IdFactura"] != null)
            {
                dgvFacturas.Columns["IdFactura"].HeaderText = "Factura";
                dgvFacturas.Columns["IdFactura"].FillWeight = 70;
            }

            if (dgvFacturas.Columns["IdCotizacion"] != null)
            {
                dgvFacturas.Columns["IdCotizacion"].HeaderText = "Cotización";
                dgvFacturas.Columns["IdCotizacion"].FillWeight = 80;
            }

            if (dgvFacturas.Columns["Cliente"] != null)
            {
                dgvFacturas.Columns["Cliente"].HeaderText = "Cliente";
                dgvFacturas.Columns["Cliente"].FillWeight = 220;
            }

            if (dgvFacturas.Columns["Estado"] != null)
            {
                dgvFacturas.Columns["Estado"].HeaderText = "Estado";
                dgvFacturas.Columns["Estado"].FillWeight = 90;
            }

            if (dgvFacturas.Columns["Fecha"] != null)
            {
                dgvFacturas.Columns["Fecha"].HeaderText = "Fecha";
                dgvFacturas.Columns["Fecha"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dgvFacturas.Columns["Fecha"].FillWeight = 100;
            }

            // Ocultamos columnas de detalle para que la tabla no se vea amontonada.
            // Estos datos siguen guardados y salen en "Ver factura".
            if (dgvFacturas.Columns["Material"] != null)
            {
                dgvFacturas.Columns["Material"].Visible = false;
            }

            if (dgvFacturas.Columns["Volumen"] != null)
            {
                dgvFacturas.Columns["Volumen"].Visible = false;
            }

            if (dgvFacturas.Columns["Total"] != null)
            {
                dgvFacturas.Columns["Total"].Visible = false;
            }

            if (dgvFacturas.Columns["Observacion"] != null)
            {
                dgvFacturas.Columns["Observacion"].Visible = false;
            }
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (cmbCotizacion.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una cotización.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Cotizacion cotizacion = cotizaciones[cmbCotizacion.SelectedIndex];

            Factura factura = new Factura
            {
                IdFactura = Convert.ToInt32(txtIdFactura.Text),
                IdCotizacion = cotizacion.IdCotizacion,
                Cliente = cotizacion.Cliente,
                Material = cotizacion.Material,
                Volumen = cotizacion.Volumen,
                Total = cotizacion.Total,
                Estado = cmbEstado.Text,
                Observacion = txtObservacion.Text.Trim(),
                Fecha = DateTime.Now
            };

            bool registrado = facturaController.RegistrarFactura(factura);

            if (registrado)
            {
                MessageBox.Show("Factura registrada correctamente.",
                                "Registro exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                string textoFactura = GenerarTextoFactura(factura);
                FrmVistaFactura vista = new FrmVistaFactura(textoFactura);
                vista.ShowDialog();

                LimpiarCampos();
                GenerarIdFactura();
                CargarFacturas();
            }
            else
            {
                MessageBox.Show("Ya existe una factura para esta cotización.",
                                "Factura existente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una factura de la lista.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Factura factura = dgvFacturas.CurrentRow.DataBoundItem as Factura;

            if (factura == null)
            {
                return;
            }

            string textoFactura = GenerarTextoFactura(factura);
            FrmVistaFactura vista = new FrmVistaFactura(textoFactura);
            vista.ShowDialog();
        }

        private string GenerarTextoFactura(Factura factura)
        {
            string texto = "";

            texto += "========================================\r\n";
            texto += "              UPC GEOOBRAS\r\n";
            texto += "      SISTEMA MOVIMIENTO DE TIERRAS\r\n";
            texto += "========================================\r\n";
            texto += "FACTURA No: " + factura.IdFactura + "\r\n";
            texto += "COTIZACIÓN: " + factura.IdCotizacion + "\r\n";
            texto += "FECHA: " + factura.Fecha.ToString("yyyy-MM-dd HH:mm") + "\r\n";
            texto += "----------------------------------------\r\n";
            texto += "CLIENTE:\r\n";
            texto += factura.Cliente + "\r\n";
            texto += "----------------------------------------\r\n";
            texto += "MATERIAL: " + factura.Material + "\r\n";
            texto += "VOLUMEN: " + factura.Volumen.ToString("N2") + " m³\r\n";
            texto += "TOTAL: $" + factura.Total.ToString("N0") + "\r\n";
            texto += "ESTADO: " + factura.Estado + "\r\n";
            texto += "----------------------------------------\r\n";
            texto += "OBSERVACIÓN:\r\n";
            texto += factura.Observacion + "\r\n";
            texto += "========================================\r\n";
            texto += "        Gracias por confiar en nosotros\r\n";
            texto += "========================================\r\n";

            return texto;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = facturaController.BuscarFacturas(texto);

            ConfigurarColumnas();
            dgvFacturas.ClearSelection();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarFacturas();
        }

        private void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una factura primero.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idFactura = Convert.ToInt32(dgvFacturas.CurrentRow.Cells["IdFactura"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar la factura " + idFactura + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            bool eliminado = facturaController.EliminarFactura(idFactura);

            if (eliminado)
            {
                MessageBox.Show("Factura eliminada correctamente.",
                                "Eliminación exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                CargarFacturas();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            GenerarIdFactura();
        }

        private void LimpiarCampos()
        {
            txtObservacion.Clear();

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }

            if (cmbCotizacion.Items.Count > 0)
            {
                cmbCotizacion.SelectedIndex = 0;
                CargarDatosCotizacionSeleccionada();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}