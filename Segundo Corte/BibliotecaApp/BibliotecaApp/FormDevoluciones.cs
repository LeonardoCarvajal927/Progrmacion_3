using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class FormDevoluciones : Form
    {
        public FormDevoluciones()
        {
            InitializeComponent();
            CargarDevoluciones();
        }

        private void lblSinMora_Click(object sender, EventArgs e)
        {

        }

        void CargarDevoluciones()
        {
            dgvDevoluciones.Rows.Clear();

            string archivoDevoluciones = Path.Combine(Application.StartupPath, "devoluciones.csv");

            if (!File.Exists(archivoDevoluciones))
                return;

            var lineas = File.ReadAllLines(archivoDevoluciones);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                    continue;

                var campos = lineas[i].Split(';');

                if (campos.Length < 5)
                    continue;

                dgvDevoluciones.Rows.Add(
                    campos[0], 
                    campos[1], 
                    campos[2], 
                    campos[3], 
                    campos[4]  
                );
            }
        }

        private void btnConfirmarDevolucion_Click(object sender, EventArgs e)
        {
            string archivoPrestamos = Path.Combine(Application.StartupPath, "prestamos.csv");
            string archivoDevoluciones = Path.Combine(Application.StartupPath, "devoluciones.csv");
            string archivoLibros = Path.Combine(Application.StartupPath, "libros.csv");

            
            if (txtIdPrestamo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese ID del préstamo");
                return;
            }

            string id = txtIdPrestamo.Text.Trim();

            var prestamos = File.ReadAllLines(archivoPrestamos).ToList();

            string lineaEncontrada = prestamos.FirstOrDefault(l => l.StartsWith(id + ";"));

            if (lineaEncontrada == null)
            {
                MessageBox.Show("Préstamo no encontrado");
                return;
            }

            var datos = lineaEncontrada.Split(';');

            string titulo = datos[3];
            string estudiante = datos[4];
            string fechaEsperada = datos[5];

            DateTime fechaDev = DateTime.Now;
            DateTime fechaEsp = DateTime.ParseExact(fechaEsperada, "dd/MM/yyyy", null);

            string mora = fechaDev > fechaEsp ? "SI" : "NO";

            
            string lineaDev = id + ";" + titulo + ";" + estudiante + ";" + fechaDev.ToString("dd/MM/yyyy") + ";" + mora;
            File.AppendAllText(archivoDevoluciones, lineaDev + Environment.NewLine);

            
            prestamos.Remove(lineaEncontrada);
            File.WriteAllLines(archivoPrestamos, prestamos);

            
            var libros = File.ReadAllLines(archivoLibros).ToList();

            for (int i = 1; i < libros.Count; i++)
            {
                var campos = libros[i].Split(';');

                if (campos[1] == titulo)
                {
                    int cantidad = int.Parse(campos[5]);
                    cantidad++;
                    campos[5] = cantidad.ToString();

                    libros[i] = string.Join(";", campos);
                    break;
                }
            }

            File.WriteAllLines(archivoLibros, libros);

            MessageBox.Show("Devolución registrada correctamente");

            CargarDevoluciones();

        }

        private void btnActualizarDevoluciones_Click(object sender, EventArgs e)
        {

            CargarDevoluciones();
            MessageBox.Show("Historial actualizado.");

        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            string archivoPrestamos = Path.Combine(Application.StartupPath, "prestamos.csv");

            if (txtIdPrestamo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el ID del préstamo.");
                return;
            }

            string idBuscado = txtIdPrestamo.Text.Trim();

            if (!File.Exists(archivoPrestamos))
            {
                MessageBox.Show("No existe el archivo de préstamos.");
                return;
            }

            var lineas = File.ReadAllLines(archivoPrestamos);

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                if (linea.StartsWith("ID;"))
                    continue;

                var campos = linea.Split(';');

                if (campos.Length < 6)
                    continue;

                if (campos[0].Trim() == idBuscado)
                {
                    string titulo = campos[3];
                    string estudiante = campos[4];
                    string fechaEsperada = campos[5];

                    lblInfoPrestamo.Text = "Préstamo: #" + campos[0];
                    lblInfoLibro.Text = "Libro: " + titulo;
                    lblInfoEstudiante.Text = "Estudiante: " + estudiante;
                    lblInfoFechaEsperada.Text = "F. Esperada: " + fechaEsperada;

                    DateTime fechaEsp = DateTime.ParseExact(fechaEsperada, "dd/MM/yyyy", null);
                    DateTime fechaDev = dtpFechaDevolucion.Value;

                    if (fechaDev > fechaEsp)
                    {
                        lblSinMora.Visible = false;
                        lblConMora.Visible = true;
                        lblConMora.Text = "⚠ Devuelto con mora";
                    }
                    else
                    {
                        lblSinMora.Visible = true;
                        lblConMora.Visible = false;
                        lblSinMora.Text = "✅ Devuelto a tiempo — Sin mora";
                    }

                    return;
                }
            }

            MessageBox.Show("Préstamo no encontrado.");
        }

        private void gbRegistrarDevolucion_Enter(object sender, EventArgs e)
        {

        }
    }
}
