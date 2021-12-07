
namespace View2.Reportes.RecaudacionHospitalizacion
{
    partial class FrmRHospitalizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRHospitalizacion));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Recaudacion_por_HospitalizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SetHospitalizacion = new View2.Reportes.RecaudacionHospitalizacion.SetHospitalizacion();
            this.Recaudacion_por_HospitalizacionTableAdapter = new View2.Reportes.RecaudacionHospitalizacion.SetHospitalizacionTableAdapters.Recaudacion_por_HospitalizacionTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIdHospitalizacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Mostrar_DetalleHospitalizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Mostrar_DetalleHospitalizacionTableAdapter = new View2.Reportes.RecaudacionHospitalizacion.SetHospitalizacionTableAdapters.Mostrar_DetalleHospitalizacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Recaudacion_por_HospitalizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetHospitalizacion)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_DetalleHospitalizacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Recaudacion_por_HospitalizacionBindingSource
            // 
            this.Recaudacion_por_HospitalizacionBindingSource.DataMember = "Recaudacion_por_Hospitalizacion";
            this.Recaudacion_por_HospitalizacionBindingSource.DataSource = this.SetHospitalizacion;
            // 
            // SetHospitalizacion
            // 
            this.SetHospitalizacion.DataSetName = "SetHospitalizacion";
            this.SetHospitalizacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Recaudacion_por_HospitalizacionTableAdapter
            // 
            this.Recaudacion_por_HospitalizacionTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 375);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtIdHospitalizacion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 75);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(158, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 1);
            this.panel4.TabIndex = 18;
            // 
            // txtIdHospitalizacion
            // 
            this.txtIdHospitalizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(121)))));
            this.txtIdHospitalizacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdHospitalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdHospitalizacion.ForeColor = System.Drawing.SystemColors.Control;
            this.txtIdHospitalizacion.Location = new System.Drawing.Point(158, 24);
            this.txtIdHospitalizacion.Name = "txtIdHospitalizacion";
            this.txtIdHospitalizacion.Size = new System.Drawing.Size(282, 19);
            this.txtIdHospitalizacion.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID Hospitalización";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(479, 14);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(63, 42);
            this.btnAceptar.TabIndex = 102;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Recaudacion_por_HospitalizacionBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.Mostrar_DetalleHospitalizacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "View2.Reportes.RecaudacionHospitalizacion.RHospitalizacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 375);
            this.reportViewer1.TabIndex = 0;
            // 
            // Mostrar_DetalleHospitalizacionBindingSource
            // 
            this.Mostrar_DetalleHospitalizacionBindingSource.DataMember = "Mostrar_DetalleHospitalizacion";
            this.Mostrar_DetalleHospitalizacionBindingSource.DataSource = this.SetHospitalizacion;
            // 
            // Mostrar_DetalleHospitalizacionTableAdapter
            // 
            this.Mostrar_DetalleHospitalizacionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRHospitalizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmRHospitalizacion";
            this.Text = "FrmRHospitalizacion";
            this.Load += new System.EventHandler(this.FrmRHospitalizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Recaudacion_por_HospitalizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetHospitalizacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_DetalleHospitalizacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Recaudacion_por_HospitalizacionBindingSource;
        private SetHospitalizacion SetHospitalizacion;
        private SetHospitalizacionTableAdapters.Recaudacion_por_HospitalizacionTableAdapter Recaudacion_por_HospitalizacionTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIdHospitalizacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Mostrar_DetalleHospitalizacionBindingSource;
        private SetHospitalizacionTableAdapters.Mostrar_DetalleHospitalizacionTableAdapter Mostrar_DetalleHospitalizacionTableAdapter;
    }
}