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

namespace BibliotecaApp
{
    public partial class FormLibros : Form
    {

        private string archivoLibros = Path.Combine(Application.StartupPath, "libros.csv");
        

        public FormLibros()
        {
            InitializeComponent();
            //MessageBox.Show(archivoLibros);
            CargarLibros();



        }

        

        private void lblEditorial_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtituloLibros_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text == "" || txtTituloLibro.Text == "" || txtAutor.Text == "" ||
                txtEditorial.Text == "" || cmbCategoria.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            string isbn = txtISBN.Text;
            string titulo = txtTituloLibro.Text;
            string autor = txtAutor.Text;
            string editorial = txtEditorial.Text;
            string categoria = cmbCategoria.Text;
            int cantidad = (int)numCantidad.Value;

            string linea = isbn + ";" + titulo + ";" + autor + ";" + editorial + ";" + categoria + ";" + cantidad;

            File.AppendAllText(archivoLibros, linea + Environment.NewLine);


            MessageBox.Show("Guardado en:\n" + archivoLibros);

            LimpiarCampos();
            CargarLibros();
        }

        private void LimpiarCampos()
        {
            txtISBN.Clear();
            txtTituloLibro.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            cmbCategoria.SelectedIndex = -1;
            numCantidad.Value = 1;
        }

        private void CargarLibros()
        {
            dgvLibros.Rows.Clear();

            if (!File.Exists(archivoLibros))
            {
                return;
            }

            string[] lineas = File.ReadAllLines(archivoLibros);

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                if (linea.StartsWith("ISBN;"))
                    continue;

                string[] campos = linea.Split(';');

                string isbn = campos[0];
                string titulo = campos[1];
                string autor = campos[2];
                int cantidad = int.Parse(campos[5]);

                int disponibles = cantidad;

                dgvLibros.Rows.Add(isbn, titulo, autor, cantidad, disponibles);
            }

            lblTotalLibros.Text = (dgvLibros.Rows.Count) + " libros registrados";
        }

        private void btnLimpiarLibro_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tblPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLibros_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void btnActualizarLibro_Click(object sender, EventArgs e)
        {

            CargarLibros();
            MessageBox.Show("Catálogo actualizado.");

        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {

            if (dgvLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un libro para eliminar.");
                return;
            }

            string isbnEliminar = dgvLibros.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que desea eliminar este libro?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.No)
                return;

            var lineas = File.ReadAllLines(archivoLibros).ToList();

            lineas.RemoveAll(linea =>
            {
                if (linea.StartsWith("ISBN;"))
                    return false;

                var campos = linea.Split(';');

                if (campos.Length < 6)
                    return false;

                return campos[0].Trim() == isbnEliminar.Trim();
            });

            File.WriteAllLines(archivoLibros, lineas);

            MessageBox.Show("Libro eliminado correctamente.");

            CargarLibros();

        }
    }
}
