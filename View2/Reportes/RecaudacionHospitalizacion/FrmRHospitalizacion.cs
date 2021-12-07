using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View2.Reportes.RecaudacionHospitalizacion
{
    public partial class FrmRHospitalizacion : Form
    {
        public FrmRHospitalizacion()
        {
            InitializeComponent();
        }

        private void FrmRHospitalizacion_Load(object sender, EventArgs e)
        {
            this.Recaudacion_por_HospitalizacionTableAdapter.Fill(this.SetHospitalizacion.Recaudacion_por_Hospitalizacion);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SetHospitalizacion.Mostrar_DetalleHospitalizacion' Puede moverla o quitarla según sea necesario.
            this.Mostrar_DetalleHospitalizacionTableAdapter.Fill(this.SetHospitalizacion.Mostrar_DetalleHospitalizacion, int.Parse(this.txtIdHospitalizacion.Text));
            // TODO: esta línea de código carga datos en la tabla 'SetHospitalizacion.Recaudacion_por_Hospitalizacion' Puede moverla o quitarla según sea necesario.
            //this.Recaudacion_por_HospitalizacionTableAdapter.Fill(this.SetHospitalizacion.Recaudacion_por_Hospitalizacion);

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
