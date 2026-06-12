using SistemaMovimientoTierra.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmCalculoVolumenCoordenadas : Form
    {
        private List<Coordenada> coordenadas = new List<Coordenada>();
        private Random random = new Random();

        public FrmCalculoVolumenCoordenadas()
        {
            InitializeComponent();

            CargarMetodos();
            ConfigurarTablaCoordenadas();
            ConfigurarDatosIniciales();
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

            lblVolumen.Text = "0.00 m³";
            lblMetodoResultado.Text = "Método utilizado: ---";

            if (cmbMetodo.Items.Count > 0)
            {
                cmbMetodo.SelectedIndex = 0;
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
            if (coordenadas.Count < 4)
            {
                MessageBox.Show("Debe ingresar o generar mínimo 4 coordenadas.",
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

            lblVolumen.Text = volumen.ToString("N2") + " m³";
            lblMetodoResultado.Text = "Método utilizado: " + cmbMetodo.Text;
        }

        private double CalcularVolumenPorCoordenadas(double dx, double dy, double h)
        {
            /*
             Cálculo de volumen mediante coordenadas X, Y, Z.

             
            */

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

            if (cmbMetodo.Items.Count > 0)
            {
                cmbMetodo.SelectedIndex = 0;
            }

            txtX.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         Estos eventos quedan vacíos por si el diseñador los tiene conectados.
         No los borres si Visual Studio los está pidiendo.
        */

        private void FrmCalculoVolumenCoordenadas_Load(object sender, EventArgs e)
        {
        }

        private void lblTextoVolumen_Click(object sender, EventArgs e)
        {
        }
    }
}