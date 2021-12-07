namespace View2.Servicios
{
    partial class frmContrato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContrato));
            this.dtpFechaI = new System.Windows.Forms.DateTimePicker();
            this.txtAsegurado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtContratos = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idpol = new System.Windows.Forms.Label();
            this.idaseg = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCancelarContrato = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPoliza = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.dtpFechaF = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtCobertura = new System.Windows.Forms.TextBox();
            this.ttAsegurado = new System.Windows.Forms.ToolTip(this.components);
            this.ttPoliza = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtContratos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaI
            // 
            this.dtpFechaI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaI.Location = new System.Drawing.Point(123, 85);
            this.dtpFechaI.Name = "dtpFechaI";
            this.dtpFechaI.Size = new System.Drawing.Size(223, 20);
            this.dtpFechaI.TabIndex = 89;
            this.dtpFechaI.Value = new System.DateTime(2021, 11, 22, 0, 0, 0, 0);
            this.dtpFechaI.ValueChanged += new System.EventHandler(this.dtpFechaI_ValueChanged);
            // 
            // txtAsegurado
            // 
            this.txtAsegurado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAsegurado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtAsegurado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAsegurado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsegurado.ForeColor = System.Drawing.Color.White;
            this.txtAsegurado.Location = new System.Drawing.Point(123, 15);
            this.txtAsegurado.Name = "txtAsegurado";
            this.txtAsegurado.ReadOnly = true;
            this.txtAsegurado.Size = new System.Drawing.Size(263, 16);
            this.txtAsegurado.TabIndex = 87;
            this.txtAsegurado.DoubleClick += new System.EventHandler(this.txtAsegurado_DoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "Asegurado  ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.dtContratos);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.idpol);
            this.panel2.Controls.Add(this.idaseg);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(0, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 304);
            this.panel2.TabIndex = 86;
            // 
            // dtContratos
            // 
            this.dtContratos.AllowUserToAddRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtContratos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dtContratos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtContratos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtContratos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.dtContratos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtContratos.CausesValidation = false;
            this.dtContratos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtContratos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtContratos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtContratos.ColumnHeadersHeight = 30;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtContratos.DefaultCellStyle = dataGridViewCellStyle13;
            this.dtContratos.EnableHeadersVisualStyles = false;
            this.dtContratos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            this.dtContratos.Location = new System.Drawing.Point(12, 49);
            this.dtContratos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtContratos.MultiSelect = false;
            this.dtContratos.Name = "dtContratos";
            this.dtContratos.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtContratos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtContratos.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dtContratos.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtContratos.Size = new System.Drawing.Size(786, 190);
            this.dtContratos.TabIndex = 132;
            this.dtContratos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtContratos_CellFormatting);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LimeGreen;
            this.panel7.ForeColor = System.Drawing.SystemColors.Control;
            this.panel7.Location = new System.Drawing.Point(81, 31);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(425, 1);
            this.panel7.TabIndex = 135;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(81, 6);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(425, 20);
            this.txtBuscar.TabIndex = 134;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "Buscar ";
            // 
            // idpol
            // 
            this.idpol.BackColor = System.Drawing.SystemColors.Control;
            this.idpol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idpol.Location = new System.Drawing.Point(797, 29);
            this.idpol.MaximumSize = new System.Drawing.Size(100, 50);
            this.idpol.Name = "idpol";
            this.idpol.Size = new System.Drawing.Size(10, 10);
            this.idpol.TabIndex = 96;
            this.idpol.Visible = false;
            // 
            // idaseg
            // 
            this.idaseg.BackColor = System.Drawing.SystemColors.Control;
            this.idaseg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idaseg.Location = new System.Drawing.Point(797, 16);
            this.idaseg.MaximumSize = new System.Drawing.Size(100, 50);
            this.idaseg.Name = "idaseg";
            this.idaseg.Size = new System.Drawing.Size(10, 10);
            this.idaseg.TabIndex = 94;
            this.idaseg.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEstado);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelarContrato);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 255);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(810, 49);
            this.flowLayoutPanel1.TabIndex = 131;
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
            // btnCancelarContrato
            // 
            this.btnCancelarContrato.FlatAppearance.BorderSize = 0;
            this.btnCancelarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarContrato.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarContrato.Image")));
            this.btnCancelarContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarContrato.Location = new System.Drawing.Point(616, 3);
            this.btnCancelarContrato.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarContrato.Name = "btnCancelarContrato";
            this.btnCancelarContrato.Size = new System.Drawing.Size(174, 42);
            this.btnCancelarContrato.TabIndex = 101;
            this.btnCancelarContrato.Text = "Cancelar Contrato";
            this.btnCancelarContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarContrato.UseVisualStyleBackColor = false;
            this.btnCancelarContrato.Click += new System.EventHandler(this.btnCancelarContrato_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(400, 125);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(53, 16);
            this.lblTelefono.TabIndex = 85;
            this.lblTelefono.Text = "Costo ";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.ForeColor = System.Drawing.Color.White;
            this.lblSegundoApellido.Location = new System.Drawing.Point(9, 89);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(99, 16);
            this.lblSegundoApellido.TabIndex = 84;
            this.lblSegundoApellido.Text = "Fecha Inicio ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtDescripcion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(533, 24);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(257, 82);
            this.txtDescripcion.TabIndex = 80;
            // 
            // txtPoliza
            // 
            this.txtPoliza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtPoliza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoliza.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoliza.ForeColor = System.Drawing.Color.White;
            this.txtPoliza.Location = new System.Drawing.Point(123, 49);
            this.txtPoliza.Name = "txtPoliza";
            this.txtPoliza.ReadOnly = true;
            this.txtPoliza.Size = new System.Drawing.Size(263, 16);
            this.txtPoliza.TabIndex = 77;
            this.txtPoliza.DoubleClick += new System.EventHandler(this.txtPoliza_DoubleClick);
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.ForeColor = System.Drawing.Color.White;
            this.lblPrimerApellido.Location = new System.Drawing.Point(420, 22);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(95, 16);
            this.lblPrimerApellido.TabIndex = 83;
            this.lblPrimerApellido.Text = "Descripcion ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "Tipo Poliza ";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.ForeColor = System.Drawing.Color.White;
            this.lblSegundoNombre.Location = new System.Drawing.Point(9, 150);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(81, 16);
            this.lblSegundoNombre.TabIndex = 82;
            this.lblSegundoNombre.Text = "Fecha Fin ";
            // 
            // dtpFechaF
            // 
            this.dtpFechaF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaF.Location = new System.Drawing.Point(123, 150);
            this.dtpFechaF.Name = "dtpFechaF";
            this.dtpFechaF.Size = new System.Drawing.Size(223, 20);
            this.dtpFechaF.TabIndex = 90;
            this.dtpFechaF.Value = new System.DateTime(2021, 11, 22, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(400, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 91;
            this.label4.Text = "Cobertura ($)  ";
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.Color.White;
            this.txtCosto.Location = new System.Drawing.Point(533, 125);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(263, 16);
            this.txtCosto.TabIndex = 92;
            // 
            // txtCobertura
            // 
            this.txtCobertura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCobertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtCobertura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCobertura.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCobertura.ForeColor = System.Drawing.Color.White;
            this.txtCobertura.Location = new System.Drawing.Point(535, 162);
            this.txtCobertura.Name = "txtCobertura";
            this.txtCobertura.Size = new System.Drawing.Size(263, 16);
            this.txtCobertura.TabIndex = 93;
            // 
            // ttAsegurado
            // 
            this.ttAsegurado.AutoPopDelay = 6000;
            this.ttAsegurado.InitialDelay = 20;
            this.ttAsegurado.IsBalloon = true;
            this.ttAsegurado.ReshowDelay = 100;
            this.ttAsegurado.ToolTipTitle = "Como Insertar";
            // 
            // ttPoliza
            // 
            this.ttPoliza.AutomaticDelay = 100;
            this.ttPoliza.AutoPopDelay = 6000;
            this.ttPoliza.InitialDelay = 100;
            this.ttPoliza.IsBalloon = true;
            this.ttPoliza.ReshowDelay = 20;
            this.ttPoliza.ToolTipTitle = "Como Insertar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.txtCosto);
            this.panel1.Controls.Add(this.txtCobertura);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpFechaF);
            this.panel1.Controls.Add(this.dtpFechaI);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtAsegurado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblSegundoApellido);
            this.panel1.Controls.Add(this.txtPoliza);
            this.panel1.Controls.Add(this.lblPrimerApellido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSegundoNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 204);
            this.panel1.TabIndex = 94;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.LimeGreen;
            this.panel6.ForeColor = System.Drawing.SystemColors.Control;
            this.panel6.Location = new System.Drawing.Point(533, 181);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(257, 1);
            this.panel6.TabIndex = 118;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LimeGreen;
            this.panel5.ForeColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(533, 144);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(257, 1);
            this.panel5.TabIndex = 120;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(123, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 1);
            this.panel3.TabIndex = 118;
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.BackColor = System.Drawing.Color.LimeGreen;
            this.panel13.ForeColor = System.Drawing.SystemColors.Control;
            this.panel13.Location = new System.Drawing.Point(123, 34);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(263, 1);
            this.panel13.TabIndex = 117;
            // 
            // frmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmContrato";
            this.Text = "Contrato de Polizas";
            this.Load += new System.EventHandler(this.frmContrato_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtContratos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaI;
        private System.Windows.Forms.TextBox txtAsegurado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPoliza;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtCobertura;
        private System.Windows.Forms.ToolTip ttAsegurado;
        private System.Windows.Forms.ToolTip ttPoliza;
        private System.Windows.Forms.Label idaseg;
        private System.Windows.Forms.Label idpol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtContratos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarContrato;
    }
}