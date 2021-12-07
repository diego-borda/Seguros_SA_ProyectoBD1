using SegurosSA.Controllers;
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
    public partial class frmDialogPoliza : Form
    {
        public frmDialogPoliza()
        {
            InitializeComponent();
        }

        private void frmDialogPoliza_Load(object sender, EventArgs e)
        {
            this.dtPoliza.DataSource = CPoliza.MostrarPoliza();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtPoliza.DataSource = CPoliza.BuscarPoliza(this.txtBuscar.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtPoliza.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
