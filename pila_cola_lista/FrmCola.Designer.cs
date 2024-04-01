namespace pila_cola_lista
{
    partial class FrmCola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFechaActualizacion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbComuna = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTotalRegistros = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgJovenes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAuxilioEco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgJovenes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaActualizacion
            // 
            this.dtpFechaActualizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaActualizacion.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.dtpFechaActualizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaActualizacion.Location = new System.Drawing.Point(857, 124);
            this.dtpFechaActualizacion.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpFechaActualizacion.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaActualizacion.Name = "dtpFechaActualizacion";
            this.dtpFechaActualizacion.Size = new System.Drawing.Size(250, 34);
            this.dtpFechaActualizacion.TabIndex = 60;
            this.dtpFechaActualizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaActualizacion_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(592, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 28);
            this.label8.TabIndex = 59;
            this.label8.Text = "Fecha de actualización:";
            // 
            // cmbComuna
            // 
            this.cmbComuna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbComuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.cmbComuna.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbComuna.ForeColor = System.Drawing.Color.Black;
            this.cmbComuna.FormattingEnabled = true;
            this.cmbComuna.Items.AddRange(new object[] {
            "Comuna Noroccidental",
            "Comuna Nororiental",
            "Comuna Entre Ríos",
            "Comuna Central",
            "Comuna Oriental",
            "Comuna Sur",
            "Comuna La Floresta",
            "Comuna Suroriental",
            "Comuna Norte",
            "Comuna Las Palmas"});
            this.cmbComuna.Location = new System.Drawing.Point(284, 315);
            this.cmbComuna.Name = "cmbComuna";
            this.cmbComuna.Size = new System.Drawing.Size(250, 36);
            this.cmbComuna.TabIndex = 42;
            this.cmbComuna.SelectedIndexChanged += new System.EventHandler(this.cmbComuna_SelectedIndexChanged);
            this.cmbComuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbComuna_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(284, 255);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(250, 34);
            this.txtDireccion.TabIndex = 37;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(284, 190);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 34);
            this.txtNombre.TabIndex = 38;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cmbGenero
            // 
            this.cmbGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.cmbGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGenero.ForeColor = System.Drawing.Color.Black;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No Binario"});
            this.cmbGenero.Location = new System.Drawing.Point(284, 382);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(250, 36);
            this.cmbGenero.TabIndex = 44;
            this.cmbGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGenero_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(284, 124);
            this.txtID.MaxLength = 9;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 34);
            this.txtID.TabIndex = 40;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtTotalRegistros
            // 
            this.txtTotalRegistros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(202)))));
            this.txtTotalRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalRegistros.Enabled = false;
            this.txtTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalRegistros.ForeColor = System.Drawing.Color.Black;
            this.txtTotalRegistros.Location = new System.Drawing.Point(859, 388);
            this.txtTotalRegistros.Name = "txtTotalRegistros";
            this.txtTotalRegistros.Size = new System.Drawing.Size(250, 34);
            this.txtTotalRegistros.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(592, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 28);
            this.label9.TabIndex = 52;
            this.label9.Text = "Total de registros:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(129, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 50;
            this.label6.Text = "Comuna:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(129, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(129, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(306, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(676, 45);
            this.label2.TabIndex = 46;
            this.label2.Text = "Secretaria de la juventud alcaldía de Neiva";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(124, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Identificación:";
            // 
            // dtgJovenes
            // 
            this.dtgJovenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgJovenes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(202)))));
            this.dtgJovenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgJovenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(189)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgJovenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgJovenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(149)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgJovenes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgJovenes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgJovenes.EnableHeadersVisualStyles = false;
            this.dtgJovenes.GridColor = System.Drawing.Color.Silver;
            this.dtgJovenes.Location = new System.Drawing.Point(0, 448);
            this.dtgJovenes.Name = "dtgJovenes";
            this.dtgJovenes.ReadOnly = true;
            this.dtgJovenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgJovenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgJovenes.RowHeadersVisible = false;
            this.dtgJovenes.RowHeadersWidth = 51;
            this.dtgJovenes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgJovenes.RowTemplate.Height = 29;
            this.dtgJovenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgJovenes.Size = new System.Drawing.Size(1247, 305);
            this.dtgJovenes.TabIndex = 36;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 36);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Enabled = false;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Enabled = false;
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(95, 32);
            this.reporteToolStripMenuItem.Text = "Reporte";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // txtAuxilioEco
            // 
            this.txtAuxilioEco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAuxilioEco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(223)))), ((int)(((byte)(202)))));
            this.txtAuxilioEco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuxilioEco.Enabled = false;
            this.txtAuxilioEco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAuxilioEco.ForeColor = System.Drawing.Color.Black;
            this.txtAuxilioEco.Location = new System.Drawing.Point(859, 184);
            this.txtAuxilioEco.Name = "txtAuxilioEco";
            this.txtAuxilioEco.Size = new System.Drawing.Size(250, 34);
            this.txtAuxilioEco.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(592, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 28);
            this.label7.TabIndex = 61;
            this.label7.Text = "Auxilio econimico:";
            // 
            // FrmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1247, 753);
            this.Controls.Add(this.txtAuxilioEco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaActualizacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbComuna);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTotalRegistros);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgJovenes);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCola";
            ((System.ComponentModel.ISupportInitialize)(this.dtgJovenes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpFechaActualizacion;
        private Label label8;
        private ComboBox cmbComuna;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private ComboBox cmbGenero;
        private TextBox txtID;
        private TextBox txtTotalRegistros;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtgJovenes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem reporteToolStripMenuItem;
        private TextBox txtAuxilioEco;
        private Label label7;
        private ToolStripMenuItem regresarToolStripMenuItem;
    }
}