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
        private string rolUsuario;

        public FrmFacturas()
        {
            InitializeComponent();

            rolUsuario = "Usuario";

            cmbCotizacion.SelectedIndexChanged += cmbCotizacion_SelectedIndexChanged;
        }

        public FrmFacturas(string rol)
        {
            InitializeComponent();

            rolUsuario = rol;

            cmbCotizacion.SelectedIndexChanged += cmbCotizacion_SelectedIndexChanged;
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            HabilitarCampos();
            ConfigurarPermisosPorRol();
            CargarEstados();
            CargarCotizacionesDisponibles();
            GenerarIdFactura();
            ConfigurarTabla();
            CargarFacturas();
            LimpiarCampos();
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

        private void ConfigurarPermisosPorRol()
        {
            if (rolUsuario == "Administrador")
            {
                btnCambiarEstado.Visible = true;
                btnCambiarEstado.Enabled = true;
            }
            else
            {
                btnCambiarEstado.Visible = false;
                btnCambiarEstado.Enabled = false;
            }
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();

            cmbEstado.Items.Add("Activa");
            cmbEstado.Items.Add("Inactiva");

            cmbEstado.SelectedIndex = -1;
            cmbEstado.Text = "";
        }

        private void CargarCotizacionesDisponibles()
        {
            List<Cotizacion> todasLasCotizaciones = cotizacionController.ObtenerCotizaciones();
            List<Factura> facturas = facturaController.ObtenerFacturas();

            cotizaciones.Clear();
            cmbCotizacion.Items.Clear();

            foreach (Cotizacion cotizacion in todasLasCotizaciones)
            {
                bool yaTieneFactura = false;

                foreach (Factura factura in facturas)
                {
                    if (factura.IdCotizacion == cotizacion.IdCotizacion)
                    {
                        yaTieneFactura = true;
                        break;
                    }
                }

                if (!yaTieneFactura)
                {
                    cotizaciones.Add(cotizacion);

                    string texto = cotizacion.IdCotizacion + " - " + cotizacion.Cliente;
                    cmbCotizacion.Items.Add(texto);
                }
            }

            cmbCotizacion.SelectedIndex = -1;
            cmbCotizacion.Text = "";
            txtCliente.Clear();
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
            if (cmbCotizacion.SelectedIndex < 0)
            {
                txtCliente.Clear();
                return;
            }

            if (cmbCotizacion.SelectedIndex >= cotizaciones.Count)
            {
                txtCliente.Clear();
                return;
            }

            Cotizacion cotizacion = cotizaciones[cmbCotizacion.SelectedIndex];

            if (cotizacion == null)
            {
                txtCliente.Clear();
                return;
            }

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

            if (cmbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar el estado de la factura.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (txtCliente.Text.Trim() == "")
            {
                MessageBox.Show("No se ha cargado el cliente de la cotización seleccionada.",
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
                CargarCotizacionesDisponibles();
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

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (rolUsuario != "Administrador")
            {
                MessageBox.Show("Solo el administrador puede cambiar el estado de una factura.",
                                "Acceso denegado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

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

            string nuevoEstado;

            if (factura.Estado == "Activa")
            {
                nuevoEstado = "Inactiva";
            }
            else
            {
                nuevoEstado = "Activa";
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea cambiar la factura " + factura.IdFactura + " de " + factura.Estado + " a " + nuevoEstado + "?",
                "Cambiar estado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            bool actualizado = facturaController.CambiarEstadoFactura(factura.IdFactura, nuevoEstado);

            if (actualizado)
            {
                MessageBox.Show("Estado de factura actualizado correctamente.",
                                "Actualizado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                CargarFacturas();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el estado de la factura.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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

            CargarCotizacionesDisponibles();
            CargarFacturas();
            LimpiarCampos();
            GenerarIdFactura();
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

                CargarCotizacionesDisponibles();
                CargarFacturas();
                LimpiarCampos();
                GenerarIdFactura();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            GenerarIdFactura();
        }

        private void LimpiarCampos()
        {
            cmbCotizacion.SelectedIndex = -1;
            cmbCotizacion.Text = "";

            txtCliente.Clear();
            txtObservacion.Clear();

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = -1;
                cmbEstado.Text = "";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}