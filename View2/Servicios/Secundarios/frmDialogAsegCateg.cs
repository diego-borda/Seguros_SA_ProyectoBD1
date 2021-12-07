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
    public partial class frmDialogAsegCateg : Form
    {
        public frmDialogAsegCateg()
        {
            InitializeComponent();
        }

        private void frmDialogAsegCateg_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtAsegCateg.DataSource = CContrato.BuscarContrato(this.txtBuscar.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtAsegCateg.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public void Mostrar()
        {
            this.dtAsegCateg.DataSource = CContrato.MostrarContratosCategoria();
            this.dtAsegCateg.Columns[1].Visible = false;
            this.dtAsegCateg.Columns[2].Visible = false;
        }
    }
}
