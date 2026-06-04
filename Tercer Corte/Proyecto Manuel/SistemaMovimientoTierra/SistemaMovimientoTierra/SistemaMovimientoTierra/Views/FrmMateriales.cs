using SistemaMovimientoTierra.Controllers;
using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmMateriales : Form
    {
        private MaterialController materialController = new MaterialController();

        public FrmMateriales()
        {
            InitializeComponent();
        }

        private void FrmMateriales_Load(object sender, EventArgs e)
        {
            HabilitarCampos();
            CargarCombos();
            GenerarIdMaterial();
            CargarMateriales();
        }

        private void HabilitarCampos()
        {
            // Habilitar los grupos principales
            gbDatosMaterial.Enabled = true;
            gbListaMateriales.Enabled = true;

            // Campo ID: solo lectura porque lo genera el sistema
            txtIdMaterial.Enabled = true;
            txtIdMaterial.ReadOnly = true;
            txtIdMaterial.TabStop = false;

            // Campos editables
            txtNombreMaterial.Enabled = true;
            txtNombreMaterial.ReadOnly = false;
            txtNombreMaterial.TabStop = true;

            txtPrecioUnitario.Enabled = true;
            txtPrecioUnitario.ReadOnly = false;
            txtPrecioUnitario.TabStop = true;

            txtDescripcion.Enabled = true;
            txtDescripcion.ReadOnly = false;
            txtDescripcion.TabStop = true;

            txtBuscar.Enabled = true;
            txtBuscar.ReadOnly = false;
            txtBuscar.TabStop = true;

            // Combos
            cmbTipoMaterial.Enabled = true;
            cmbTipoMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMaterial.TabStop = true;

            cmbUnidadMedida.Enabled = true;
            cmbUnidadMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidadMedida.TabStop = true;

            cmbEstado.Enabled = true;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.TabStop = true;

            // Traer los campos al frente por si hay algún panel o label encima
            txtIdMaterial.BringToFront();
            txtNombreMaterial.BringToFront();
            cmbTipoMaterial.BringToFront();
            cmbUnidadMedida.BringToFront();
            txtPrecioUnitario.BringToFront();
            cmbEstado.BringToFront();
            txtDescripcion.BringToFront();
            txtBuscar.BringToFront();
        }

        private void CargarCombos()
        {
            cmbTipoMaterial.Items.Clear();
            cmbTipoMaterial.Items.Add("Agregado");
            cmbTipoMaterial.Items.Add("Tierra");
            cmbTipoMaterial.Items.Add("Escombro");
            cmbTipoMaterial.Items.Add("Relleno");
            cmbTipoMaterial.Items.Add("Transporte");
            cmbTipoMaterial.Items.Add("Otro");
            cmbTipoMaterial.SelectedIndex = 0;

            cmbUnidadMedida.Items.Clear();
            cmbUnidadMedida.Items.Add("m³");
            cmbUnidadMedida.Items.Add("Tonelada");
            cmbUnidadMedida.Items.Add("Viaje");
            cmbUnidadMedida.Items.Add("Unidad");
            cmbUnidadMedida.Items.Add("Kg");
            cmbUnidadMedida.SelectedIndex = 0;

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbEstado.SelectedIndex = 0;
        }

        private void GenerarIdMaterial()
        {
            txtIdMaterial.Text = materialController.GenerarNuevoId().ToString();
        }

        private void CargarMateriales()
        {
            List<Material> materiales = materialController.ObtenerMateriales();

            dgvMateriales.DataSource = null;
            dgvMateriales.DataSource = materiales;

            ConfigurarTablaMateriales();

            dgvMateriales.ClearSelection();
        }

        private void ConfigurarTablaMateriales()
        {
            dgvMateriales.RowHeadersVisible = false;
            dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriales.MultiSelect = false;
            dgvMateriales.ReadOnly = true;
            dgvMateriales.AllowUserToAddRows = false;
            dgvMateriales.AllowUserToDeleteRows = false;

            if (dgvMateriales.Columns["IdMaterial"] != null)
            {
                dgvMateriales.Columns["IdMaterial"].HeaderText = "ID";
                dgvMateriales.Columns["IdMaterial"].FillWeight = 50;
            }

            if (dgvMateriales.Columns["Nombre"] != null)
            {
                dgvMateriales.Columns["Nombre"].HeaderText = "Nombre";
                dgvMateriales.Columns["Nombre"].FillWeight = 100;
            }

            if (dgvMateriales.Columns["TipoMaterial"] != null)
            {
                dgvMateriales.Columns["TipoMaterial"].HeaderText = "Tipo";
                dgvMateriales.Columns["TipoMaterial"].FillWeight = 90;
            }

            if (dgvMateriales.Columns["UnidadMedida"] != null)
            {
                dgvMateriales.Columns["UnidadMedida"].HeaderText = "Unidad";
                dgvMateriales.Columns["UnidadMedida"].FillWeight = 80;
            }

            if (dgvMateriales.Columns["PrecioUnitario"] != null)
            {
                dgvMateriales.Columns["PrecioUnitario"].HeaderText = "Precio";
                dgvMateriales.Columns["PrecioUnitario"].FillWeight = 80;
                dgvMateriales.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N0";
            }

            if (dgvMateriales.Columns["Estado"] != null)
            {
                dgvMateriales.Columns["Estado"].HeaderText = "Estado";
                dgvMateriales.Columns["Estado"].FillWeight = 80;
            }

            if (dgvMateriales.Columns["Descripcion"] != null)
            {
                dgvMateriales.Columns["Descripcion"].HeaderText = "Descripción";
                dgvMateriales.Columns["Descripcion"].FillWeight = 140;
            }
        }

        private void btnGuardarMaterial_Click(object sender, EventArgs e)
        {
            if (txtNombreMaterial.Text.Trim() == "" ||
                cmbTipoMaterial.Text == "" ||
                cmbUnidadMedida.Text == "" ||
                txtPrecioUnitario.Text.Trim() == "" ||
                cmbEstado.Text == "")
            {
                MessageBox.Show("Los campos principales son obligatorios.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            decimal precio;

            if (!decimal.TryParse(txtPrecioUnitario.Text.Trim(), out precio))
            {
                MessageBox.Show("El precio unitario debe ser un número válido.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio unitario debe ser mayor que cero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            Material material = new Material
            {
                IdMaterial = Convert.ToInt32(txtIdMaterial.Text),
                Nombre = txtNombreMaterial.Text.Trim(),
                TipoMaterial = cmbTipoMaterial.Text,
                UnidadMedida = cmbUnidadMedida.Text,
                PrecioUnitario = precio,
                Estado = cmbEstado.Text,
                Descripcion = txtDescripcion.Text.Trim()
            };

            bool registrado = materialController.RegistrarMaterial(material);

            if (registrado)
            {
                MessageBox.Show("Material registrado correctamente.",
                                "Registro exitoso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LimpiarCampos();
                GenerarIdMaterial();
                CargarMateriales();
            }
            else
            {
                MessageBox.Show("Ya existe un material con ese nombre.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            dgvMateriales.DataSource = null;
            dgvMateriales.DataSource = materialController.BuscarMateriales(texto);

            ConfigurarTablaMateriales();

            dgvMateriales.ClearSelection();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarMateriales();
        }

        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un material primero.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int idMaterial = Convert.ToInt32(dgvMateriales.CurrentRow.Cells["IdMaterial"].Value);
            string nombre = dgvMateriales.CurrentRow.Cells["Nombre"].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de eliminar el material {nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            bool eliminado = materialController.EliminarMaterial(idMaterial);

            if (eliminado)
            {
                MessageBox.Show("Material eliminado correctamente.",
                                "Eliminación exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                CargarMateriales();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el material.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            GenerarIdMaterial();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombreMaterial.Clear();
            txtPrecioUnitario.Clear();
            txtDescripcion.Clear();

            if (cmbTipoMaterial.Items.Count > 0)
            {
                cmbTipoMaterial.SelectedIndex = 0;
            }

            if (cmbUnidadMedida.Items.Count > 0)
            {
                cmbUnidadMedida.SelectedIndex = 0;
            }

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0;
            }
        }
    }
}