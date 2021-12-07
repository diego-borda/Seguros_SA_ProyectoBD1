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
    public partial class frmDialogAsegurado : Form
    {
        public frmDialogAsegurado()
        {
            InitializeComponent();
        }


        private void frmDialog_Load(object sender, EventArgs e)
        {
            this.dtAsegu.DataSource = CAsegurado.MostrarAsegurado();
            Ocultos();
        }

        public void Ocultos()
        {
            for (int i = 1; i < dtAsegu.RowCount; i++)
            {
                if (this.dtAsegu.Rows[i].Cells["Estado"].Value.ToString() == "Deshabilitado")
                {
                    this.dtAsegu.Rows[i].Visible = false;
                }
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dtAsegu.DataSource = CHospital.BuscarHospital(this.txtBuscar.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtAsegu.Rows.Count == 0)
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
