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

namespace SegurosSA.View
{
    public partial class FrmMedico : Form
    {
        private bool IsEditar = false;
        private bool IsNuevo = false;
        public FrmMedico()
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

        private void FrmMedico_Load(object sender, EventArgs e)
        {
            MostrarMedico();
            this.ttHospital.SetToolTip(this.txtIdHospital, "Haga doble click en este cuadro de texto para buscar Hospital");
            this.dtMedico.Columns["Id Hospital"].Visible = false;
            //CambiarColorEstado();
            Botones();
            Permisos();
        }
        public void MostrarMedico()
        {
            this.dtMedico.DataSource = CMedico.MostrarMedico();

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
            this.txtIdHospital.Enabled = valor;
            this.txtPrimerNombre.ReadOnly = !valor;
            this.txtSegundoNombre.ReadOnly = !valor;
            this.txtPrimerApellido.ReadOnly = !valor;
            this.txtSegundoApellido.ReadOnly = !valor;
            this.txtEspecialidad.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
        }

        private void Limpiar()
        {
            this.txtIdHospital.Text = string.Empty;
            this.txtPrimerNombre.Text = string.Empty;
            this.txtSegundoNombre.Text = string.Empty;
            this.txtPrimerApellido.Text = string.Empty;
            this.txtSegundoApellido.Text = string.Empty;
            this.txtEspecialidad.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdHospital.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.IsNuevo)
                {
                    rpta = CMedico.InsertarMedico(Convert.ToInt32(this.hospital.Text), this.txtPrimerNombre.Text, this.txtSegundoNombre.Text, this.txtPrimerApellido.Text, this.txtSegundoApellido.Text, this.txtEspecialidad.Text, this.txtTelefono.Text);

                }
                else
                {
                    rpta = CMedico.EditarMedico(Convert.ToInt32(this.dtMedico.CurrentRow.Cells["IdMedico"].Value),
                             Convert.ToInt32(this.hospital.Text),
                        this.txtPrimerNombre.Text, this.txtSegundoNombre.Text, this.txtPrimerApellido.Text,
                        this.txtSegundoApellido.Text, this.txtEspecialidad.Text, this.txtTelefono.Text);

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
                this.dtMedico.DataSource = CMedico.MostrarMedico();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtMedico.SelectedRows.Count == 1)
            {
                this.hospital.Text= Convert.ToString(this.dtMedico.CurrentRow.Cells[1].Value);
                this.txtIdHospital.Text = Convert.ToString(this.dtMedico.CurrentRow.Cells["Nombre Hospital"].Value);
                this.txtPrimerNombre.Text = Convert.ToString(this.dtMedico.CurrentRow.Cells["Primer Nombre"].Value);
                this.txtSegundoNombre.Text = Convert.ToString(this.dtMedico.CurrentRow.Cells["Segundo Nombre"].Value);
                this.txtPrimerApellido.Text = Convert.ToString(this.dtMedico.CurrentRow.Cells["Primer Apellido"].Value);
                this.txtSegundoApellido.Text = Convert.ToString(this.dtMedico.CurrentRow.Cells["Segundo Apellido"].Value);
                this.txtEspecialidad.Text = Convert.ToString(this.dtMedico.CurrentRow.Cells["Especialidad"].Value);
                this.txtTelefono.Text = Convert.ToString(this.dtMedico.CurrentRow.Cells["Teléfono"].Value);

                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtPrimerNombre.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Modificar", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.dtMedico.CurrentCell = null;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtMedico.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CMedico.EstadoMedico(Convert.ToInt32(this.dtMedico.CurrentRow.Cells["IdMedico"].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.MostrarMedico();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtMedico.DataSource = CMedico.BuscarMedico(this.txtBuscar.Text);
        }

        private void dtMedico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtMedico.Columns[e.ColumnIndex].Name == "Estado")
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIdHospital_DoubleClick(object sender, EventArgs e)
        {
            frmDialogHosp fdh = new frmDialogHosp(false);
            fdh.ShowDialog();
            if (fdh.DialogResult == DialogResult.OK)
            {
                hospital.Text = fdh.dtHosp.Rows[fdh.dtHosp.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtIdHospital.Text = fdh.dtHosp.Rows[fdh.dtHosp.CurrentRow.Index].Cells["NombreHospital"].Value.ToString();
               
            }
            else
            {
                MessageBox.Show("Elija un hospital para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
