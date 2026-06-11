using SistemaMovimientoTierra.Logic;
using System;
using System.Windows.Forms;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmCalculoVolumen : Form
    {
        public FrmCalculoVolumen()
        {
            InitializeComponent();
        }

        private void FrmCalculoVolumen_Load(object sender, EventArgs e)
        {
            CargarMetodos();
            ConfigurarFormularioInicial();
        }

        private void CargarMetodos()
        {
            cmbMetodo.Items.Clear();

            // Métodos definidos para el cálculo de volumen.
            cmbMetodo.Items.Add("Simpson 2D");
            cmbMetodo.Items.Add("Trapecio 2D");
            cmbMetodo.Items.Add("Prismas");

            cmbMetodo.SelectedIndex = 0;
        }

        private void ConfigurarFormularioInicial()
        {
            // Dejamos los campos vacíos para que el usuario ingrese los datos manualmente.
            txtFilas.Clear();
            txtColumnas.Clear();
            txtDx.Clear();
            txtDy.Clear();
            txtH.Clear();

            lblVolumen.Text = "0.00 m³";
            lblMetodoResultado.Text = "Método utilizado: ---";

            btnGrafica3D.Enabled = true;

            dgvAlturas.RowHeadersVisible = false;
            dgvAlturas.AllowUserToAddRows = false;
            dgvAlturas.AllowUserToDeleteRows = false;
            dgvAlturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlturas.BackgroundColor = System.Drawing.Color.White;
        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            int filas;
            int columnas;

            if (!int.TryParse(txtFilas.Text.Trim(), out filas) ||
                !int.TryParse(txtColumnas.Text.Trim(), out columnas))
            {
                MessageBox.Show("Filas y columnas deben ser números enteros.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (filas < 2 || columnas < 2)
            {
                MessageBox.Show("La matriz debe tener mínimo 2 filas y 2 columnas.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (cmbMetodo.Text == "Simpson 2D" && (filas < 3 || columnas < 3))
            {
                MessageBox.Show("Simpson 2D requiere mínimo una matriz de 3x3.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            GenerarMatriz(filas, columnas);
        }

        private void GenerarMatriz(int filas, int columnas)
        {
            dgvAlturas.Columns.Clear();
            dgvAlturas.Rows.Clear();

            /*
             La matriz representa las alturas del terreno.

             filas:
             Cantidad de puntos en el eje Y.

             columnas:
             Cantidad de puntos en el eje X.

             Cada celda del DataGridView representa una altura z(x,y).
            */

            for (int j = 0; j < columnas; j++)
            {
                dgvAlturas.Columns.Add("columna" + j, "X" + (j + 1));
            }

            dgvAlturas.Rows.Add(filas);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    dgvAlturas.Rows[i].Cells[j].Value = "0";
                }
            }

            dgvAlturas.ClearSelection();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (dgvAlturas.Rows.Count == 0 || dgvAlturas.Columns.Count == 0)
            {
                MessageBox.Show("Primero debe generar la matriz de alturas.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            double dx;
            double dy;
            double h;

            /*
             VARIABLES DEL CÁLCULO:

             dx:
             Distancia entre cada punto de la matriz en el eje X.

             dy:
             Distancia entre cada punto de la matriz en el eje Y.

             h:
             Altura del plano de corte o nivel de referencia.

             alturas:
             Matriz numérica que contiene las alturas del terreno.

             metodoSeleccionado:
             Método matemático usado para aproximar el volumen:
             Simpson 2D, Trapecio 2D o Prismas.
            */

            if (!double.TryParse(txtDx.Text.Trim(), out dx) ||
                !double.TryParse(txtDy.Text.Trim(), out dy) ||
                !double.TryParse(txtH.Text.Trim(), out h))
            {
                MessageBox.Show("dx, dy y h deben ser números válidos.",
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

            double[,] alturas;

            try
            {
                alturas = ObtenerMatrizAlturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error en matriz",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MetodoCalculo metodoSeleccionado = ObtenerMetodoSeleccionado();

            try
            {
                double volumen = CalculoVolumen.Calcular(alturas, h, dx, dy, metodoSeleccionado);

                lblVolumen.Text = volumen.ToString("N2") + " m³";
                lblMetodoResultado.Text = "Método utilizado: " + cmbMetodo.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error al calcular",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private double[,] ObtenerMatrizAlturas()
        {
            int filas = dgvAlturas.Rows.Count;
            int columnas = dgvAlturas.Columns.Count;

            double[,] alturas = new double[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    object valorCelda = dgvAlturas.Rows[i].Cells[j].Value;

                    if (valorCelda == null || valorCelda.ToString().Trim() == "")
                    {
                        throw new Exception("Hay campos vacíos en la matriz de alturas.");
                    }

                    double altura;

                    if (!double.TryParse(valorCelda.ToString(), out altura))
                    {
                        throw new Exception("Todas las alturas deben ser números válidos.");
                    }

                    alturas[i, j] = altura;
                }
            }

            return alturas;
        }

        private MetodoCalculo ObtenerMetodoSeleccionado()
        {
            if (cmbMetodo.Text == "Simpson 2D")
            {
                return MetodoCalculo.Simpson2D;
            }

            if (cmbMetodo.Text == "Trapecio 2D")
            {
                return MetodoCalculo.Trapecio2D;
            }

            return MetodoCalculo.Prismas;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFilas.Clear();
            txtColumnas.Clear();
            txtDx.Clear();
            txtDy.Clear();
            txtH.Clear();

            dgvAlturas.Columns.Clear();
            dgvAlturas.Rows.Clear();

            lblVolumen.Text = "0.00 m³";
            lblMetodoResultado.Text = "Método utilizado: ---";

            if (cmbMetodo.Items.Count > 0)
            {
                cmbMetodo.SelectedIndex = 0;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrafica3D_Click(object sender, EventArgs e)
        {
            if (dgvAlturas.Rows.Count == 0 || dgvAlturas.Columns.Count == 0)
            {
                MessageBox.Show("Primero debe generar la matriz de alturas.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            double[,] alturas;

            try
            {
                alturas = ObtenerMatrizAlturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error en matriz",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            FrmGraficaTerreno frm = new FrmGraficaTerreno(alturas);
            frm.ShowDialog();
        }

        // Estos eventos quedaron conectados accidentalmente desde el diseñador.
        // Se dejan vacíos para que el proyecto compile sin errores.

        private void txtColumnas_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}