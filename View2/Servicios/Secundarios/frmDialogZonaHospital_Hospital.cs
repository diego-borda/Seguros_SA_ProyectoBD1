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
    public partial class frmDialogZonaHospital_Hospital : Form
    {
        public string categoria, zona;
        public frmDialogZonaHospital_Hospital(string categoria,string zona)
        {//
            InitializeComponent();
            this.categoria = categoria;
            this.zona=zona;
        }

        private void frmDialogZonaHospital_Hospital_Load(object sender, EventArgs e)
        {
            Mostrar();
            Habilitar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtSZona.DataSource = CZona_Hospital.Buscar_ZonayHospital2(this.txtBuscar.Text,zona);
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

        private void OtrosHosp_Click(object sender, EventArgs e)
        {// por si acaso no hay un hospital de la misma zona que el asegurado o que este dehabilitada esa zona :(
            // mandar a llamar el mostrar hospitales
           
                this.dtSZona.DataSource= CHospital.MostrarHospital();
            ((DataTable)dtSZona.DataSource).DefaultView.RowFilter = "Estado = 'Habilitado'";
        }

        public void Mostrar()
        {
            if (categoria.Equals("AC2"))
            {
                this.dtSZona.DataSource = CZona_Hospital.Buscar_ZonayHospital(zona);
                ((DataTable)dtSZona.DataSource).DefaultView.RowFilter = "Tipo = 'Propio'";
            }
            else
            {
                this.dtSZona.DataSource = CZona_Hospital.Buscar_ZonayHospital(zona);
            }
        }

        public void Habilitar()
        {
            if (this.dtSZona.Rows.Count == 1)
            {
                this.OtrosHosp.Enabled = false;
            }
            else
            {
                this.OtrosHosp.Enabled = true;
            }
        }
    }
}
