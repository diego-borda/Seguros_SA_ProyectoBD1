
namespace View2.Reportes.RecaudacionConsultas
{
    partial class FrmReporteConsulta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataConsultas = new View2.Reportes.RecaudacionConsultas.DataConsultas();
            this.Reporte_por_ConsultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_por_ConsultasTableAdapter = new View2.Reportes.RecaudacionConsultas.DataConsultasTableAdapters.Reporte_por_ConsultasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_ConsultasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Reporte_por_ConsultasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "View2.Reportes.RecaudacionConsultas.RConsultas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataConsultas
            // 
            this.DataConsultas.DataSetName = "DataConsultas";
            this.DataConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_por_ConsultasBindingSource
            // 
            this.Reporte_por_ConsultasBindingSource.DataMember = "Reporte_por_Consultas";
            this.Reporte_por_ConsultasBindingSource.DataSource = this.DataConsultas;
            // 
            // Reporte_por_ConsultasTableAdapter
            // 
            this.Reporte_por_ConsultasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteConsulta";
            this.Text = "FrmReporteConsulta";
            this.Load += new System.EventHandler(this.FrmReporteConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_ConsultasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_por_ConsultasBindingSource;
        private DataConsultas DataConsultas;
        private DataConsultasTableAdapters.Reporte_por_ConsultasTableAdapter Reporte_por_ConsultasTableAdapter;
    }
}