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
    public partial class FrmLista : Form
    {
        private List<ListaEstudiante> lstEstudiante = new List<ListaEstudiante>();
        private string eleccion = "";

        public FrmLista()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------
        private void cmbTipoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void cmbEstrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            eleccion = "Si";
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            eleccion = "No";
        }

        //------------------------------------------------------------------------

        //Actualiza los datos del DataGrid
        private void ActualizarDataGridView()
        {
            try
            {
                dtgEstudiante.DataSource = null;
                dtgEstudiante.DataSource = lstEstudiante;

                //Le coloca titulo a la tabla
                dtgEstudiante.Columns["TipoId"].HeaderText = "Tipo Id.";
                dtgEstudiante.Columns["IdEstudiante"].HeaderText = "Identificación";
                dtgEstudiante.Columns["FechaRegistro"].HeaderText = "Fecha registro";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Limpia los datos que estan en los controles
        private void LimpiarCampos()
        {
            cmbTipoID.Text = "";
            txtID.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            cmbEstrato.Text = "";
            dtpFecha.Value = DateTime.Now;
            rbSi.Checked = false;
            rbNo.Checked = false;
        }

        //Metodo para validar que no sep repita el número de las cedulas
        private bool ValidarIdentificación(int id)
        {
            bool validar = true;
            try
            {
                if (lstEstudiante.Count < 1)
                {
                    validar = true;
                }
                else
                {
                    foreach (var estudiante in lstEstudiante)
                    {
                        if (estudiante.IdEstudiante == id)
                        {
                            validar = false;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return validar;
        }

        //Metodo para registrar a los estudiantes
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoID.Text != "" && txtID.Text != "" && txtNombre.Text != "" && cmbEstrato.Text != "" &&
                txtEdad.Text != "")
                {
                    if (eleccion != "")
                    {
                        if (ValidarIdentificación(Convert.ToInt32(txtID.Text)) == true)
                        {
                            ListaEstudiante estudiante = new ListaEstudiante();

                            estudiante.TipoId = cmbTipoID.Text;
                            estudiante.IdEstudiante = Convert.ToInt32(txtID.Text);
                            estudiante.Nombre = txtNombre.Text;
                            estudiante.Edad = Convert.ToInt32(txtEdad.Text);
                            estudiante.Estrato = cmbEstrato.Text;
                            estudiante.FechaRegistro = dtpFecha.Value.Date;
                            estudiante.Voto = eleccion;

                            lstEstudiante.Add(estudiante);

                            ActualizarDataGridView();

                            MessageBox.Show("Estudiante registrado correctamente");
                            buscarToolStripMenuItem.Enabled = true;
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Esta identificación ya fue ingresada anteriormente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione si o no voto");
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

        //Metodo para buscar estudiantes registrados en el sistema
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool encontrado = false;
                if (txtID.Text != "")
                {
                    foreach (var estudiante in lstEstudiante)
                    {
                        if (estudiante.IdEstudiante == Convert.ToInt32(txtID.Text))
                        {
                            cmbTipoID.Text = estudiante.TipoId;
                            txtID.Text = estudiante.IdEstudiante.ToString();
                            txtNombre.Text = estudiante.Nombre;
                            txtEdad.Text = estudiante.Edad.ToString();
                            cmbEstrato.Text = estudiante.Estrato;
                            dtpFecha.Value = estudiante.FechaRegistro.Date;
                            if (estudiante.Voto == "Si")
                            {
                                rbSi.Checked = true;
                            }
                            else
                            {
                                rbNo.Checked = true;
                            }

                            encontrado = true;
                            MessageBox.Show("Estudiante encontrado");

                            if (MessageBox.Show("Presione Si para editar el estudiante, presione No para buscar otro estudiante", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                eliminarToolStripMenuItem.Enabled = true;
                            }
                            else
                            {
                                LimpiarCampos();
                            }
                        }
                    }
                    if (encontrado == false)
                    {
                        MessageBox.Show("Estudiante no encontrado");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un número de identificación");
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Metodo para eliminar usuarios que fueron buscados anteriormente
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoID.Text != "" && txtID.Text != "" && txtNombre.Text != "" && cmbEstrato.Text != "" &&
                    txtEdad.Text != "")
                {
                    foreach (var estudiante in lstEstudiante)
                    {
                        if (estudiante.IdEstudiante == Convert.ToInt32(txtID.Text))
                        {
                            if (MessageBox.Show("Presione Si para eliminar el estudiante, presione No para dejar el estudiante", "Mensaje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                ListaEstudiante lstE = estudiante;

                                lstEstudiante.Remove(lstE);
                                ActualizarDataGridView();
                                MessageBox.Show("Estudiante eliminado correctamente");
                            }
                            else
                            {
                                MessageBox.Show("Estudiante no eliminado");
                            }

                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Para eliminar un estudiante primero debe buscarlo");
                }

                eliminarToolStripMenuItem.Enabled = false;
                LimpiarCampos();
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
    }
}
