using System;
using System.Windows.Forms;

namespace SistemaMovimientoTierra
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios formGestionUsuarios = new FrmGestionUsuarios();
            formGestionUsuarios.ShowDialog();
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            FrmCambiarPassword formCambiarPassword = new FrmCambiarPassword();
            formCambiarPassword.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de clientes pendiente por desarrollar.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de materiales pendiente por desarrollar.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnCalculoVolumen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de cálculo de volumen pendiente por desarrollar.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de cotizaciones pendiente por desarrollar.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de facturas pendiente por desarrollar.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Deseas salir del sistema?",
                                                     "Confirmar salida",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblTituloCentral_Click(object sender, EventArgs e)
        {
            // Evento vacío para evitar error del diseñador.
        }
    }
}