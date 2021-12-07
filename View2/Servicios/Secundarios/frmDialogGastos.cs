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
    public partial class frmDialogGastos : Form
    {
        public frmDialogGastos()
        {
            InitializeComponent();
        }

        private void frmDialogGastos_Load(object sender, EventArgs e)
        {
            this.dtGasto.DataSource = CGastos.MostrarGasto();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dtGasto.DataSource = CGastos.BuscarGasto(this.txtBuscar.Text);
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            if(this.dtGasto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
