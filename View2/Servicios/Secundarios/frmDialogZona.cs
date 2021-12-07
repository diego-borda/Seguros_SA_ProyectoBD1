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
    public partial class frmDialogZona : Form
    {
        public string s;
        public frmDialogZona()
        {
            InitializeComponent();
            this.s = s;
        }
        private void frmDialogMed_Load(object sender, EventArgs e)
        {
            this.dtSZona.DataSource = CZona.MostrarZona();
            Ocultos();
        }


        private void Ocultos()
        {
            for (int i = 1; i < dtSZona.RowCount; i++)
            {
                if (this.dtSZona.Rows[i].Cells["Estado"].Value.ToString() == "Deshabilitado")
                {
                    this.dtSZona.Rows[i].Visible = false;
                }
            }
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtSZona.DataSource = CMedico.BuscarMedico(this.txtBuscar.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtSZona.Rows.Count == 0)
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
