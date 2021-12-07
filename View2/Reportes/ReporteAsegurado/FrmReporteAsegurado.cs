using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View2.Servicios;

namespace View2.Reportes.ReporteAsegurado
{
    public partial class FrmReporteAsegurado : Form
    {
        public FrmReporteAsegurado()
        {
            InitializeComponent();
        }

        private void FrmReporteAsegurado_Load(object sender, EventArgs e)
        {
         
            //this.reportViewer1.RefreshReport();
            this.pnlControl.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Reporte_por_AseguradoPt1TableAdapter.Fill(this.DataAsegurado.Reporte_por_AseguradoPt1, this.txtIdAsegurado.Text);
            // TODO: esta línea de código carga datos en la tabla 'DataAsegurado.Reporte_por_AseguradoPt2' Puede moverla o quitarla según sea necesario.
            this.Reporte_por_AseguradoPt2TableAdapter.Fill(this.DataAsegurado.Reporte_por_AseguradoPt2, int.Parse(this.txtContrato.Text), int.Parse(this.txtIdAsegurado.Text));

            // TODO: esta línea de código carga datos en la tabla 'DataAsegurado.Reporte_por_AseguradoPt3' Puede moverla o quitarla según sea necesario.
            this.Reporte_por_AseguradoPt3TableAdapter.Fill(this.DataAsegurado.Reporte_por_AseguradoPt3, int.Parse(this.txtContrato.Text), int.Parse(this.txtIdAsegurado.Text));
            // TODO: esta línea de código carga datos en la tabla 'DataAsegurado.Reporte_por_AseguradoPt4' Puede moverla o quitarla según sea necesario.
            this.Reporte_por_AseguradoPt4TableAdapter.Fill(this.DataAsegurado.Reporte_por_AseguradoPt4, int.Parse(this.txtContrato.Text), int.Parse(this.txtIdAsegurado.Text));
            //this.Reporte_por_AseguradoPt5TableAdapter.Fill(this.DataAsegurado.Reporte_por_AseguradoPt5, int.Parse(this.txtContrato.Text), int.Parse(this.txtIdHospitalizacion.Text));
            this.reportViewer1.RefreshReport();
            this.pnlControl.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataAsegurado.Reporte_por_AseguradoPt5' Puede moverla o quitarla según sea necesario.
            this.Reporte_por_AseguradoPt5TableAdapter.Fill(this.DataAsegurado.Reporte_por_AseguradoPt5, int.Parse(this.txtIdHospitalizacion.Text), int.Parse(this.txtContrato.Text));

            this.reportViewer1.RefreshReport();
            this.panel1.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContrato.Clear();
            txtIdAsegurado.Clear();
            txtIdHospitalizacion.Clear();
        }

        private void txtIdAsegurado_DoubleClick(object sender, EventArgs e)
        {
            frmDialogAsegurado fda = new frmDialogAsegurado();
            fda.ShowDialog();
            if (fda.DialogResult == DialogResult.OK)
            {
                idHos.Text = fda.dtAsegu.Rows[fda.dtAsegu.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtIdAsegurado.Text = fda.dtAsegu.Rows[fda.dtAsegu.CurrentRow.Index].Cells[0].Value.ToString();
            }
            else
            
                MessageBox.Show("Elija un Asegurado para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void txtContrato_DoubleClick(object sender, EventArgs e)
        {
            frmDialogContrato fda = new frmDialogContrato();
            fda.ShowDialog();
            if (fda.DialogResult == DialogResult.OK)
            {
                idHos.Text = fda.dtCon.Rows[fda.dtCon.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtContrato.Text = fda.dtCon.Rows[fda.dtCon.CurrentRow.Index].Cells[0].Value.ToString();
            }
            else

                MessageBox.Show("Elija un Asegurado para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

        
    

