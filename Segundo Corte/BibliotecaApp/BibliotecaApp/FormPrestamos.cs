using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class FormPrestamos : Form
    {
        string archivoLibros = Path.Combine(Application.StartupPath, "libros.csv");
        string archivoPrestamos = Path.Combine(Application.StartupPath, "prestamos.csv");

        public FormPrestamos()
        {
            InitializeComponent();
            CargarLibrosCombo();
            CargarPrestamos();
        }

        void CargarLibrosCombo()
        {
            cmbLibroPrestamo.Items.Clear();

            if (!File.Exists(archivoLibros))
                return;

            var lineas = File.ReadAllLines(archivoLibros);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                    continue;

                var campos = lineas[i].Split(';');

                if (campos.Length < 6)
                    continue;

                string isbn = campos[0].Trim();
                string titulo = campos[1].Trim();

                cmbLibroPrestamo.Items.Add(isbn + " | " + titulo);
            }
        }

        void CargarPrestamos()
        {
            dgvPrestamos.Rows.Clear();

            if (!File.Exists(archivoPrestamos))
                return;

            var lineas = File.ReadAllLines(archivoPrestamos);
            int vencidos = 0;

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                    continue;

                var campos = lineas[i].Split(';');

                if (campos.Length < 6)
                    continue;

                DateTime fechaEsperada = DateTime.Parse(campos[5]);
                int diasMora = (DateTime.Now - fechaEsperada).Days;

                if (diasMora > 0)
                    vencidos++;

                dgvPrestamos.Rows.Add(
                    campos[0],
                    campos[1],
                    campos[3],
                    campos[4],
                    campos[5]
                );
            }

            lblPrestamosActivos.Text = "Activos: " + dgvPrestamos.Rows.Count;
            lblPrestamosVencidos.Text = "Vencidos: " + vencidos;
            lblAlerta.Text = "⚠ " + vencidos + " préstamos vencidos";
        }

        private void cmbLibroPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibroPrestamo.SelectedIndex == -1)
                return;

            string seleccionado = cmbLibroPrestamo.SelectedItem.ToString();
            string isbnSeleccionado = seleccionado.Split('|')[0].Trim();

            var lineas = File.ReadAllLines(archivoLibros);

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                if (linea.StartsWith("ISBN"))
                    continue;

                var campos = linea.Split(';');

                if (campos.Length < 6)
                    continue;

                if (campos[0].Trim() == isbnSeleccionado)
                {
                    lblLibroSeleccionado.Text = "📖 " + campos[1].Trim();
                    lblDisponibles.Text = "✅ Disponibles: " + campos[5].Trim();
                    break;
                }
            }
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Entró al botón Registrar Préstamo");

            if (cmbLibroPrestamo.SelectedIndex == -1 || txtEstudiante.Text.Trim() == "")
            {
                MessageBox.Show("Complete los datos del préstamo.");
                return;
            }

            string seleccionado = cmbLibroPrestamo.SelectedItem.ToString();
            string[] partes = seleccionado.Split('|');

            string isbn = partes[0].Trim();
            string titulo = partes[1].Trim();

            string estudiante = txtEstudiante.Text.Trim();
            string fechaPrestamo = dtpFechaPrestamo.Value.ToString("dd/MM/yyyy");
            string fechaEsperada = dtpFechaDevolucion.Value.ToString("dd/MM/yyyy");

            string id = txtIdPrestamo.Text.Trim();

            if (id == "")
            {
                MessageBox.Show("Ingrese un ID de préstamo.");
                return;
            }

            if (File.Exists(archivoPrestamos))
            {
                var prestamosExistentes = File.ReadAllLines(archivoPrestamos);

                foreach (var prestamo in prestamosExistentes)
                {
                    if (prestamo.StartsWith(id + ";"))
                    {
                        MessageBox.Show("Ese ID de préstamo ya existe.");
                        return;
                    }
                }
            }

            var lineas = File.ReadAllLines(archivoLibros).ToList();

            bool libroEncontrado = false;

            for (int i = 1; i < lineas.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i]))
                    continue;

                var campos = lineas[i].Split(';');

                if (campos.Length < 6)
                    continue;

                if (campos[0].Trim() == isbn.Trim())
                {
                    libroEncontrado = true;

                    int cantidad = int.Parse(campos[5]);

                    if (cantidad <= 0)
                    {
                        MessageBox.Show("No hay ejemplares disponibles.");
                        return;
                    }

                    cantidad--;
                    campos[5] = cantidad.ToString();

                    lineas[i] = string.Join(";", campos);
                    break;
                }
            }

            if (!libroEncontrado)
            {
                MessageBox.Show("No se encontró el libro seleccionado.");
                return;
            }

            File.WriteAllLines(archivoLibros, lineas);

            string lineaPrestamo = id + ";" +
                                   fechaPrestamo + ";" +
                                   isbn + ";" +
                                   titulo + ";" +
                                   estudiante + ";" +
                                   fechaEsperada;

            File.AppendAllText(archivoPrestamos, lineaPrestamo + Environment.NewLine);

            MessageBox.Show("Préstamo registrado correctamente.");

            CargarLibrosCombo();
            CargarPrestamos();

            cmbLibroPrestamo.SelectedIndex = -1;
            txtEstudiante.Clear();
            txtIdPrestamo.Text = DateTime.Now.Ticks.ToString();
            lblLibroSeleccionado.Text = "📖 Libro seleccionado";
            lblDisponibles.Text = "✅ Disponibles: 0";
        }

        private void lblIdPrestamo_Click(object sender, EventArgs e)
        {

        }
    }
}