
namespace View2.Reportes.RecaudacionPoliza
{
    partial class FrmReportePoliza
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Reporte_por_TipoPolizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataPoliza = new View2.Reportes.RecaudacionPoliza.DataPoliza();
            this.Reporte_por_TipoPolizaTableAdapter = new View2.Reportes.RecaudacionPoliza.DataPolizaTableAdapters.Reporte_por_TipoPolizaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_por_ContratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_por_ContratoTableAdapter = new View2.Reportes.RecaudacionPoliza.DataPolizaTableAdapters.Reporte_por_ContratoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_TipoPolizaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_ContratoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Reporte_por_TipoPolizaBindingSource
            // 
            this.Reporte_por_TipoPolizaBindingSource.DataMember = "Reporte_por_TipoPoliza";
            this.Reporte_por_TipoPolizaBindingSource.DataSource = this.DataPoliza;
            // 
            // DataPoliza
            // 
            this.DataPoliza.DataSetName = "DataPoliza";
            this.DataPoliza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_por_TipoPolizaTableAdapter
            // 
            this.Reporte_por_TipoPolizaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataPoliza";
            reportDataSource1.Value = this.Reporte_por_TipoPolizaBindingSource;
            reportDataSource2.Name = "DataContrato";
            reportDataSource2.Value = this.Reporte_por_ContratoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "View2.Reportes.RecaudacionPoliza.RPoliza.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reporte_por_ContratoBindingSource
            // 
            this.Reporte_por_ContratoBindingSource.DataMember = "Reporte_por_Contrato";
            this.Reporte_por_ContratoBindingSource.DataSource = this.DataPoliza;
            // 
            // Reporte_por_ContratoTableAdapter
            // 
            this.Reporte_por_ContratoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportePoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportePoliza";
            this.Text = "FrmReportePoliza";
            this.Load += new System.EventHandler(this.FrmReportePoliza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_TipoPolizaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_por_ContratoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Reporte_por_TipoPolizaBindingSource;
        private DataPoliza DataPoliza;
        private DataPolizaTableAdapters.Reporte_por_TipoPolizaTableAdapter Reporte_por_TipoPolizaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_por_ContratoBindingSource;
        private DataPolizaTableAdapters.Reporte_por_ContratoTableAdapter Reporte_por_ContratoTableAdapter;
    }
}