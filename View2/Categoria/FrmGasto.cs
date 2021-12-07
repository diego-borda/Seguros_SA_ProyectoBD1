using Seguridad;
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

namespace SegurosSA.View
{
    public partial class FrmGasto : Form
    {
        private bool IsEditar = false;
        private bool IsNuevo = false;
        public FrmGasto()
        {
            InitializeComponent();
            
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
            this.txtNombre.ReadOnly = !valor;
            this.txtCosto.ReadOnly = !valor;
       
        }

        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtCosto.Text = string.Empty;
      

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtNombre.Focus();
        }

        private void FrmGasto_Load(object sender, EventArgs e)
        {
            Botones();
            Permisos();
            MostrarGasto();
            //this.dt.Columns["Id Hospital"].Visible = false;
            //CambiarColorEstado();
            //Botones();
        }

        private void MostrarGasto()
        {
            this.dtGasto.DataSource = CGastos.MostrarGasto();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                DataTable dato;



                if (this.IsNuevo)
                {
                    dato = CGastos.ValidarGasto(this.txtNombre.Text);
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "Gasto existe")
                        {
                            this.txtNombre.Focus();
                        }
                        rpta = "Nombre de gasto ya existe";

                    }
                    else
                    {
                        rpta=CGastos.InsertarGasto(this.txtNombre.Text, (float)Convert.ToDecimal(this.txtCosto.Text));
                        //this.txtUsuario.Text = string.Empty;
                        //this.txtContraseña.Text = string.Empty;
                        //this.txtUsuario.Focus();
                    }

                }

                else
                {
                    dato = CGastos.ValidarGastoEditar(Convert.ToInt32(this.dtGasto.CurrentRow.Cells["ID"].Value), this.txtNombre.Text);
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "Gasto existe")
                        {
                            this.txtNombre.Focus();
                        }
                        rpta = "Nombre de gasto ya existe";

                    }else
                    rpta = CGastos.EditarGasto(Convert.ToInt32(this.dtGasto.CurrentRow.Cells["ID"].Value),
                           this.txtNombre.Text, (float)(Convert.ToDecimal(this.txtCosto.Text)));

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
                this.dtGasto.DataSource = CGastos.MostrarGasto();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtGasto.SelectedRows.Count == 1)
            {
                this.txtNombre.Text = Convert.ToString(this.dtGasto.CurrentRow.Cells["Nombre"].Value);
                this.txtCosto.Text = Convert.ToString(this.dtGasto.CurrentRow.Cells["Costo"].Value);
               
                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtNombre.Focus();

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
            this.dtGasto.CurrentCell = null;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtGasto.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CGastos.EstadoGasto(Convert.ToInt32(this.dtGasto.CurrentRow.Cells["IdAsegurado"].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.MostrarGasto();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtGasto.DataSource = CGastos.BuscarGasto(this.txtBuscar.Text);
        }

    }

}
