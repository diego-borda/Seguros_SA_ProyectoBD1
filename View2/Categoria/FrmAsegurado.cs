using Seguridad;
using SegurosSA.Controllers;
using SegurosSA.View.ViewServicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View2.Servicios;

namespace SegurosSA.View
{
    public partial class FrmAsegurado : Form
    {
        private bool IsEditar = false;
        private bool IsNuevo = false;
        public FrmAsegurado()
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
        private void FrmAsegurado_Load(object sender, EventArgs e)
        {
            Botones();
            Permisos();
            MostrarAsegurado();
            ttZona.SetToolTip(this.txtIdZona, "Haga doble click en este cuadro de texto para buscar Zona");
            //this.dt.Columns["Id Hospital"].Visible = false;
            //CambiarColorEstado();
            //Botones();
        }

        private void MostrarAsegurado()
        {
            this.dtAsegurado.DataSource = CAsegurado.MostrarAsegurado();

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
            this.txtIdZona.Enabled = valor;
            this.txtIdCategoria.Enabled = valor;
            this.txtPrimerNombre.ReadOnly = !valor;
            this.txtSegundoNombre.ReadOnly = !valor;
            this.txtPrimerApellido.ReadOnly = !valor;
            this.txtSegundoApellido.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtCelular.ReadOnly = !valor;
        }

        private void Limpiar()
        {
            this.txtIdZona.Text = string.Empty;
            this.txtIdCategoria.Text = string.Empty;
            this.txtPrimerNombre.Text = string.Empty;
            this.txtSegundoNombre.Text = string.Empty;
            this.txtPrimerApellido.Text = string.Empty;
            this.txtSegundoApellido.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtCelular.Text = string.Empty;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdCategoria.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.IsNuevo)
                {
                    rpta = CAsegurado.InsertarAsegurado(this.txtIdCategoria.SelectedItem.ToString(), (Convert.ToInt32(this.idZona.Text)), this.txtPrimerNombre.Text, this.txtSegundoNombre.Text, this.txtPrimerApellido.Text, this.txtSegundoApellido.Text, this.txtDireccion.Text, this.txtCelular.Text);                }
                else
                {
                    rpta = CAsegurado.EditarAsegurado(Convert.ToInt32(this.dtAsegurado.CurrentRow.Cells["ID"].Value),
                          this.txtIdCategoria.SelectedItem.ToString(), Convert.ToInt32(this.idZona.Text),
                        this.txtPrimerNombre.Text, this.txtSegundoNombre.Text, this.txtPrimerApellido.Text,
                        this.txtSegundoApellido.Text, this.txtDireccion.Text, this.txtCelular.Text);

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
                this.dtAsegurado.DataSource = CAsegurado.MostrarAsegurado();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtAsegurado.SelectedRows.Count == 1)
            {
                this.txtIdCategoria.Text = Convert.ToString(this.dtAsegurado.CurrentRow.Cells["Categoria"].Value);
                this.txtIdZona.Text = Convert.ToString(this.dtAsegurado.CurrentRow.Cells["Id Zona"].Value);
                this.txtPrimerNombre.Text = Convert.ToString(this.dtAsegurado.CurrentRow.Cells["PrimerNombre"].Value);
                this.txtSegundoNombre.Text = Convert.ToString(this.dtAsegurado.CurrentRow.Cells["SegundoNombre"].Value);
                this.txtPrimerApellido.Text = Convert.ToString(this.dtAsegurado.CurrentRow.Cells["PrimerApellido"].Value);
                this.txtSegundoApellido.Text = Convert.ToString(this.dtAsegurado.CurrentRow.Cells["SegundoApellido"].Value);
                this.txtDireccion.Text = Convert.ToString(this.dtAsegurado.CurrentRow.Cells["Direccion"].Value);
                this.txtCelular.Text = Convert.ToString(this.dtAsegurado.CurrentRow.Cells["Celular"].Value);

                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtIdCategoria.Focus();

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
            this.dtAsegurado.CurrentCell = null;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtAsegurado.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CAsegurado.EstadoAsegurado(Convert.ToInt32(this.dtAsegurado.CurrentRow.Cells["Id"].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.MostrarAsegurado();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtAsegurado.DataSource = CAsegurado.BuscarAsegurado(this.txtBuscar.Text);
        }


        private void dtAsegurado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtAsegurado.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (Convert.ToString(e.Value) == "Habilitado") {
                    e.CellStyle.ForeColor = Color.Green;

                }
                if (Convert.ToString(e.Value) != "Habilitado")
                {
                    e.CellStyle.ForeColor = Color.Red;

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtIdZona_DoubleClick(object sender, EventArgs e)
        {
            frmDialogZona fdh = new frmDialogZona();
            fdh.ShowDialog();
            if (fdh.DialogResult == DialogResult.OK)
            {
                idZona.Text = fdh.dtSZona.Rows[fdh.dtSZona.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtIdZona.Text = fdh.dtSZona.Rows[fdh.dtSZona.CurrentRow.Index].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Elija una Zona para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
