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
    public partial class FrmHospital : Form
    {

        private bool IsEditar = false;
        private bool IsNuevo = false;
        public FrmHospital()
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
                btnEstado.Enabled = false;
            }
            if (CaUsuario.Rol == CaRoles.GerenteAsegurador)
            {
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEstado.Enabled = false;
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
                this.btnEstado.Enabled = false;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnEstado.Enabled = true;
            }

        }

        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtTipo.Enabled = valor;
            this.txtDepartamentos.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
        
        }

        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtTipo.Text = string.Empty;
            this.txtDepartamentos.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
        

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtNombre.Focus();
        }


        private void MostrarHospital()
        {
            this.dtHospital.DataSource = CHospital.MostrarHospital();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                DataTable dato;


                if (this.IsNuevo)
                {
                dato = CHospital.ValidarHospital(this.txtNombre.Text);
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "Nombre existe")
                        {
                            this.txtTipo.Focus();
                        }
                        rpta = "Nombre de Hospital ya existe";

                    }
                    else
                    {
                        rpta = CHospital.InsertarHospital(this.txtNombre.Text,this.txtTipo.Text, Convert.ToInt32(this.txtDepartamentos.Text),this.txtDireccion.Text,txtTelefono.Text);
                        //this.txtUsuario.Text = string.Empty;
                        //this.txtContraseña.Text = string.Empty;
                        //this.txtUsuario.Focus();
                    }

                }else
                {

                    
                        rpta = CHospital.EditarHospital(Convert.ToInt32(dtHospital.CurrentRow.Cells[0].Value),txtNombre.Text,txtTipo.Text,
                            Convert.ToInt32(txtDepartamentos.Text),txtDireccion.Text,txtTelefono.Text);

                        //this.txtUsuario.Text = string.Empty;
                        //this.txtContraseña.Text = string.Empty;
                        //this.txtUsuario.Focus();
                    

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
                this.dtHospital.DataSource = CHospital.MostrarHospital();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtHospital.SelectedRows.Count == 1)
            {
                this.txtNombre.Text = Convert.ToString(this.dtHospital.CurrentRow.Cells["NombreHospital"].Value);
                this.txtTipo.Text = Convert.ToString(this.dtHospital.CurrentRow.Cells["Tipo"].Value);
                this.txtDepartamentos.Text = Convert.ToString(this.dtHospital.CurrentRow.Cells["No Deptos"].Value);
                this.txtDireccion.Text = Convert.ToString(this.dtHospital.CurrentRow.Cells["Direccion"].Value);
                this.txtTelefono.Text = Convert.ToString(this.dtHospital.CurrentRow.Cells["Telefono"].Value);

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
            this.dtHospital.CurrentCell = null;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtHospital.DataSource = CHospital.BuscarHospital(this.txtBuscar.Text);
        }

        private void FrmHospital_Load_1(object sender, EventArgs e)
        {
            Botones();
            Permisos();
            MostrarHospital();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtHospital.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CHospital.EstadoHospital(Convert.ToInt32(this.dtHospital.CurrentRow.Cells["Id"].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.MostrarHospital();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtHospital_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtHospital.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (Convert.ToString(e.Value) == "Habilitado")
                {
                    e.CellStyle.ForeColor = Color.Green;

                }
                if (Convert.ToString(e.Value) != "Habilitado")
                {
                    e.CellStyle.ForeColor = Color.Red;

                }
            }
        }
    }
}
