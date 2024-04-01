using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pila_cola_lista
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            FrmPila frmPila = new FrmPila();

            this.Hide();
            frmPila.ShowDialog();
            this.Close();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            FrmCola frmCola = new FrmCola();

            this.Hide();
            frmCola.ShowDialog();
            this.Close();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            FrmLista frmLista = new FrmLista();

            this.Hide();
            frmLista.ShowDialog();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
