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

namespace View2.Seguridad
{
    public partial class FrmSeguridad : Form
    {
        public FrmSeguridad()
        {
            InitializeComponent();
        }

        private bool IsEditar = false;
        private bool IsNuevo = false;
      
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
            this.txtUsuario.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtBuscar.ReadOnly = !valor;
            this.txtEmail.ReadOnly = !valor;
            this.cmbRol.Enabled = valor;

        }

        private void Limpiar()
        {
            this.txtUsuario.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.cmbRol.SelectedIndex = 0;
        }

        public void MostrarUsuario()
        {
            this.dtUsuario.DataSource = CUsuario.MostrarUsuario();

        }

        private void FrmSeguridad_Load(object sender, EventArgs e)
        {
            Botones();
            MostrarUsuario();
            this.dtUsuario.Columns["Contraseña"].Visible = false;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtUsuario.Focus();
            this.txtNombre.ReadOnly = false;
            this.txtApellido.ReadOnly = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                DataTable dato;


                if (this.IsNuevo)
                {
                    dato = CUsuario.ValidarUsuario(this.txtUsuario.Text);
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "Nombre no valido")
                        {
                            this.txtNombre.Focus();
                        }
                        rpta = "Nombre de Usuario ya existe";

                    }
                    else
                    {
                        rpta = CUsuario.InsertarUsuario(this.txtUsuario.Text, this.txtContraseña.Text, this.txtNombre.Text, this.txtApellido.Text ,this.txtEmail.Text, this.cmbRol.SelectedItem.ToString());
                        //this.txtUsuario.Text = string.Empty;
                        //this.txtContraseña.Text = string.Empty;
                        //this.txtUsuario.Focus();
                    }

                }
                else
                {
                    

                    rpta = CUsuario.EditarUsuarioAdmin(Convert.ToInt32(dtUsuario.CurrentRow.Cells[0].Value), txtUsuario.Text,
                         txtEmail.Text, cmbRol.SelectedItem.ToString());

                    //this.txtUsuario.Text = string.Empty;
                    //this.txtContraseña.Text = string.Empty;
                    //this.txtUsuario.Focus();


                }

                if (rpta.Equals("OK"))
                {
                    if (this.IsNuevo)
                    {

                        MessageBox.Show("Datos Ingresados", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datos Actualizados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show(rpta, " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                this.dtUsuario.DataSource = CUsuario.MostrarUsuario();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtContraseña.Enabled = false;

            if (this.dtUsuario.SelectedRows.Count == 1)
            {
                this.txtUsuario.Text = Convert.ToString(this.dtUsuario.CurrentRow.Cells["Nombre de usuario"].Value);
                this.txtEmail.Text = Convert.ToString(this.dtUsuario.CurrentRow.Cells["Email"].Value);
                this.cmbRol.SelectedItem = Convert.ToString(this.dtUsuario.CurrentRow.Cells["Rol"].Value);
          
                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtUsuario.Focus();
              

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Modificar", "Sistema de Seguros", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtUsuario.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CUsuario.EstadoUsuario(Convert.ToInt32(this.dtUsuario.CurrentRow.Cells["ID"].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.MostrarUsuario();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.dtUsuario.CurrentCell = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtUsuario.DataSource = CUsuario.BuscarUsuario(this.txtBuscar.Text);
        }

        private void dtHospital_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtUsuario.Columns[e.ColumnIndex].Name == "Estado")
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
