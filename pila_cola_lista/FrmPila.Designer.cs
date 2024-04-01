namespace pila_cola_lista
{
    partial class FrmPila
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgJovenes = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTodosPagos = new System.Windows.Forms.TextBox();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumCDT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbAperturaCDT = new System.Windows.Forms.ComboBox();
            this.txtMesesCDTBanco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgJovenes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgJovenes
            // 
            this.dtgJovenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgJovenes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgJovenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgJovenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgJovenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgJovenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgJovenes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgJovenes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgJovenes.EnableHeadersVisualStyles = false;
            this.dtgJovenes.GridColor = System.Drawing.Color.White;
            this.dtgJovenes.Location = new System.Drawing.Point(0, 481);
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
            this.dtgJovenes.Size = new System.Drawing.Size(1247, 272);
            this.dtgJovenes.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(274, 163);
            this.txtID.MaxLength = 9;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 34);
            this.txtID.TabIndex = 1;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategoria.ForeColor = System.Drawing.Color.Black;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Urbano"});
            this.cmbCategoria.Location = new System.Drawing.Point(274, 421);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(250, 36);
            this.cmbCategoria.TabIndex = 8;
            this.cmbCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategoria_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(114, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Identificación:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(408, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 45);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bancos aliados de Colombia";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(119, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(119, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(119, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Categoría:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(119, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estrato:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(274, 229);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 34);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(274, 294);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(250, 34);
            this.txtDireccion.TabIndex = 1;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(585, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 28);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total de pagos registrados:";
            // 
            // txtTodosPagos
            // 
            this.txtTodosPagos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTodosPagos.BackColor = System.Drawing.SystemColors.Control;
            this.txtTodosPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTodosPagos.Enabled = false;
            this.txtTodosPagos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTodosPagos.ForeColor = System.Drawing.Color.Black;
            this.txtTodosPagos.Location = new System.Drawing.Point(852, 364);
            this.txtTodosPagos.Name = "txtTodosPagos";
            this.txtTodosPagos.Size = new System.Drawing.Size(250, 34);
            this.txtTodosPagos.TabIndex = 24;
            // 
            // cmbEstrato
            // 
            this.cmbEstrato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEstrato.BackColor = System.Drawing.SystemColors.Control;
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
            this.cmbEstrato.Location = new System.Drawing.Point(274, 354);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(250, 36);
            this.cmbEstrato.TabIndex = 8;
            this.cmbEstrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEstrato_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(119, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 28);
            this.label10.TabIndex = 28;
            this.label10.Text = "Número CDT:";
            // 
            // txtNumCDT
            // 
            this.txtNumCDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumCDT.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumCDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumCDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumCDT.ForeColor = System.Drawing.Color.Black;
            this.txtNumCDT.Location = new System.Drawing.Point(274, 107);
            this.txtNumCDT.MaxLength = 12;
            this.txtNumCDT.Name = "txtNumCDT";
            this.txtNumCDT.Size = new System.Drawing.Size(250, 34);
            this.txtNumCDT.TabIndex = 1;
            this.txtNumCDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCDT_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(585, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 28);
            this.label11.TabIndex = 29;
            this.label11.Text = "Mes apertura CDT:";
            // 
            // cmbAperturaCDT
            // 
            this.cmbAperturaCDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAperturaCDT.BackColor = System.Drawing.SystemColors.Control;
            this.cmbAperturaCDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAperturaCDT.ForeColor = System.Drawing.Color.Black;
            this.cmbAperturaCDT.FormattingEnabled = true;
            this.cmbAperturaCDT.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbAperturaCDT.Location = new System.Drawing.Point(852, 105);
            this.cmbAperturaCDT.Name = "cmbAperturaCDT";
            this.cmbAperturaCDT.Size = new System.Drawing.Size(250, 36);
            this.cmbAperturaCDT.TabIndex = 8;
            this.cmbAperturaCDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAperturaCDT_KeyPress);
            // 
            // txtMesesCDTBanco
            // 
            this.txtMesesCDTBanco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMesesCDTBanco.BackColor = System.Drawing.SystemColors.Control;
            this.txtMesesCDTBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMesesCDTBanco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMesesCDTBanco.ForeColor = System.Drawing.Color.Black;
            this.txtMesesCDTBanco.Location = new System.Drawing.Point(852, 165);
            this.txtMesesCDTBanco.MaxLength = 4;
            this.txtMesesCDTBanco.Name = "txtMesesCDTBanco";
            this.txtMesesCDTBanco.Size = new System.Drawing.Size(250, 34);
            this.txtMesesCDTBanco.TabIndex = 1;
            this.txtMesesCDTBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesesCDTBanco_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(586, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 28);
            this.label12.TabIndex = 20;
            this.label12.Text = "Meses CDT en el banco:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(852, 298);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(250, 34);
            this.txtTotal.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(585, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 28);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total a pagar CDT:";
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
            this.menuStrip1.TabIndex = 33;
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
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(587, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 28);
            this.label8.TabIndex = 34;
            this.label8.Text = "Fecha de pago:";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaPago.Location = new System.Drawing.Point(852, 233);
            this.dtpFechaPago.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpFechaPago.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(250, 34);
            this.dtpFechaPago.TabIndex = 35;
            // 
            // FrmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1247, 753);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEstrato);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMesesCDTBanco);
            this.Controls.Add(this.cmbAperturaCDT);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNumCDT);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTodosPagos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgJovenes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dtgJovenes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgJovenes;
        private TextBox txtID;
        private ComboBox cmbCategoria;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Label label9;
        private TextBox txtTodosPagos;
        private ComboBox cmbEstrato;
        private Label label10;
        private TextBox txtNumCDT;
        private Label label11;
        private ComboBox cmbAperturaCDT;
        private TextBox txtMesesCDTBanco;
        private Label label12;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtTotal;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem reporteToolStripMenuItem;
        private Label label8;
        private DateTimePicker dtpFechaPago;
        private ToolStripMenuItem regresarToolStripMenuItem;
    }
}