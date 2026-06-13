using System;
using System.IO;
using System.Windows.Forms;

namespace SistemaMovimientoTierra.Views
{
    public partial class FrmVistaFactura : Form
    {
        private string textoFactura;

        public FrmVistaFactura(string facturaGenerada)
        {
            InitializeComponent();
            textoFactura = facturaGenerada;
        }

        private void FrmVistaFactura_Load(object sender, EventArgs e)
        {
            txtFactura.Text = textoFactura;
        }

        private void btnExportarWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Title = "Guardar factura";
            guardar.Filter = "Documento de Word compatible (*.rtf)|*.rtf";
            guardar.FileName = "Factura.rtf";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                string contenidoRtf = CrearContenidoRtf(textoFactura);

                File.WriteAllText(guardar.FileName, contenidoRtf);

                MessageBox.Show("Factura exportada correctamente. Puede abrir el archivo en Word e imprimirlo.",
                                "Exportación exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private string CrearContenidoRtf(string texto)
        {
            string textoSeguro = texto.Replace(@"\", @"\\")
                                      .Replace("{", @"\{")
                                      .Replace("}", @"\}")
                                      .Replace("\r\n", @"\par ");

            string rtf = @"{\rtf1\ansi\deff0";
            rtf += @"{\fonttbl{\f0 Courier New;}}";
            rtf += @"\f0\fs22 ";
            rtf += textoSeguro;
            rtf += "}";

            return rtf;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}