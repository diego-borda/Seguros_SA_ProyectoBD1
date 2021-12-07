
namespace View2.Servicios
{
    partial class FrmHospitalizacion2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHospitalizacion2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtHospit = new System.Windows.Forms.DataGridView();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.zona = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.categoria = new System.Windows.Forms.Label();
            this.medico = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.hospital = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.contrato = new System.Windows.Forms.Label();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.dtpFechaF = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaI = new System.Windows.Forms.DateTimePicker();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ttAseg = new System.Windows.Forms.ToolTip(this.components);
            this.ttHosp = new System.Windows.Forms.ToolTip(this.components);
            this.ttMedico = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHospit)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.dtHospit);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.idpol);
            this.panel2.Controls.Add(this.idaseg);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(0, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 334);
            this.panel2.TabIndex = 87;
            // 
            // dtHospit
            // 
            this.dtHospit.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtHospit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtHospit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtHospit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtHospit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtHospit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.dtHospit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtHospit.CausesValidation = false;
            this.dtHospit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtHospit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtHospit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtHospit.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtHospit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtHospit.EnableHeadersVisualStyles = false;
            this.dtHospit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            this.dtHospit.Location = new System.Drawing.Point(12, 49);
            this.dtHospit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtHospit.MultiSelect = false;
            this.dtHospit.Name = "dtHospit";
            this.dtHospit.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtHospit.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtHospit.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dtHospit.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtHospit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtHospit.Size = new System.Drawing.Size(801, 220);
            this.dtHospit.TabIndex = 132;
            this.dtHospit.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtHospit_CellFormatting);
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
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 285);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(825, 49);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.zona);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.categoria);
            this.panel1.Controls.Add(this.medico);
            this.panel1.Controls.Add(this.txtMedico);
            this.panel1.Controls.Add(this.hospital);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.contrato);
            this.panel1.Controls.Add(this.txtHospital);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.txtContrato);
            this.panel1.Controls.Add(this.dtpFechaF);
            this.panel1.Controls.Add(this.dtpFechaI);
            this.panel1.Controls.Add(this.lblSegundoApellido);
            this.panel1.Controls.Add(this.lblSegundoNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 220);
            this.panel1.TabIndex = 95;
            // 
            // zona
            // 
            this.zona.Location = new System.Drawing.Point(744, 182);
            this.zona.Name = "zona";
            this.zona.Size = new System.Drawing.Size(55, 23);
            this.zona.TabIndex = 100;
            this.zona.Visible = false;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.LimeGreen;
            this.panel11.ForeColor = System.Drawing.SystemColors.Control;
            this.panel11.Location = new System.Drawing.Point(113, 155);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(294, 1);
            this.panel11.TabIndex = 138;
            // 
            // categoria
            // 
            this.categoria.Location = new System.Drawing.Point(664, 182);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(55, 23);
            this.categoria.TabIndex = 99;
            this.categoria.Visible = false;
            // 
            // medico
            // 
            this.medico.Location = new System.Drawing.Point(587, 182);
            this.medico.Name = "medico";
            this.medico.Size = new System.Drawing.Size(42, 23);
            this.medico.TabIndex = 98;
            this.medico.Visible = false;
            // 
            // txtMedico
            // 
            this.txtMedico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMedico.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedico.ForeColor = System.Drawing.SystemColors.Control;
            this.txtMedico.Location = new System.Drawing.Point(113, 130);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(294, 20);
            this.txtMedico.TabIndex = 137;
            this.txtMedico.Click += new System.EventHandler(this.txtMedico_DoubleClick);
            // 
            // hospital
            // 
            this.hospital.Location = new System.Drawing.Point(506, 182);
            this.hospital.Name = "hospital";
            this.hospital.Size = new System.Drawing.Size(47, 23);
            this.hospital.TabIndex = 97;
            this.hospital.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.LimeGreen;
            this.panel10.ForeColor = System.Drawing.SystemColors.Control;
            this.panel10.Location = new System.Drawing.Point(113, 121);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(294, 1);
            this.panel10.TabIndex = 136;
            // 
            // contrato
            // 
            this.contrato.Location = new System.Drawing.Point(445, 182);
            this.contrato.Name = "contrato";
            this.contrato.Size = new System.Drawing.Size(36, 23);
            this.contrato.TabIndex = 96;
            this.contrato.Visible = false;
            // 
            // txtHospital
            // 
            this.txtHospital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHospital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtHospital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHospital.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospital.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHospital.Location = new System.Drawing.Point(113, 96);
            this.txtHospital.Name = "txtHospital";
            this.txtHospital.Size = new System.Drawing.Size(294, 20);
            this.txtHospital.TabIndex = 135;
            this.txtHospital.DoubleClick += new System.EventHandler(this.txtHospital_DoubleClick);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.LimeGreen;
            this.panel9.ForeColor = System.Drawing.SystemColors.Control;
            this.panel9.Location = new System.Drawing.Point(113, 89);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(294, 1);
            this.panel9.TabIndex = 134;
            // 
            // txtContrato
            // 
            this.txtContrato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtContrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrato.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrato.ForeColor = System.Drawing.SystemColors.Control;
            this.txtContrato.Location = new System.Drawing.Point(113, 64);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(294, 20);
            this.txtContrato.TabIndex = 133;
            this.txtContrato.DoubleClick += new System.EventHandler(this.txtContrato_DoubleClick);
            // 
            // dtpFechaF
            // 
            this.dtpFechaF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaF.Location = new System.Drawing.Point(553, 131);
            this.dtpFechaF.Name = "dtpFechaF";
            this.dtpFechaF.Size = new System.Drawing.Size(223, 20);
            this.dtpFechaF.TabIndex = 90;
            this.dtpFechaF.Value = new System.DateTime(2021, 11, 22, 0, 0, 0, 0);
            // 
            // dtpFechaI
            // 
            this.dtpFechaI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaI.Location = new System.Drawing.Point(553, 66);
            this.dtpFechaI.Name = "dtpFechaI";
            this.dtpFechaI.Size = new System.Drawing.Size(223, 20);
            this.dtpFechaI.TabIndex = 89;
            this.dtpFechaI.Value = new System.DateTime(2021, 11, 22, 0, 0, 0, 0);
            this.dtpFechaI.ValueChanged += new System.EventHandler(this.dtpFechaI_ValueChanged);
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.ForeColor = System.Drawing.Color.White;
            this.lblSegundoApellido.Location = new System.Drawing.Point(439, 70);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(99, 16);
            this.lblSegundoApellido.TabIndex = 84;
            this.lblSegundoApellido.Text = "Fecha Inicio ";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.ForeColor = System.Drawing.Color.White;
            this.lblSegundoNombre.Location = new System.Drawing.Point(439, 131);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(81, 16);
            this.lblSegundoNombre.TabIndex = 82;
            this.lblSegundoNombre.Text = "Fecha Fin ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "Asegurado  ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(13, 138);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 16);
            this.lblTelefono.TabIndex = 85;
            this.lblTelefono.Text = "Medico";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "Hospital";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(825, 46);
            this.flowLayoutPanel2.TabIndex = 132;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 96;
            this.button1.Text = "Ver detalle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(139, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 42);
            this.button2.TabIndex = 98;
            this.button2.Text = "Agregar detalles";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnVerAgregar_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(320, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 42);
            this.button3.TabIndex = 97;
            this.button3.Text = "Cancelar Hospitalización";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnCancelarHospitalizacion_Click);
            // 
            // ttAseg
            // 
            this.ttAseg.AutomaticDelay = 100;
            this.ttAseg.AutoPopDelay = 6000;
            this.ttAseg.InitialDelay = 50;
            this.ttAseg.IsBalloon = true;
            this.ttAseg.ReshowDelay = 100;
            this.ttAseg.ToolTipTitle = "Como Insertar";
            // 
            // ttHosp
            // 
            this.ttHosp.AutomaticDelay = 100;
            this.ttHosp.AutoPopDelay = 6000;
            this.ttHosp.InitialDelay = 50;
            this.ttHosp.IsBalloon = true;
            this.ttHosp.ReshowDelay = 100;
            this.ttHosp.ToolTipTitle = "Como Insertar";
            // 
            // ttMedico
            // 
            this.ttMedico.AutomaticDelay = 100;
            this.ttMedico.AutoPopDelay = 6000;
            this.ttMedico.InitialDelay = 50;
            this.ttMedico.IsBalloon = true;
            this.ttMedico.ReshowDelay = 100;
            this.ttMedico.ToolTipTitle = "Como Insertar";
            // 
            // FrmHospitalizacion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHospitalizacion2";
            this.Text = "FrmHospitalizacion2";
            this.Load += new System.EventHandler(this.frmHospitalizacion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHospit)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtHospit;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idpol;
        private System.Windows.Forms.Label idaseg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFechaF;
        private System.Windows.Forms.DateTimePicker dtpFechaI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.ToolTip ttAseg;
        private System.Windows.Forms.ToolTip ttHosp;
        private System.Windows.Forms.ToolTip ttMedico;
        private System.Windows.Forms.Label zona;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.Label medico;
        private System.Windows.Forms.Label hospital;
        private System.Windows.Forms.Label contrato;
    }
}