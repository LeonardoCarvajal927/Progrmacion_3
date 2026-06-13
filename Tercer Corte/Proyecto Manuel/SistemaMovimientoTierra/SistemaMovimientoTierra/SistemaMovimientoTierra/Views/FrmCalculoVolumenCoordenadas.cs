using SistemaMovimientoTierra.Controllers;
using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmCalculoVolumenCoordenadas : Form
    {
        private List<Coordenada> coordenadas = new List<Coordenada>();
        private Random random = new Random();

        private ClienteController clienteController = new ClienteController();
        private MaterialController materialController = new MaterialController();
        private CalculoTerrenoController calculoTerrenoController = new CalculoTerrenoController();

        private double ultimoVolumenCalculado = 0;
        private bool calculoRealizado = false;

        public FrmCalculoVolumenCoordenadas()
        {
            InitializeComponent();

            CargarMetodos();
            ConfigurarTablaCoordenadas();
            CargarClientes();
            CargarMateriales();
            ConfigurarDatosIniciales();

            cmbMaterial.SelectedIndexChanged += cmbMaterial_SelectedIndexChanged;
        }

        private void ConfigurarDatosIniciales()
        {
            txtCantidadPuntos.Text = "20";
            txtDx.Text = "1";
            txtDy.Text = "1";
            txtH.Text = "0";

            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();

            txtPrecioUnitario.ReadOnly = true;
            txtPrecioUnitario.Clear();

            lblVolumen.Text = "0.00 m³";
            lblMetodoResultado.Text = "Método utilizado: ---";

            ultimoVolumenCalculado = 0;
            calculoRealizado = false;

            // Para que visualmente aparezcan vacíos al abrir
            if (cmbMetodo.Items.Count > 0)
            {
                cmbMetodo.SelectedIndex = -1;
                cmbMetodo.Text = "";
            }

            if (cmbCliente.Items.Count > 0)
            {
                cmbCliente.SelectedIndex = -1;
                cmbCliente.Text = "";
            }

            if (cmbMaterial.Items.Count > 0)
            {
                cmbMaterial.SelectedIndex = -1;
                cmbMaterial.Text = "";
            }
        }

        private void CargarMetodos()
        {
            cmbMetodo.Items.Clear();

            cmbMetodo.Items.Add("Prismas");
            cmbMetodo.Items.Add("Trapecio 2D");
            cmbMetodo.Items.Add("Simpson 2D");

            cmbMetodo.SelectedIndex = 0;
        }

        private void CargarClientes()
        {
            cmbCliente.Items.Clear();

            List<Cliente> clientes = clienteController.ObtenerClientes();

            foreach (Cliente cliente in clientes)
            {
                string nombreCliente = cliente.Nombre + " " + cliente.Apellido;

                ComboBoxItem<Cliente> item = new ComboBoxItem<Cliente>();
                item.Text = nombreCliente;
                item.Value = cliente;

                cmbCliente.Items.Add(item);
            }

            if (cmbCliente.Items.Count > 0)
            {
                cmbCliente.SelectedIndex = 0;
            }
        }

        private void CargarMateriales()
        {
            cmbMaterial.Items.Clear();

            List<Material> materiales = materialController.ObtenerMateriales();

            foreach (Material material in materiales)
            {
                if (material.Estado == "Activo")
                {
                    ComboBoxItem<Material> item = new ComboBoxItem<Material>();
                    item.Text = material.Nombre;
                    item.Value = material;

                    cmbMaterial.Items.Add(item);
                }
            }

            if (cmbMaterial.Items.Count > 0)
            {
                cmbMaterial.SelectedIndex = 0;
            }
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarPrecioUnitario();
        }

        private void ActualizarPrecioUnitario()
        {
            if (cmbMaterial.SelectedItem == null)
            {
                txtPrecioUnitario.Clear();
                return;
            }

            ComboBoxItem<Material> itemMaterial = cmbMaterial.SelectedItem as ComboBoxItem<Material>;

            if (itemMaterial == null)
            {
                txtPrecioUnitario.Clear();
                return;
            }

            Material material = itemMaterial.Value;

            txtPrecioUnitario.Text = material.PrecioUnitario.ToString("N0");
        }

        private void ConfigurarTablaCoordenadas()
        {
            dgvCoordenadas.Columns.Clear();
            dgvCoordenadas.Rows.Clear();

            dgvCoordenadas.AllowUserToAddRows = false;
            dgvCoordenadas.AllowUserToDeleteRows = false;
            dgvCoordenadas.ReadOnly = true;
            dgvCoordenadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCoordenadas.MultiSelect = false;
            dgvCoordenadas.RowHeadersVisible = false;
            dgvCoordenadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCoordenadas.Columns.Add("Punto", "Punto");
            dgvCoordenadas.Columns.Add("X", "X");
            dgvCoordenadas.Columns.Add("Y", "Y");
            dgvCoordenadas.Columns.Add("Z", "Z");
        }

        private void btnAgregarPunto_Click(object sender, EventArgs e)
        {
            double x;
            double y;
            double z;

            if (!double.TryParse(txtX.Text.Trim(), out x) ||
                !double.TryParse(txtY.Text.Trim(), out y) ||
                !double.TryParse(txtZ.Text.Trim(), out z))
            {
                MessageBox.Show("X, Y y Z deben ser valores numéricos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int numeroPunto = coordenadas.Count + 1;

            Coordenada nuevaCoordenada = new Coordenada(numeroPunto, x, y, z);

            coordenadas.Add(nuevaCoordenada);

            MostrarCoordenadasEnTabla();

            calculoRealizado = false;
            ultimoVolumenCalculado = 0;
            lblVolumen.Text = "0.00 m³";
            lblMetodoResultado.Text = "Método utilizado: ---";

            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();

            txtX.Focus();
        }

        private void btnGenerarAleatorio_Click(object sender, EventArgs e)
        {
            int cantidadPuntos;

            if (!int.TryParse(txtCantidadPuntos.Text.Trim(), out cantidadPuntos))
            {
                MessageBox.Show("La cantidad de puntos debe ser un número entero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (cantidadPuntos < 4)
            {
                MessageBox.Show("Debe generar mínimo 4 puntos para formar un terreno.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            coordenadas.Clear();

            for (int i = 1; i <= cantidadPuntos; i++)
            {
                double x = random.Next(0, 21);
                double y = random.Next(0, 21);
                double z = random.Next(1, 16);

                Coordenada nuevaCoordenada = new Coordenada(i, x, y, z);

                coordenadas.Add(nuevaCoordenada);
            }

            MostrarCoordenadasEnTabla();

            calculoRealizado = false;
            ultimoVolumenCalculado = 0;
            lblVolumen.Text = "0.00 m³";
            lblMetodoResultado.Text = "Método utilizado: ---";

            MessageBox.Show("Coordenadas aleatorias generadas correctamente.",
                            "Datos generados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void MostrarCoordenadasEnTabla()
        {
            dgvCoordenadas.Rows.Clear();

            foreach (Coordenada c in coordenadas)
            {
                dgvCoordenadas.Rows.Add(
                    c.Punto,
                    c.X.ToString("N2"),
                    c.Y.ToString("N2"),
                    c.Z.ToString("N2")
                );
            }

            dgvCoordenadas.ClearSelection();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbMetodo.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un método de cálculo.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            double dx;
            double dy;
            double h;

            if (!double.TryParse(txtDx.Text.Trim(), out dx) ||
                !double.TryParse(txtDy.Text.Trim(), out dy) ||
                !double.TryParse(txtH.Text.Trim(), out h))
            {
                MessageBox.Show("dx, dy y h corte deben ser números válidos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (dx <= 0 || dy <= 0)
            {
                MessageBox.Show("dx y dy deben ser mayores que cero.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            double volumen = CalcularVolumenPorCoordenadas(dx, dy, h);

            ultimoVolumenCalculado = volumen;
            calculoRealizado = true;

            lblVolumen.Text = volumen.ToString("N2") + " m³";
            lblMetodoResultado.Text = "Método utilizado: " + cmbMetodo.Text;
        }

        private double CalcularVolumenPorCoordenadas(double dx, double dy, double h)
        {
            double volumen = 0;

            foreach (Coordenada c in coordenadas)
            {
                double alturaUtil = c.Z - h;

                if (alturaUtil > 0)
                {
                    volumen += alturaUtil * dx * dy;
                }
            }

            return volumen;
        }

        private void btnGuardarCalculo_Click(object sender, EventArgs e)
        {
            if (!calculoRealizado || ultimoVolumenCalculado <= 0)
            {
                MessageBox.Show("Primero debe calcular el volumen antes de guardar.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (cmbCliente.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (cmbMaterial.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un material.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (cmbMaterial.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un material.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            ComboBoxItem<Cliente> itemCliente = cmbCliente.SelectedItem as ComboBoxItem<Cliente>;
            ComboBoxItem<Material> itemMaterial = cmbMaterial.SelectedItem as ComboBoxItem<Material>;

            if (itemCliente == null || itemMaterial == null)
            {
                MessageBox.Show("No se pudo obtener el cliente o el material seleccionado.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            Cliente cliente = itemCliente.Value;
            Material material = itemMaterial.Value;

            decimal precioUnitario = Convert.ToDecimal(material.PrecioUnitario);
            decimal totalEstimado = Convert.ToDecimal(ultimoVolumenCalculado) * precioUnitario;

            CalculoTerreno calculo = new CalculoTerreno();

            calculo.IdCalculo = calculoTerrenoController.GenerarNuevoId();
            calculo.IdCliente = cliente.IdCliente;
            calculo.NombreCliente = cliente.Nombre + " " + cliente.Apellido;
            calculo.IdMaterial = material.IdMaterial;
            calculo.NombreMaterial = material.Nombre;
            calculo.Volumen = ultimoVolumenCalculado;
            calculo.PrecioUnitario = precioUnitario;
            calculo.TotalEstimado = totalEstimado;
            calculo.Metodo = cmbMetodo.Text;
            calculo.Fecha = DateTime.Now;

            calculoTerrenoController.GuardarCalculo(calculo);

            MessageBox.Show("Cálculo de terreno guardado correctamente." + Environment.NewLine +
                            "Cliente: " + calculo.NombreCliente + Environment.NewLine +
                            "Material: " + calculo.NombreMaterial + Environment.NewLine +
                            "Volumen: " + calculo.Volumen.ToString("N2") + " m³" + Environment.NewLine +
                            "Total estimado: $" + calculo.TotalEstimado.ToString("N0"),
                            "Guardado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnGrafica3D_Click(object sender, EventArgs e)
        {
            if (coordenadas.Count < 4)
            {
                MessageBox.Show("Debe ingresar o generar mínimo 4 coordenadas para graficar.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            FrmGraficaCoordenadas frm = new FrmGraficaCoordenadas(coordenadas);
            frm.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            coordenadas.Clear();
            dgvCoordenadas.Rows.Clear();

            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();

            txtCantidadPuntos.Text = "20";
            txtDx.Text = "1";
            txtDy.Text = "1";
            txtH.Text = "0";

            lblVolumen.Text = "0.00 m³";
            lblMetodoResultado.Text = "Método utilizado: ---";

            ultimoVolumenCalculado = 0;
            calculoRealizado = false;

            if (cmbMetodo.Items.Count > 0)
            {
                cmbMetodo.SelectedIndex = 0;
            }

            if (cmbCliente.Items.Count > 0)
            {
                cmbCliente.SelectedIndex = 0;
            }

            if (cmbMaterial.Items.Count > 0)
            {
                cmbMaterial.SelectedIndex = 0;
                ActualizarPrecioUnitario();
            }

            txtX.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalculoVolumenCoordenadas_Load(object sender, EventArgs e)
        {
        }

        private void lblTextoVolumen_Click(object sender, EventArgs e)
        {
        }

        private void lblPrecioUnitario_Click(object sender, EventArgs e)
        {
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