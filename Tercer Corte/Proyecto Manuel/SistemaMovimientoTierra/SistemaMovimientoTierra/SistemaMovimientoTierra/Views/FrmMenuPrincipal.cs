using SistemaMovimientoTierra.Models;
using System;
using System.Windows.Forms;

namespace SistemaMovimientoTierra
{
    public partial class FrmMenuPrincipal : Form
    {
        private Usuario usuarioActual;

        public FrmMenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = usuarioActual.NombreUsuario;
            lblRolUsuario.Text = usuarioActual.Rol;

            if (usuarioActual.Rol == "Administrador")
            {
                btnGestionUsuarios.Visible = true;
                picGestionUsuarios.Visible = true;
            }
            else
            
            {
                btnGestionUsuarios.Visible = false;
                picGestionUsuarios.Visible = false;
            }

            CentrarElementosPanelDerecho();
        }

        private void CentrarElementosPanelDerecho()
        {
           
            pnlUsuarioActual.Left = (pnlContenido.Width - pnlUsuarioActual.Width) / 2;

            
            picBanner.Left = (pnlContenido.Width - picBanner.Width) / 2;

            
            int espacio = 20;
            int anchoTotal = pnlResumenClientes.Width +
                             pnlResumenMateriales.Width +
                             pnlResumenCotizaciones.Width +
                             
                             (espacio * 3);

            int inicioX = (pnlContenido.Width - anchoTotal) / 2;

            pnlResumenClientes.Left = inicioX;
            pnlResumenMateriales.Left = pnlResumenClientes.Right + espacio;
            pnlResumenCotizaciones.Left = pnlResumenMateriales.Right + espacio;
            
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios formGestionUsuarios = new FrmGestionUsuarios();
            formGestionUsuarios.ShowDialog();
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            FrmCambiarPassword formCambiarPassword = new FrmCambiarPassword(usuarioActual.NombreUsuario);
            formCambiarPassword.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SistemaMovimientoTierra.Views.FrmRegistroCliente form = new SistemaMovimientoTierra.Views.FrmRegistroCliente();
            form.ShowDialog();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            SistemaMovimientoTierra.Views.FrmMateriales form = new SistemaMovimientoTierra.Views.FrmMateriales();
            form.ShowDialog();
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
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}