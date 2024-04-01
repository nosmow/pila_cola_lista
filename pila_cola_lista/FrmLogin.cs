namespace pila_cola_lista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                this.erpError.SetError(this.txtClave, "Solo se permiten números");
                e.Handled = true;
            }
            else
            {
                this.erpError.Clear();
                e.Handled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoSistema objAcs = new AccesoSistema();

                if (this.txtClave.Text.Trim() != "")
                {
                    if (objAcs.ValidarAcceso(Convert.ToInt32(txtClave.Text)))
                    {
                        FrmMenu frmMenu = new FrmMenu();

                        this.Hide();
                        frmMenu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese una contraseña");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}