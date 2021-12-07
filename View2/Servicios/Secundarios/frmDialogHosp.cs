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
    public partial class frmDialogHosp : Form
    {
        public bool b;
        public frmDialogHosp(bool b )
        {
            InitializeComponent();
            this.b = b;
        }
        
        private void frmDialog_Load(object sender, EventArgs e)
        {
            if (b == true)
            {
                 this.dtHosp.DataSource = CHospital.MostrarHospital();
                ((DataTable)dtHosp.DataSource).DefaultView.RowFilter = "Tipo = 'Concertado'";
            }
            else
            {
                this.dtHosp.DataSource = CHospital.MostrarHospital();
            }
            Ocultos();
        }

        public void Ocultos()
        {
            //for (int i = 0; i < dtHosp.RowCount; i++)
            //{
            //    if (this.dtHosp.Rows[i].Cells["Estado"].Value.ToString() == "Deshabilitado")
            //    {
            //        this.dtHosp.Rows[i].Visible = false;
            //    }
            //}
            ((DataTable)dtHosp.DataSource).DefaultView.RowFilter = "Estado = 'Habilitado'";
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dtHosp.DataSource = CHospital.BuscarHospital(this.txtBuscar.Text);
            Ocultos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.dtHosp.Rows.Count == 0)
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
