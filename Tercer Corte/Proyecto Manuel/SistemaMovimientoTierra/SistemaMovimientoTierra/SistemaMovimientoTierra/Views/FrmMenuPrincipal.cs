using SistemaMovimientoTierra.Models;
using SistemaMovimientoTierra.Views;
using System;
using System.Windows.Forms;
using SistemaMovimientoTierra.Controllers;
using System.Collections.Generic;

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
            CargarContadoresResumen();

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
            FrmRegistroCliente frm = new FrmRegistroCliente();
            frm.ShowDialog();

            CargarContadoresResumen();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            FrmMateriales frm = new FrmMateriales();
            frm.ShowDialog();

            CargarContadoresResumen();
        }

        private void btnCalculoVolumen_Click(object sender, EventArgs e)
        {
            FrmCalculoVolumenCoordenadas frm = new FrmCalculoVolumenCoordenadas();
            frm.ShowDialog();
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            FrmCotizaciones frm = new FrmCotizaciones();
            frm.ShowDialog();

            CargarContadoresResumen();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            FrmFacturas frm = new FrmFacturas();
            frm.ShowDialog();
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

        private void CargarContadoresResumen()
        {
            try
            {
                ClienteController clienteController = new ClienteController();
                MaterialController materialController = new MaterialController();
                CotizacionController cotizacionController = new CotizacionController();

                int totalClientes = clienteController.ObtenerClientes().Count;

                int totalMaterialesActivos = 0;
                List<Material> materiales = materialController.ObtenerMateriales();

                foreach (Material material in materiales)
                {
                    if (material.Estado == "Activo")
                    {
                        totalMaterialesActivos++;
                    }
                }

                int totalCotizaciones = cotizacionController.ObtenerCotizaciones().Count;

                lblTotalClientes.Text = totalClientes.ToString();
                lblTotalMateriales.Text = totalMaterialesActivos.ToString();
                lblTotalCotizaciones.Text = totalCotizaciones.ToString();
            }
            catch (Exception)
            {
                lblTotalClientes.Text = "0";
                lblTotalMateriales.Text = "0";
                lblTotalCotizaciones.Text = "0";
            }
        }
    }
}