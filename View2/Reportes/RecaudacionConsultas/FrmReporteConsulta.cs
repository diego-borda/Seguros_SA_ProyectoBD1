using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View2.Reportes.RecaudacionConsultas
{
    public partial class FrmReporteConsulta : Form
    {
        public FrmReporteConsulta()
        {
            InitializeComponent();
        }

        private void FrmReporteConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataConsultas.Reporte_por_Consultas' Puede moverla o quitarla según sea necesario.
            this.Reporte_por_ConsultasTableAdapter.Fill(this.DataConsultas.Reporte_por_Consultas);

            this.reportViewer1.RefreshReport();
        }
    }
}
