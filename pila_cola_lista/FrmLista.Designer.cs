namespace pila_cola_lista
{
    partial class FrmLista
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgEstudiante = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbTipoID = new System.Windows.Forms.ComboBox();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiante)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(230)))));
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFecha.Location = new System.Drawing.Point(897, 120);
            this.dtpFecha.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(250, 34);
            this.dtpFecha.TabIndex = 79;
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecha_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(685, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 28);
            this.label8.TabIndex = 78;
            this.label8.Text = "Fecha registro:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(284, 254);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 34);
            this.txtNombre.TabIndex = 65;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(74, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 72;
            this.label4.Text = "Estrato:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(74, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nombre completo:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(592, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 45);
            this.label2.TabIndex = 70;
            this.label2.Text = "UNAD";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 69;
            this.label1.Text = "Tipo identificación:";
            // 
            // dtgEstudiante
            // 
            this.dtgEstudiante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEstudiante.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.dtgEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgEstudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEstudiante.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgEstudiante.EnableHeadersVisualStyles = false;
            this.dtgEstudiante.GridColor = System.Drawing.Color.Silver;
            this.dtgEstudiante.Location = new System.Drawing.Point(0, 434);
            this.dtgEstudiante.Name = "dtgEstudiante";
            this.dtgEstudiante.ReadOnly = true;
            this.dtgEstudiante.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEstudiante.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgEstudiante.RowHeadersVisible = false;
            this.dtgEstudiante.RowHeadersWidth = 51;
            this.dtgEstudiante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgEstudiante.RowTemplate.Height = 29;
            this.dtgEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgEstudiante.Size = new System.Drawing.Size(1247, 319);
            this.dtgEstudiante.TabIndex = 63;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 36);
            this.menuStrip1.TabIndex = 77;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Enabled = false;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(82, 32);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Enabled = false;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // cmbTipoID
            // 
            this.cmbTipoID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.cmbTipoID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoID.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoID.FormattingEnabled = true;
            this.cmbTipoID.Items.AddRange(new object[] {
            "CC",
            "TI",
            "CE",
            "NIP",
            "NIT"});
            this.cmbTipoID.Location = new System.Drawing.Point(284, 126);
            this.cmbTipoID.Name = "cmbTipoID";
            this.cmbTipoID.Size = new System.Drawing.Size(250, 36);
            this.cmbTipoID.TabIndex = 82;
            this.cmbTipoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoID_KeyPress);
            // 
            // cmbEstrato
            // 
            this.cmbEstrato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEstrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.cmbEstrato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEstrato.ForeColor = System.Drawing.Color.Black;
            this.cmbEstrato.FormattingEnabled = true;
            this.cmbEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbEstrato.Location = new System.Drawing.Point(284, 313);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(250, 36);
            this.cmbEstrato.TabIndex = 83;
            this.cmbEstrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEstrato_KeyPress);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.listView1.Location = new System.Drawing.Point(685, 190);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(462, 159);
            this.listView1.TabIndex = 84;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(753, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 28);
            this.label5.TabIndex = 85;
            this.label5.Text = "Voto en las elecciones presidenciale";
            // 
            // rbSi
            // 
            this.rbSi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbSi.AutoSize = true;
            this.rbSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.rbSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSi.Location = new System.Drawing.Point(826, 270);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(49, 32);
            this.rbSi.TabIndex = 86;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = false;
            this.rbSi.CheckedChanged += new System.EventHandler(this.rbSi_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbNo.AutoSize = true;
            this.rbNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.rbNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNo.Location = new System.Drawing.Point(941, 270);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(60, 32);
            this.rbNo.TabIndex = 87;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = false;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(74, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 28);
            this.label6.TabIndex = 88;
            this.label6.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEdad.ForeColor = System.Drawing.Color.Black;
            this.txtEdad.Location = new System.Drawing.Point(284, 379);
            this.txtEdad.MaxLength = 50;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(250, 34);
            this.txtEdad.TabIndex = 89;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(284, 190);
            this.txtID.MaxLength = 9;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 34);
            this.txtID.TabIndex = 9;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(74, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 28);
            this.label7.TabIndex = 91;
            this.label7.Text = "Identificación:";
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(232)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1247, 753);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbSi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbEstrato);
            this.Controls.Add(this.cmbTipoID);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgEstudiante);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLista";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiante)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dtpFecha;
        private Label label8;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtgEstudiante;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem regresarToolStripMenuItem;
        private ComboBox cmbTipoID;
        private ComboBox cmbEstrato;
        private ListView listView1;
        private Label label5;
        private RadioButton rbSi;
        private RadioButton rbNo;
        private Label label6;
        private TextBox txtEdad;
        private TextBox txtID;
        private Label label7;
    }
}