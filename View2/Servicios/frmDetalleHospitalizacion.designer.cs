namespace View2.Servicios
{
    partial class frmDetalleHospitalizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleHospitalizacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtDetalleH = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.gasto = new System.Windows.Forms.Label();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.dtpFechaF = new System.Windows.Forms.DateTimePicker();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ttGasto = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalleH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.dtDetalleH);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 337);
            this.panel2.TabIndex = 22;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEstado);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 288);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(699, 49);
            this.flowLayoutPanel1.TabIndex = 140;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(4, 3);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 42);
            this.btnNuevo.TabIndex = 96;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(120, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 42);
            this.btnGuardar.TabIndex = 98;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(236, 3);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(128, 42);
            this.btnModificar.TabIndex = 97;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.FlatAppearance.BorderSize = 0;
            this.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.Color.White;
            this.btnEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnEstado.Image")));
            this.btnEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstado.Location = new System.Drawing.Point(372, 3);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(108, 42);
            this.btnEstado.TabIndex = 99;
            this.btnEstado.Text = "Estado";
            this.btnEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(488, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 42);
            this.btnCancelar.TabIndex = 100;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtDetalleH
            // 
            this.dtDetalleH.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtDetalleH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtDetalleH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDetalleH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtDetalleH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtDetalleH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.dtDetalleH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtDetalleH.CausesValidation = false;
            this.dtDetalleH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtDetalleH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDetalleH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtDetalleH.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDetalleH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtDetalleH.EnableHeadersVisualStyles = false;
            this.dtDetalleH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            this.dtDetalleH.Location = new System.Drawing.Point(13, 49);
            this.dtDetalleH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtDetalleH.MultiSelect = false;
            this.dtDetalleH.Name = "dtDetalleH";
            this.dtDetalleH.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDetalleH.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtDetalleH.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dtDetalleH.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtDetalleH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDetalleH.Size = new System.Drawing.Size(673, 220);
            this.dtDetalleH.TabIndex = 139;
            this.dtDetalleH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtDetalleH_CellFormatting);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LimeGreen;
            this.panel7.ForeColor = System.Drawing.SystemColors.Control;
            this.panel7.Location = new System.Drawing.Point(89, 31);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(425, 1);
            this.panel7.TabIndex = 138;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(89, 6);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(425, 20);
            this.txtBuscar.TabIndex = 137;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 136;
            this.label6.Text = "Buscar ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.gasto);
            this.panel1.Controls.Add(this.txtIdDetalle);
            this.panel1.Controls.Add(this.dtpFechaF);
            this.panel1.Controls.Add(this.txtCosto);
            this.panel1.Controls.Add(this.txtGasto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 173);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(130, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 1);
            this.panel3.TabIndex = 140;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 1);
            this.panel4.TabIndex = 140;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.LimeGreen;
            this.panel11.ForeColor = System.Drawing.SystemColors.Control;
            this.panel11.Location = new System.Drawing.Point(130, 59);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(247, 1);
            this.panel11.TabIndex = 139;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.Location = new System.Drawing.Point(498, 79);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(188, 63);
            this.txtDescripcion.TabIndex = 19;
            // 
            // gasto
            // 
            this.gasto.Location = new System.Drawing.Point(387, 138);
            this.gasto.Name = "gasto";
            this.gasto.Size = new System.Drawing.Size(36, 23);
            this.gasto.TabIndex = 14;
            this.gasto.Visible = false;
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtIdDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetalle.ForeColor = System.Drawing.SystemColors.Window;
            this.txtIdDetalle.Location = new System.Drawing.Point(621, 12);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.ReadOnly = true;
            this.txtIdDetalle.Size = new System.Drawing.Size(65, 22);
            this.txtIdDetalle.TabIndex = 0;
            // 
            // dtpFechaF
            // 
            this.dtpFechaF.Location = new System.Drawing.Point(130, 122);
            this.dtpFechaF.Name = "dtpFechaF";
            this.dtpFechaF.Size = new System.Drawing.Size(247, 20);
            this.dtpFechaF.TabIndex = 11;
            this.dtpFechaF.ValueChanged += new System.EventHandler(this.dtpFechaF_ValueChanged);
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCosto.Location = new System.Drawing.Point(130, 80);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(247, 19);
            this.txtCosto.TabIndex = 3;
            // 
            // txtGasto
            // 
            this.txtGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtGasto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGasto.ForeColor = System.Drawing.SystemColors.Window;
            this.txtGasto.Location = new System.Drawing.Point(130, 40);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.ReadOnly = true;
            this.txtGasto.Size = new System.Drawing.Size(247, 19);
            this.txtGasto.TabIndex = 4;
            this.txtGasto.DoubleClick += new System.EventHandler(this.txtGasto_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(416, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detalle de la Hospitalizacion  #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(405, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripcion ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Gasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Costo ";
            // 
            // ttGasto
            // 
            this.ttGasto.AutoPopDelay = 6000;
            this.ttGasto.InitialDelay = 100;
            this.ttGasto.IsBalloon = true;
            this.ttGasto.ReshowDelay = 50;
            this.ttGasto.ToolTipTitle = "Como Insertar";
            // 
            // frmDetalleHospitalizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmDetalleHospitalizacion";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmDetalleHospitalizacion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalleH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gasto;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.DateTimePicker dtpFechaF;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ToolTip ttGasto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtDetalleH;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnCancelar;
    }
}