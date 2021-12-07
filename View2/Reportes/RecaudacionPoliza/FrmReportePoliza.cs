using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View2.Reportes.RecaudacionPoliza
{
    public partial class FrmReportePoliza : Form
    {
        public FrmReportePoliza()
        {
            InitializeComponent();
        }

        private void FrmReportePoliza_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataPoliza.Reporte_por_TipoPoliza' Puede moverla o quitarla según sea necesario.
            this.Reporte_por_TipoPolizaTableAdapter.Fill(this.DataPoliza.Reporte_por_TipoPoliza);
            // TODO: esta línea de código carga datos en la tabla 'DataPoliza.Reporte_por_Contrato' Puede moverla o quitarla según sea necesario.
            this.Reporte_por_ContratoTableAdapter.Fill(this.DataPoliza.Reporte_por_Contrato);

            this.reportViewer1.RefreshReport();
        }
    }
}
