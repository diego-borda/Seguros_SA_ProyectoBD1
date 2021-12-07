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
    public partial class frmDialogContrato : Form
    {
        public frmDialogContrato()
        {
            InitializeComponent();
        }

        private void frmDialog_Load(object sender, EventArgs e)
        {
            this.dtCon.DataSource = CContrato.MostrarContratos();
            Ocultos();
        }

        public void Ocultos()
        {
            for (int i = 1; i < dtCon.RowCount; i++)
            {
                if (this.dtCon.Rows[i].Cells["Estado"].Value.ToString() == "Deshabilitado")
                {
                    this.dtCon.Rows[i].Visible = false;
                }
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dtCon.DataSource = CContrato.BuscarContrato(this.txtBuscar.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtCon.Rows.Count == 0)
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
