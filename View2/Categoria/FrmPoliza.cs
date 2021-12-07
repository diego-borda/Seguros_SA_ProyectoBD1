using Seguridad;
using SegurosSA.Controllers;
using SegurosSA.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegurosSA.View
{
    public partial class FrmPoliza : Form
    {
        public FrmPoliza()
        {
            InitializeComponent();
            Permisos();
        }
        private void Permisos()
        {
            if (CaUsuario.Rol == CaRoles.GerenteHospital)
            {
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            if (CaUsuario.Rol == CaRoles.GerenteAsegurador)
            {
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }

        }

        private bool IsEditar = false;
        private bool IsNuevo = false;
       
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnModificar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }

        private void Habilitar(bool valor)
        {
            this.txtTipo.ReadOnly = !valor;
            this.txtCosto.ReadOnly = !valor;

        }

        private void Limpiar()
        {
            this.txtTipo.Text = string.Empty;
            this.txtCosto.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtCosto.Focus();
        }

        private void FrmPoliza_Load(object sender, EventArgs e)
        {
            Botones();
            Permisos();
            MostrarPoliza();
            //this.dt.Columns["Id Hospital"].Visible = false;
            //CambiarColorEstado();
            //Botones();
        }

        private void MostrarPoliza()
        {
            this.dtPoliza.DataSource = CPoliza.MostrarPoliza();

        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                DataTable dato;

                if (this.IsNuevo)
                {
                    dato = CPoliza.ValidarPoliza(this.txtTipo.Text);
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "Tipo existe")
                        {
                            this.txtCosto.Focus();
                        }
                        rpta = "Nombre de Tipo ya existe";

                    }
                    else
                    {
                        rpta = CPoliza.InsertarPoliza(this.txtTipo.Text, (float)Convert.ToDecimal(this.txtCosto.Text));
                        //this.txtUsuario.Text = string.Empty;
                        //this.txtContraseña.Text = string.Empty;
                        //this.txtUsuario.Focus();
                    }

                }
                else
                {
                    dato = CPoliza.ValidarPolizaEditar(Convert.ToInt32(this.dtPoliza.CurrentRow.Cells["ID"].Value),this.txtTipo.Text);
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "Tipo existe")
                        {
                            this.txtCosto.Focus();
                        }
                        rpta = "Nombre de Tipo ya existe";

                    }
                    else
                        rpta = CPoliza.EditarPoliza(Convert.ToInt32(this.dtPoliza.CurrentRow.Cells["ID"].Value),
                               this.txtTipo.Text, (float)(Convert.ToDecimal(this.txtCosto.Text)));

                }

                if (rpta.Equals("OK"))
                {
                    if (this.IsNuevo)
                    {

                        MessageBox.Show("Datos Ingresados", "Sistema de Seguros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datos Actualizados", "Sistema de Seguros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show(rpta, "Sistema de Seguros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                this.dtPoliza.DataSource = DPoliza.MostrarPoliza();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtPoliza.SelectedRows.Count == 1)
            {
                this.txtTipo.Text = Convert.ToString(this.dtPoliza.CurrentRow.Cells["Tipo"].Value);
                this.txtCosto.Text = Convert.ToString(this.dtPoliza.CurrentRow.Cells["Costo"].Value);

                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtCosto.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Modificar", "Sistema de Seguros", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.dtPoliza.CurrentCell = null;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtPoliza.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CGastos.EstadoGasto(Convert.ToInt32(this.dtPoliza.CurrentRow.Cells["IdPoliza"].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.MostrarPoliza();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtPoliza.DataSource = CPoliza.BuscarPoliza(this.txtBuscar.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
