
namespace View2.Reportes.ReporteAsegurado
{
    partial class FrmReporteAsegurado
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteAsegurado));
            this.Reporte_por_AseguradoPt1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataAsegurado = new View2.Reportes.ReporteAsegurado.DataAsegurado();
            this.Reporte_por_AseguradoPt2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_por_AseguradoPt3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_por_AseguradoPt4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_por_AseguradoPt5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdHospitalizacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIdAsegurado = new System.Windows.Forms.TextBox();
            this.Reporte_por_AseguradoPt1TableAdapter = new View2.Reportes.ReporteAsegurado.DataAseguradoTableAdapters.Reporte_por_AseguradoPt1TableAdapter();
            this.Reporte_por_AseguradoPt2TableAdapter = new View2.Reportes.ReporteAsegurado.DataAseguradoTableAdapters.Reporte_por_AseguradoPt2TableAdapter();
            this.Reporte_por_AseguradoPt3TableAdapter = new View2.Reportes.ReporteAsegurado.DataAseguradoTableAdapters.Reporte_por_AseguradoPt3TableAdapter();
            this.Reporte_por_AseguradoPt4TableAdapter = new View2.Reportes.ReporteAsegurado.DataAseguradoTableAdapters.Reporte_por_AseguradoPt4TableAdapter();
            this.Reporte_por_AseguradoPt5TableAdapter = new View2.Reportes.ReporteAsegurado.DataAseguradoTableAdapters.Reporte_por_AseguradoPt5TableAdapter();
            this.idHos = new System.Windows.Forms.Label();
            this.idZona = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_AseguradoPt1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAsegurado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_AseguradoPt2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_AseguradoPt3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_AseguradoPt4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_AseguradoPt5BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reporte_por_AseguradoPt1BindingSource
            // 
            this.Reporte_por_AseguradoPt1BindingSource.DataMember = "Reporte_por_AseguradoPt1";
            this.Reporte_por_AseguradoPt1BindingSource.DataSource = this.DataAsegurado;
            // 
            // DataAsegurado
            // 
            this.DataAsegurado.DataSetName = "DataAsegurado";
            this.DataAsegurado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_por_AseguradoPt2BindingSource
            // 
            this.Reporte_por_AseguradoPt2BindingSource.DataMember = "Reporte_por_AseguradoPt2";
            this.Reporte_por_AseguradoPt2BindingSource.DataSource = this.DataAsegurado;
            // 
            // Reporte_por_AseguradoPt3BindingSource
            // 
            this.Reporte_por_AseguradoPt3BindingSource.DataMember = "Reporte_por_AseguradoPt3";
            this.Reporte_por_AseguradoPt3BindingSource.DataSource = this.DataAsegurado;
            // 
            // Reporte_por_AseguradoPt4BindingSource
            // 
            this.Reporte_por_AseguradoPt4BindingSource.DataMember = "Reporte_por_AseguradoPt4";
            this.Reporte_por_AseguradoPt4BindingSource.DataSource = this.DataAsegurado;
            // 
            // Reporte_por_AseguradoPt5BindingSource
            // 
            this.Reporte_por_AseguradoPt5BindingSource.DataMember = "Reporte_por_AseguradoPt5";
            this.Reporte_por_AseguradoPt5BindingSource.DataSource = this.DataAsegurado;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource6.Name = "DataAseguradoPt1";
            reportDataSource6.Value = this.Reporte_por_AseguradoPt1BindingSource;
            reportDataSource7.Name = "DataAseguradoPt2";
            reportDataSource7.Value = this.Reporte_por_AseguradoPt2BindingSource;
            reportDataSource8.Name = "DataAseguradoPt3";
            reportDataSource8.Value = this.Reporte_por_AseguradoPt3BindingSource;
            reportDataSource9.Name = "DataAseguradoPt4";
            reportDataSource9.Value = this.Reporte_por_AseguradoPt4BindingSource;
            reportDataSource10.Name = "DataAseguradoPt5";
            reportDataSource10.Value = this.Reporte_por_AseguradoPt5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "View2.Reportes.ReporteAsegurado.RAsegurado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(168, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(686, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.idZona);
            this.panel1.Controls.Add(this.idHos);
            this.panel1.Controls.Add(this.pnlControl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtContrato);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtIdAsegurado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.button2);
            this.pnlControl.Controls.Add(this.panel3);
            this.pnlControl.Controls.Add(this.txtIdHospitalizacion);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 314);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(168, 97);
            this.pnlControl.TabIndex = 126;
            this.pnlControl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 125;
            this.label2.Text = "ID Hospitalización";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(107, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 43);
            this.button2.TabIndex = 105;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LimeGreen;
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(9, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(91, 1);
            this.panel3.TabIndex = 21;
            // 
            // txtIdHospitalizacion
            // 
            this.txtIdHospitalizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtIdHospitalizacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdHospitalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHospitalizacion.ForeColor = System.Drawing.SystemColors.Control;
            this.txtIdHospitalizacion.Location = new System.Drawing.Point(9, 50);
            this.txtIdHospitalizacion.Name = "txtIdHospitalizacion";
            this.txtIdHospitalizacion.Size = new System.Drawing.Size(91, 19);
            this.txtIdHospitalizacion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 130;
            this.label1.Text = "ID Contrato";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(12, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 1);
            this.panel2.TabIndex = 128;
            // 
            // txtContrato
            // 
            this.txtContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtContrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrato.ForeColor = System.Drawing.SystemColors.Control;
            this.txtContrato.Location = new System.Drawing.Point(12, 171);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.ReadOnly = true;
            this.txtContrato.Size = new System.Drawing.Size(107, 19);
            this.txtContrato.TabIndex = 127;
            this.txtContrato.DoubleClick += new System.EventHandler(this.txtContrato_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(8, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 123;
            this.label9.Text = "ID Asegurado";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAceptar.Location = new System.Drawing.Point(13, 213);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 43);
            this.btnAceptar.TabIndex = 103;
            this.btnAceptar.Text = "Seleccionar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 411);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(168, 39);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(4, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 33);
            this.btnCancelar.TabIndex = 101;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(12, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(107, 1);
            this.panel4.TabIndex = 17;
            // 
            // txtIdAsegurado
            // 
            this.txtIdAsegurado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtIdAsegurado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdAsegurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAsegurado.ForeColor = System.Drawing.SystemColors.Control;
            this.txtIdAsegurado.Location = new System.Drawing.Point(12, 98);
            this.txtIdAsegurado.Name = "txtIdAsegurado";
            this.txtIdAsegurado.ReadOnly = true;
            this.txtIdAsegurado.Size = new System.Drawing.Size(107, 19);
            this.txtIdAsegurado.TabIndex = 16;
            this.txtIdAsegurado.DoubleClick += new System.EventHandler(this.txtIdAsegurado_DoubleClick);
            // 
            // Reporte_por_AseguradoPt1TableAdapter
            // 
            this.Reporte_por_AseguradoPt1TableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_por_AseguradoPt2TableAdapter
            // 
            this.Reporte_por_AseguradoPt2TableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_por_AseguradoPt3TableAdapter
            // 
            this.Reporte_por_AseguradoPt3TableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_por_AseguradoPt4TableAdapter
            // 
            this.Reporte_por_AseguradoPt4TableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_por_AseguradoPt5TableAdapter
            // 
            this.Reporte_por_AseguradoPt5TableAdapter.ClearBeforeFill = true;
            // 
            // idHos
            // 
            this.idHos.BackColor = System.Drawing.Color.DarkGray;
            this.idHos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idHos.Location = new System.Drawing.Point(132, 9);
            this.idHos.MaximumSize = new System.Drawing.Size(100, 50);
            this.idHos.Name = "idHos";
            this.idHos.Size = new System.Drawing.Size(10, 32);
            this.idHos.TabIndex = 131;
            this.idHos.Visible = false;
            // 
            // idZona
            // 
            this.idZona.BackColor = System.Drawing.Color.DarkGray;
            this.idZona.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idZona.Location = new System.Drawing.Point(152, 9);
            this.idZona.MaximumSize = new System.Drawing.Size(100, 50);
            this.idZona.Name = "idZona";
            this.idZona.Size = new System.Drawing.Size(10, 32);
            this.idZona.TabIndex = 132;
            this.idZona.Visible = false;
            // 
            // FrmReporteAsegurado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReporteAsegurado";
            this.Text = "FrmReporteAsegurado";
            this.Load += new System.EventHandler(this.FrmReporteAsegurado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_AseguradoPt1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataAsegurado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_AseguradoPt2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_AseguradoPt3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_AseguradoPt4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_AseguradoPt5BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_por_AseguradoPt1BindingSource;
        private DataAsegurado DataAsegurado;
        private System.Windows.Forms.BindingSource Reporte_por_AseguradoPt2BindingSource;
        private System.Windows.Forms.BindingSource Reporte_por_AseguradoPt3BindingSource;
        private DataAseguradoTableAdapters.Reporte_por_AseguradoPt1TableAdapter Reporte_por_AseguradoPt1TableAdapter;
        private DataAseguradoTableAdapters.Reporte_por_AseguradoPt2TableAdapter Reporte_por_AseguradoPt2TableAdapter;
        private DataAseguradoTableAdapters.Reporte_por_AseguradoPt3TableAdapter Reporte_por_AseguradoPt3TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtIdHospitalizacion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIdAsegurado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.BindingSource Reporte_por_AseguradoPt4BindingSource;
        private DataAseguradoTableAdapters.Reporte_por_AseguradoPt4TableAdapter Reporte_por_AseguradoPt4TableAdapter;
        private System.Windows.Forms.BindingSource Reporte_por_AseguradoPt5BindingSource;
        private DataAseguradoTableAdapters.Reporte_por_AseguradoPt5TableAdapter Reporte_por_AseguradoPt5TableAdapter;
        private System.Windows.Forms.Label idZona;
        private System.Windows.Forms.Label idHos;
    }
}