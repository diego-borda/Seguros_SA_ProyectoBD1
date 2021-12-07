
namespace SegurosSA.View
{
    partial class FrmZona_Hospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZona_Hospital));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.idZona = new System.Windows.Forms.Label();
            this.idHos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIdHospital = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtIdZona = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtZona_Hospital = new System.Windows.Forms.DataGridView();
            this.ttZona = new System.Windows.Forms.ToolTip(this.components);
            this.ttHospital = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtZona_Hospital)).BeginInit();
            this.SuspendLayout();
            // 
            // idZona
            // 
            this.idZona.BackColor = System.Drawing.Color.DarkGray;
            this.idZona.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idZona.Location = new System.Drawing.Point(637, 59);
            this.idZona.MaximumSize = new System.Drawing.Size(100, 50);
            this.idZona.Name = "idZona";
            this.idZona.Size = new System.Drawing.Size(10, 32);
            this.idZona.TabIndex = 98;
            this.idZona.Visible = false;
            // 
            // idHos
            // 
            this.idHos.BackColor = System.Drawing.Color.DarkGray;
            this.idHos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idHos.Location = new System.Drawing.Point(617, 59);
            this.idHos.MaximumSize = new System.Drawing.Size(100, 50);
            this.idHos.Name = "idHos";
            this.idHos.Size = new System.Drawing.Size(10, 32);
            this.idHos.TabIndex = 97;
            this.idHos.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtIdHospital);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.idZona);
            this.panel1.Controls.Add(this.idHos);
            this.panel1.Controls.Add(this.txtIdZona);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 103);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(96, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 1);
            this.panel4.TabIndex = 15;
            // 
            // txtIdHospital
            // 
            this.txtIdHospital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtIdHospital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHospital.ForeColor = System.Drawing.SystemColors.Control;
            this.txtIdHospital.Location = new System.Drawing.Point(96, 12);
            this.txtIdHospital.Name = "txtIdHospital";
            this.txtIdHospital.ReadOnly = true;
            this.txtIdHospital.Size = new System.Drawing.Size(282, 19);
            this.txtIdHospital.TabIndex = 14;
            this.txtIdHospital.DoubleClick += new System.EventHandler(this.txtIdHospital_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hospital";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LimeGreen;
            this.panel5.ForeColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(96, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 1);
            this.panel5.TabIndex = 12;
            // 
            // txtIdZona
            // 
            this.txtIdZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtIdZona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdZona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdZona.ForeColor = System.Drawing.SystemColors.Control;
            this.txtIdZona.Location = new System.Drawing.Point(96, 60);
            this.txtIdZona.Name = "txtIdZona";
            this.txtIdZona.ReadOnly = true;
            this.txtIdZona.Size = new System.Drawing.Size(282, 19);
            this.txtIdZona.TabIndex = 11;
            this.txtIdZona.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtIdZona_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Zona";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.dtZona_Hospital);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 359);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(98, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 1);
            this.panel3.TabIndex = 129;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(98, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(280, 19);
            this.txtBuscar.TabIndex = 128;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 127;
            this.label1.Text = "Buscar ";
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 310);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(659, 49);
            this.flowLayoutPanel1.TabIndex = 130;
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
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkRed;
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
            // dtZona_Hospital
            // 
            this.dtZona_Hospital.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtZona_Hospital.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtZona_Hospital.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtZona_Hospital.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtZona_Hospital.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtZona_Hospital.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.dtZona_Hospital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtZona_Hospital.CausesValidation = false;
            this.dtZona_Hospital.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtZona_Hospital.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtZona_Hospital.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtZona_Hospital.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtZona_Hospital.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtZona_Hospital.EnableHeadersVisualStyles = false;
            this.dtZona_Hospital.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(141)))), ((int)(((byte)(202)))));
            this.dtZona_Hospital.Location = new System.Drawing.Point(16, 51);
            this.dtZona_Hospital.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtZona_Hospital.MultiSelect = false;
            this.dtZona_Hospital.Name = "dtZona_Hospital";
            this.dtZona_Hospital.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtZona_Hospital.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtZona_Hospital.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dtZona_Hospital.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtZona_Hospital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtZona_Hospital.Size = new System.Drawing.Size(633, 238);
            this.dtZona_Hospital.TabIndex = 95;
            this.dtZona_Hospital.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtZona_Hospital_CellFormatting);
            // 
            // ttZona
            // 
            this.ttZona.AutomaticDelay = 100;
            this.ttZona.AutoPopDelay = 6000;
            this.ttZona.InitialDelay = 100;
            this.ttZona.IsBalloon = true;
            this.ttZona.ReshowDelay = 50;
            // 
            // ttHospital
            // 
            this.ttHospital.AutomaticDelay = 100;
            this.ttHospital.AutoPopDelay = 6000;
            this.ttHospital.InitialDelay = 100;
            this.ttHospital.IsBalloon = true;
            this.ttHospital.ReshowDelay = 50;
            // 
            // FrmZona_Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(659, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmZona_Hospital";
            this.Text = "FrmZona_Hospital";
            this.Load += new System.EventHandler(this.FrmZona_Hospital_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtZona_Hospital)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label idZona;
        private System.Windows.Forms.Label idHos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIdHospital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtIdZona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtZona_Hospital;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip ttZona;
        private System.Windows.Forms.ToolTip ttHospital;
    }
}