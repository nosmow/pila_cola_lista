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
    public partial class FrmCola : Form
    {
        private Queue<ColaJuventud> clJuventud = new Queue<ColaJuventud>();
            
        public FrmCola()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTotalRegistros.Clear();

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTotalRegistros.Clear();

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTotalRegistros.Clear();
        }

        private void cmbComuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTotalRegistros.Clear();
            e.Handled = true;
        }

        private void cmbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTotalRegistros.Clear();
            e.Handled = true;
        }

        private void dtpFechaActualizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTotalRegistros.Clear();
            e.Handled = true;
        }

        //-----------------------------------------------------------------------------

        //Limpia las casillas
        private void LimpiarCampos()
        {
            this.txtID.Clear();
            this.txtNombre.Clear();
            this.txtDireccion.Clear();
            this.cmbComuna.Text = "";
            this.cmbGenero.Text = "";
            this.dtpFechaActualizacion.Value = DateTime.Now;
            this.txtAuxilioEco.Clear();
            this.txtTotalRegistros.Clear();
        }

        //Actualiza los datos del DataGrid
        private void ActualizarDataGridView()
        {
            try
            {
                dtgJovenes.DataSource = null;
                dtgJovenes.DataSource = clJuventud.ToList();

                //Le coloca titulo a la tabla
                dtgJovenes.Columns["IdJoven"].HeaderText = "Identificación";
                dtgJovenes.Columns["Direccion"].HeaderText = "Dirección";
                dtgJovenes.Columns["FechaActDatos"].HeaderText = "Fecha act.. datos";
                dtgJovenes.Columns["AuxilioEconomico"].HeaderText = "Auxilio economico";
    }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Valida que el numero no haya sido ingresado antes
        private bool ValidarID(int numero)
        {
            bool valid = true;

            try
            {
                if (clJuventud.Count == 0)
                {
                    valid = true;
                }
                else
                {
                    foreach (ColaJuventud cola in clJuventud)
                    {
                        if (cola.IdJoven == numero)
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
                if (txtID.Text != "" && txtNombre.Text != "" && txtDireccion.Text != "" && txtDireccion.Text != "" && cmbComuna.Text != "" && cmbGenero.Text != "")
                {
                    if (ValidarID(Convert.ToInt32(txtID.Text)) == true)
                    {
                        this.txtTotalRegistros.Clear();

                        ColaJuventud objCola = new ColaJuventud();

                        objCola.IdJoven = Convert.ToInt32(txtID.Text);
                        objCola.Nombre = txtNombre.Text;
                        objCola.Direccion = txtDireccion.Text;
                        objCola.Comuna = cmbComuna.Text;
                        objCola.Genero = cmbGenero.Text;
                        objCola.FechaActDatos = dtpFechaActualizacion.Value.Date;
                        objCola.AuxilioEconomico = Convert.ToDecimal(txtAuxilioEco.Text);

                        clJuventud.Enqueue(objCola);
                  
                        ActualizarDataGridView();

                        LimpiarCampos();

                        //Si hay datos en la pila activa los botones eliminar y reporte
                        if (clJuventud.Count > 0)
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

        //Metodo parqa eliminar el joven
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (clJuventud.Count > 0)
                {
                    //Muestra los datos que se van a eliminar
                    ColaJuventud objJoven = clJuventud.Peek();

                    txtID.Text = objJoven.IdJoven.ToString();
                    txtNombre.Text = objJoven.Nombre;
                    txtDireccion.Text = objJoven.Direccion;
                    cmbComuna.Text = objJoven.Comuna;
                    cmbGenero.Text = objJoven.Genero;
                    dtpFechaActualizacion.Value = objJoven.FechaActDatos.Date;
                    txtAuxilioEco.Text = objJoven.AuxilioEconomico.ToString();

                    if (MessageBox.Show("Desea eliminar el registro del joven", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //Si no hay datos en la pila desactiva los botones eliminar y reporte
                        if (clJuventud.Count == 1)
                        {
                            this.eliminarToolStripMenuItem.Enabled = false;
                            this.reporteToolStripMenuItem.Enabled = false;
                        }

                        //Elimina los datos
                        clJuventud.Dequeue();
                        MessageBox.Show("Registro eliminado");
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No se elimino el registro");                  
                    }
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Metodo para mostrar el total de jovenes registrados
        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
                txtTotalRegistros.Text = clJuventud.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Metodo para regresar al menu
        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }

        //Metodo para calcular el auxilo economico de cada 3 meses
        private void cmbComuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColaJuventud cl = new ColaJuventud();

           txtAuxilioEco.Text = cl.CalcularAuxilioE(cmbComuna.Text).ToString();
        }
    }
}
