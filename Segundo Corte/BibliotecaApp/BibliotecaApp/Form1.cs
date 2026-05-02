using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void panelCentro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FormLibros frm = new FormLibros();
            frm.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FormPrestamos frm = new FormPrestamos();
            frm.Show();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            FormDevoluciones frm = new FormDevoluciones();
            frm.Show();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            FormInformes frm = new FormInformes();
            frm.Show();
        }
    }
    
}
