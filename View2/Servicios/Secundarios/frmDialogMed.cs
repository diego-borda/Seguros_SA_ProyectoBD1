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

namespace SegurosSA.View.ViewServicios
{
    public partial class frmDialogMed : Form
    {
        public string s;
        public frmDialogMed(string s)
        {
            InitializeComponent();
            this.s = s;
        }
        private void frmDialogMed_Load(object sender, EventArgs e)
        {
            this.dtMedico.DataSource = CMedico.BuscarMedico(s);
            Ocultos();
        }


        private void Ocultos()
        {
            ((DataTable)dtMedico.DataSource).DefaultView.RowFilter = "Estado = 'Habilitado'";
            this.dtMedico.Columns[1].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtMedico.DataSource = CMedico.BuscarMedico2(s,this.txtBuscar.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtMedico.Rows.Count == 0)
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
