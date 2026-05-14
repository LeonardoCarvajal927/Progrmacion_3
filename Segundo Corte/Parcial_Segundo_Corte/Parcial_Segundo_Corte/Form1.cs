using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parcial_Segundo_Corte
{
    public partial class FormPricipal : Form
    {
        private string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "empleados.csv");

        public FormPricipal()
        {
            InitializeComponent();
            CargarDatosEnDataGridView();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, rellena al menos el ID y el Nombre.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lineaCSV = $"{txtID.Text}," +
                              $"{txtNombre.Text}," +
                              $"{txtApellido.Text}," +
                              $"{txtDocumento.Text}," +
                              $"{txtCargo.Text}," +
                              $"{cmbDepartamento.SelectedItem}," +
                              $"{txtSalario.Text}," +
                              $"{cmbEstado.SelectedItem}," +
                              $"{dtpFechaIngreso.Value.ToShortDateString()}";

            try
            {
                File.AppendAllText(rutaArchivo, lineaCSV + Environment.NewLine);
                MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosEnDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            cmbDepartamento.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            dtpFechaIngreso.Value = DateTime.Today;
        }

        private void CargarDatosEnDataGridView()
        {
            dgEmpleados.Rows.Clear();

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

                for (int i = 1; i < lineas.Length; i++)
                {
                    string[] datos = lineas[i].Split(',');

                    if (datos.Length >= 9)
                    {
                        dgEmpleados.Rows.Add(
                            datos, // ID
                            datos, // Nombre
                            datos, // Apellido
                            datos, // Documento
                            datos, // Cargo
                            datos, // Departamento
                            datos, // Salario
                            datos, // Estado
                            datos  // FechaIngreso
                        );
                    }
                }
            }
        }

        private void dgvEmplados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
