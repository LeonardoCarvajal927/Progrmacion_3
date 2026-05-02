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
    public partial class FormInformes : Form
    {

        string archivoLibros = Path.Combine(Application.StartupPath, "libros.csv");
        string archivoPrestamos = Path.Combine(Application.StartupPath, "prestamos.csv");
        string archivoDevoluciones = Path.Combine(Application.StartupPath, "devoluciones.csv");

        public FormInformes()
        {

            InitializeComponent();
            CargarInformes();

        }

        private void lblTextoDisponibles_Click(object sender, EventArgs e)
        {



        }


        void CargarInformes()
        {
            dgvDisponibilidad.Rows.Clear();
            dgvVencidos.Rows.Clear();

            int totalDisponibles = 0;
            int totalActivos = 0;
            int totalVencidos = 0;

            if (File.Exists(archivoLibros))
            {
                var libros = File.ReadAllLines(archivoLibros);

                for (int i = 1; i < libros.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(libros[i]))
                        continue;

                    var camposLibro = libros[i].Split(';');

                    if (camposLibro.Length < 6)
                        continue;

                    string isbn = camposLibro[0];
                    string titulo = camposLibro[1];
                    string categoria = camposLibro[4];
                    int disponibles = int.Parse(camposLibro[5]);

                    int prestados = ContarPrestamosPorISBN(isbn);
                    int total = disponibles + prestados;

                    totalDisponibles += disponibles;

                    dgvDisponibilidad.Rows.Add(
                        isbn,
                        titulo,
                        total,
                        prestados,
                        disponibles,
                        categoria
                    );
                }
            }

            if (File.Exists(archivoPrestamos))
            {
                var prestamos = File.ReadAllLines(archivoPrestamos);

                for (int i = 1; i < prestamos.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(prestamos[i]))
                        continue;

                    var campos = prestamos[i].Split(';');

                    if (campos.Length < 6)
                        continue;

                    totalActivos++;

                    DateTime fechaEsperada = DateTime.ParseExact(campos[5], "dd/MM/yyyy", null);
                    int diasMora = (DateTime.Now - fechaEsperada).Days;

                    if (diasMora > 0)
                    {
                        totalVencidos++;

                        dgvVencidos.Rows.Add(
                            campos[0],
                            campos[3],
                            campos[4],
                            campos[1],
                            campos[5],
                            diasMora + " días"
                        );
                    }
                }
            }

            lblNumeroDisponibles.Text = totalDisponibles.ToString();
            lblNumeroActivos.Text = totalActivos.ToString();
            lblNumeroVencidos.Text = totalVencidos.ToString();

            lblEstadoInformes.Text = "✔ Datos actualizados";
            lblTotalTitulos.Text = dgvDisponibilidad.Rows.Count + " títulos";
            lblTotalVencidos.Text = totalVencidos + " vencidos";
        }

        int ContarPrestamosPorISBN(string isbn)
        {
            int contador = 0;

            if (!File.Exists(archivoPrestamos))
                return 0;

            var prestamos = File.ReadAllLines(archivoPrestamos);

            for (int i = 1; i < prestamos.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(prestamos[i]))
                    continue;

                var campos = prestamos[i].Split(';');

                if (campos.Length < 6)
                    continue;

                if (campos[2].Trim() == isbn.Trim())
                    contador++;
            }

            return contador;
        }

        void FiltrarInformes()
        {
            dgvDisponibilidad.Rows.Clear();
            dgvVencidos.Rows.Clear();

            string categoriaFiltro = cmbCategoria.Text.Trim();
            string estadoFiltro = cmbEstado.Text.Trim();

            if (!File.Exists(archivoLibros))
                return;

            var libros = File.ReadAllLines(archivoLibros);

            for (int i = 1; i < libros.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(libros[i]))
                    continue;

                var campos = libros[i].Split(';');

                if (campos.Length < 6)
                    continue;

                string isbn = campos[0].Trim();
                string titulo = campos[1].Trim();
                string categoria = campos[4].Trim();
                int disponibles = int.Parse(campos[5]);

                int prestados = ContarPrestamosPorISBN(isbn);
                int total = disponibles + prestados;

                // FILTRO POR CATEGORÍA
                if (categoriaFiltro != "— Todas —" && categoriaFiltro != "- Todas -" && categoriaFiltro != "Todas")
                {
                    if (categoria != categoriaFiltro)
                        continue;
                }

                // FILTRO POR ESTADO
                if (estadoFiltro == "Disponibles")
                {
                    if (disponibles <= 0)
                        continue;
                }
                else if (estadoFiltro == "Prestados")
                {
                    if (prestados <= 0)
                        continue;
                }
                else if (estadoFiltro == "Vencidos")
                {
                    if (!LibroTienePrestamoVencido(isbn))
                        continue;
                }

                dgvDisponibilidad.Rows.Add(
                    isbn,
                    titulo,
                    total,
                    prestados,
                    disponibles,
                    categoria
                );
            }

            CargarVencidosFiltrados(categoriaFiltro);
        }

        bool LibroTienePrestamoVencido(string isbn)
        {
            if (!File.Exists(archivoPrestamos))
                return false;

            var prestamos = File.ReadAllLines(archivoPrestamos);

            for (int i = 1; i < prestamos.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(prestamos[i]))
                    continue;

                var campos = prestamos[i].Split(';');

                if (campos.Length < 6)
                    continue;

                if (campos[2].Trim() == isbn.Trim())
                {
                    DateTime fechaEsperada = DateTime.ParseExact(campos[5], "dd/MM/yyyy", null);
                    int diasMora = (DateTime.Now - fechaEsperada).Days;

                    if (diasMora > 0)
                        return true;
                }
            }

            return false;
        }

        void CargarVencidosFiltrados(string categoriaFiltro)
        {
            if (!File.Exists(archivoPrestamos))
                return;

            var prestamos = File.ReadAllLines(archivoPrestamos);

            for (int i = 1; i < prestamos.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(prestamos[i]))
                    continue;

                var campos = prestamos[i].Split(';');

                if (campos.Length < 6)
                    continue;

                string isbn = campos[2].Trim();

                if (categoriaFiltro != "— Todas —" && categoriaFiltro != "- Todas -" && categoriaFiltro != "Todas")
                {
                    string categoriaLibro = ObtenerCategoriaLibro(isbn);

                    if (categoriaLibro != categoriaFiltro)
                        continue;
                }

                DateTime fechaEsperada = DateTime.ParseExact(campos[5], "dd/MM/yyyy", null);
                int diasMora = (DateTime.Now - fechaEsperada).Days;

                if (diasMora > 0)
                {
                    dgvVencidos.Rows.Add(
                        campos[0],
                        campos[3],
                        campos[4],
                        campos[1],
                        campos[5],
                        diasMora + " días"
                    );
                }
            }
        }

        string ObtenerCategoriaLibro(string isbn)
        {
            if (!File.Exists(archivoLibros))
                return "";

            var libros = File.ReadAllLines(archivoLibros);

            for (int i = 1; i < libros.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(libros[i]))
                    continue;

                var campos = libros[i].Split(';');

                if (campos.Length < 6)
                    continue;

                if (campos[0].Trim() == isbn.Trim())
                    return campos[4].Trim();
            }

            return "";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            FiltrarInformes();

        }

        private void lblNumeroActivos_Click(object sender, EventArgs e)
        {

        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {

            cmbCategoria.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;

            CargarInformes();

        }
    }
}
