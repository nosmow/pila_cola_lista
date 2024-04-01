using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pila_cola_lista
{
    public partial class FrmPila : Form
    {
        private Stack<PilaCdt> pilaCdts = new Stack<PilaCdt>();

        public FrmPila()
        {
            InitializeComponent();
        }

        //Eventos KeyPress-----------------------------------------------------------------------------
        private void txtNumCDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                this.txtTodosPagos.Clear();
                e.Handled = false;
            }          
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                this.txtTodosPagos.Clear();
                e.Handled = false;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                this.txtTodosPagos.Clear();
                e.Handled = false;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtTodosPagos.Clear();
        }

        private void cmbEstrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            this.txtTodosPagos.Clear();
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            this.txtTodosPagos.Clear();
        }

        private void cmbAperturaCDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            this.txtTodosPagos.Clear();
        }

        private void txtMesesCDTBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtTodosPagos.Clear();

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                if (this.timer1.Enabled == false)
                {
                    this.timer1.Start();
                }
            }
        }
        //---------------------------------------------------------------------------------------------

        //Limpia las casillas
        private void LimpiarCampos()
        {
            this.txtNumCDT.Clear();
            this.txtID.Clear();
            this.txtNombre.Clear();
            this.txtDireccion.Clear();
            this.cmbEstrato.Text = "";
            this.cmbCategoria.Text = "";
            this.cmbAperturaCDT.Text = "";
            this.txtMesesCDTBanco.Clear();
            this.txtTotal.Clear();
            this.txtTodosPagos.Clear();
        }

        //Actualiza los datos del DataGrid
        private void ActualizarDataGridView()
        {
            try
            {
                dtgJovenes.DataSource = null;
                dtgJovenes.DataSource = pilaCdts.ToArray();

                //Le coloca titulo a la tabla
                dtgJovenes.Columns["NumCDT"].HeaderText = "Número CDT";
                dtgJovenes.Columns["IdCLiente"].HeaderText = "Identificación";
                dtgJovenes.Columns["Direccion"].HeaderText = "Dirección";
                dtgJovenes.Columns["Categoria"].HeaderText = "Categoría";
                dtgJovenes.Columns["MesAbiertoCDT"].HeaderText = "Mes abierto CDT";
                dtgJovenes.Columns["TiempoMesesCDT"].HeaderText = "Meses CDT";
                dtgJovenes.Columns["FechaPago"].HeaderText = "Fecha pagado";
                dtgJovenes.Columns["TotalPagarCDT"].HeaderText = "Total pagado CDT";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Metodo timer para que al ingresar los meses sin necesidad de presionar botones muestre cuando debe pagar
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.txtMesesCDTBanco.Text != "")
                {
                    PilaCdt cdt = new PilaCdt();
                    this.txtTotal.Text = cdt.CalcularValorPagarCDT(Convert.ToInt32(this.txtMesesCDTBanco.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                this.timer1.Stop();
                MessageBox.Show(ex.Message);
            }         
        }

        //Valida que el numero no haya sido ingresado antes
        private bool ValidarCDT(decimal numero)
        {
            bool valid = true;

            try
            {
                if (pilaCdts.Count == 0)
                {
                    valid = true;
                }
                else
                {
                    foreach (PilaCdt pila in pilaCdts)
                    {
                        if (pila.NumCDT == numero)
                        {
                            valid = false;
                            break;
                        }
                    }
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return valid;
        }

        //Evento para registrar los datos ingresados
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumCDT.Text != "" && txtID.Text != "" && txtNombre.Text != "" && txtDireccion.Text != "" &&
                    cmbEstrato.Text != "" && cmbCategoria.Text != "" && cmbAperturaCDT.Text != "" && txtMesesCDTBanco.Text != "")
                {
                    if (ValidarCDT(Convert.ToDecimal(txtNumCDT.Text)) == true)
                    {
                        this.txtTodosPagos.Clear();

                        PilaCdt objJoven = new PilaCdt();

                        objJoven.NumCDT = Convert.ToDecimal(txtNumCDT.Text);
                        objJoven.IdCLiente = Convert.ToInt32(txtID.Text);
                        objJoven.Nombre = txtNombre.Text;
                        objJoven.Direccion = txtDireccion.Text;
                        objJoven.Estrato = Convert.ToInt32(cmbEstrato.Text);
                        objJoven.Categoria = cmbCategoria.Text;
                        objJoven.MesAbiertoCDT = cmbAperturaCDT.Text;
                        objJoven.TiempoMesesCDT = Convert.ToInt32(txtMesesCDTBanco.Text);
                        objJoven.FechaPago = dtpFechaPago.Value.Date;
                        objJoven.TotalPagarCDT = Convert.ToDecimal(txtTotal.Text);

                        pilaCdts.Push(objJoven);

                        ActualizarDataGridView();

                        LimpiarCampos();

                        //Si hay datos en la pila activa los botones eliminar y reporte
                        if (pilaCdts.Count > 0)
                        {
                            this.eliminarToolStripMenuItem.Enabled = true;
                            this.reporteToolStripMenuItem.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El número de CDT fue registrado anteriormente");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese todos los datos");
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Metodo para eliminar los datos que estan en el inicio de la pila
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtTodosPagos.Clear();

                if (pilaCdts.Count > 0)
                {
                    //Muestra los datos que se van a eliminar
                    PilaCdt objEliminado = pilaCdts.Peek();
                    this.txtNumCDT.Text = objEliminado.NumCDT.ToString();
                    this.txtID.Text = objEliminado.IdCLiente.ToString();
                    this.txtNombre.Text = objEliminado.Nombre;
                    this.txtDireccion.Text = objEliminado.Direccion;
                    this.cmbEstrato.Text = objEliminado.Estrato.ToString();
                    this.cmbCategoria.Text = objEliminado.Categoria;
                    this.cmbAperturaCDT.Text = objEliminado.MesAbiertoCDT;
                    this.txtMesesCDTBanco.Text = objEliminado.TiempoMesesCDT.ToString();
                    this.txtTotal.Text = objEliminado.TotalPagarCDT.ToString();

                    if (MessageBox.Show("Desea eliminar el registro del joven", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Si no hay datos en la pila desactiva los botones eliminar y reporte
                        if (pilaCdts.Count == 1)
                        {
                            this.eliminarToolStripMenuItem.Enabled = false;
                            this.reporteToolStripMenuItem.Enabled = false;
                        }

                        //Elimina los datos
                        pilaCdts.Pop();
                        MessageBox.Show("Registro eliminado");
                        LimpiarCampos();
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se elimino el registro");
                        LimpiarCampos();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Metodo para mostrar la suma de todos los pagos
        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                decimal sumaTotal = 0;

                if (pilaCdts.Count > 0)
                {
                    foreach (var valor in pilaCdts)
                    {
                        sumaTotal += valor.TotalPagarCDT;
                    }

                    LimpiarCampos();
                    this.txtTodosPagos.Text = sumaTotal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }
    }
}
