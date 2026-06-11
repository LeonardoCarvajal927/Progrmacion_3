using System;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}