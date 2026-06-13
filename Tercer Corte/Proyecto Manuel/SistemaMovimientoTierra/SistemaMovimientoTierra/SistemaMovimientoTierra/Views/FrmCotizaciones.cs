using SistemaMovimientoTierra.Controllers;
using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmCotizaciones : Form
    {
        private CotizacionController cotizacionController = new CotizacionController();
        private CalculoTerrenoController calculoTerrenoController = new CalculoTerrenoController();

        private CalculoTerreno calculoSeleccionado = null;

        public FrmCotizaciones()
        {
            InitializeComponent();

            // Conectamos el evento por código para que al seleccionar un cálculo
            // se llenen automáticamente los campos.
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
        }

        private void FrmCotizaciones_Load(object sender, EventArgs e)
        {
            HabilitarCampos();

            CargarCalculosTerreno();
            CargarEstados();
            GenerarIdCotizacion();
            ConfigurarFormulario();
            CargarCotizaciones();

            LimpiarCampos();
        }

        private void HabilitarCampos()
        {
            gbDatosCotizacion.Enabled = true;
            gbListaCotizaciones.Enabled = true;

            txtIdCotizacion.Enabled = true;
            txtIdCotizacion.ReadOnly = true;
            txtIdCotizacion.TabStop = false;

            // El combo de cliente realmente carga los cálculos guardados.
            cmbCliente.Enabled = true;
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.TabStop = true;

            // El material ya viene desde el cálculo guardado, no se debe editar.
            cmbMaterial.Enabled = false;
            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterial.TabStop = false;

            // Estos campos se llenan automáticamente desde el cálculo guardado.
            txtVolumen.Enabled = true;
            txtVolumen.ReadOnly = true;
            txtVolumen.TabStop = false;

            txtPrecioUnitario.Enabled = true;
            txtPrecioUnitario.ReadOnly = true;
            txtPrecioUnitario.TabStop = false;

            txtTotal.Enabled = true;
            txtTotal.ReadOnly = true;
            txtTotal.TabStop = false;

            // Estos sí quedan editables.
            cmbEstado.Enabled = true;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.TabStop = true;

            txtObservacion.Enabled = true;
            txtObservacion.ReadOnly = false;
            txtObservacion.TabStop = true;

            txtBuscar.Enabled = true;
            txtBuscar.ReadOnly = false;
            txtBuscar.TabStop = true;

            // Botones
            btnCalcularTotal.Enabled = true;
            btnGuardarCotizacion.Enabled = true;
            btnLimpiar.Enabled = true;
            btnBuscar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminarCotizacion.Enabled = true;
            btnCerrar.Enabled = true;

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
            txtVolumen.ReadOnly = true;
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

        private void CargarCalculosTerreno()
        {
            cmbCliente.Items.Clear();

            List<CalculoTerreno> calculos = calculoTerrenoController.ObtenerCalculos();
            List<Cotizacion> cotizaciones = cotizacionController.ObtenerCotizaciones();

            foreach (CalculoTerreno calculo in calculos)
            {
                bool clienteYaTieneCotizacion = false;

                foreach (Cotizacion cotizacion in cotizaciones)
                {
                    if (cotizacion.Cliente == calculo.NombreCliente)
                    {
                        clienteYaTieneCotizacion = true;
                        break;
                    }
                }

                if (clienteYaTieneCotizacion == false)
                {
                    ComboBoxItem<CalculoTerreno> item = new ComboBoxItem<CalculoTerreno>();

                    item.Text = calculo.NombreCliente + " - " +
                                calculo.NombreMaterial + " - " +
                                calculo.Volumen.ToString("N2") + " m³";

                    item.Value = calculo;

                    cmbCliente.Items.Add(item);
                }
            }

            cmbCliente.SelectedIndex = -1;
            calculoSeleccionado = null;
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

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem == null)
            {
                calculoSeleccionado = null;
                LimpiarCamposAutomaticos();
                return;
            }

            ComboBoxItem<CalculoTerreno> item = cmbCliente.SelectedItem as ComboBoxItem<CalculoTerreno>;

            if (item == null)
            {
                calculoSeleccionado = null;
                LimpiarCamposAutomaticos();
                return;
            }

            calculoSeleccionado = item.Value;

            cmbMaterial.Items.Clear();
            cmbMaterial.Items.Add(calculoSeleccionado.NombreMaterial);
            cmbMaterial.SelectedIndex = 0;

            txtVolumen.Text = calculoSeleccionado.Volumen.ToString("N2");
            txtPrecioUnitario.Text = calculoSeleccionado.PrecioUnitario.ToString("N0");
            txtTotal.Text = calculoSeleccionado.TotalEstimado.ToString("N0");
        }

        private void LimpiarCamposAutomaticos()
        {
            cmbMaterial.Items.Clear();
            cmbMaterial.Text = "";

            txtVolumen.Clear();
            txtPrecioUnitario.Clear();
            txtTotal.Clear();
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private bool CalcularTotal()
        {
            if (calculoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cálculo de terreno guardado.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            txtVolumen.Text = calculoSeleccionado.Volumen.ToString("N2");
            txtPrecioUnitario.Text = calculoSeleccionado.PrecioUnitario.ToString("N0");
            txtTotal.Text = calculoSeleccionado.TotalEstimado.ToString("N0");

            return true;
        }

        private void btnGuardarCotizacion_Click(object sender, EventArgs e)
        {
            if (calculoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cálculo de terreno guardado.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (txtIdCotizacion.Text.Trim() == "" ||
                cmbEstado.Text == "")
            {
                MessageBox.Show("Complete los campos principales de la cotización.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            List<Cotizacion> cotizacionesExistentes = cotizacionController.ObtenerCotizaciones();

            foreach (Cotizacion cotizacionExistente in cotizacionesExistentes)
            {
                if (cotizacionExistente.Cliente == calculoSeleccionado.NombreCliente)
                {
                    MessageBox.Show("Este cliente ya tiene una cotización registrada. No se puede crear otra cotización para el mismo cliente.",
                                    "Cotización duplicada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
            }

            bool totalCalculado = CalcularTotal();

            if (!totalCalculado)
            {
                return;
            }

            Cotizacion cotizacion = new Cotizacion
            {
                IdCotizacion = Convert.ToInt32(txtIdCotizacion.Text),
                Cliente = calculoSeleccionado.NombreCliente,
                Material = calculoSeleccionado.NombreMaterial,
                Volumen = Convert.ToDecimal(calculoSeleccionado.Volumen),
                PrecioUnitario = calculoSeleccionado.PrecioUnitario,
                Total = calculoSeleccionado.TotalEstimado,
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
                CargarCalculosTerreno();
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
            CargarCalculosTerreno();
            LimpiarCampos();
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
            calculoSeleccionado = null;

            if (cmbCliente.Items.Count > 0)
            {
                cmbCliente.SelectedIndex = -1;
            }

            cmbMaterial.Items.Clear();
            cmbMaterial.Text = "";

            txtVolumen.Clear();
            txtPrecioUnitario.Clear();
            txtTotal.Clear();
            txtObservacion.Clear();

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private class ComboBoxItem<T>
        {
            public string Text { get; set; }
            public T Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}