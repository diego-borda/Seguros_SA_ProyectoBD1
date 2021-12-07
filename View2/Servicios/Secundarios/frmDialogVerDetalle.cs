using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View2.Servicios
{
    public partial class frmDialogVerDetalle : Form
    {
        public int idhosp;

        public frmDialogVerDetalle(int idHospitalizacion)
        {
            InitializeComponent();
            this.idhosp = idHospitalizacion;
        }
        private void frmDialogVerDetalle_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtDetalle.DataSource = CDetalleHospitalizacion.BuscarDetalleHosp(idhosp, this.txtBuscar.Text);
        }

        private void Mostrar()
        {
            this.dtDetalle.DataSource = CDetalleHospitalizacion.MostrarDetallesHosp(idhosp);
            this.dtDetalle.CurrentCell = null;
            this.dtDetalle.Columns[1].Visible = false;
            this.dtDetalle.Columns[2].Visible = false;
        }
    }
}
