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
    public partial class FrmZonas : Form

    {
        private bool IsEditar = false;
        private bool IsNuevo = false;
        public FrmZonas()
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
   
        }

        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
       
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtNombre.Focus();
        }

        private void FrmZona_Load_1(object sender, EventArgs e)
        {
            Botones();
            Permisos();
            MostrarZona();
        }

        private void MostrarZona()
        {
            this.dtZona.DataSource = CZona.MostrarZona();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                DataTable dato;
                if (this.IsNuevo)
                {
                    dato = CZona.ValidarZona(this.txtNombre.Text);
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "El nombre de la zona ya existe")
                        {
                            this.txtNombre.Focus();
                        
                        }
                        rpta = "El nombre de la zona ya existe";
                    }
                    else
                    {
                        rpta = CZona.InsertarZona(this.txtNombre.Text);
                    }
                }
                else
                {
                    dato = CZona.ValidarZonaEditar(Convert.ToInt32(this.dtZona.CurrentRow.Cells["Id"].Value), this.txtNombre.Text);
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "El nombre de la zona ya existe")
                        {
                            this.txtNombre.Focus();
                        }
                        rpta = "El nombre de la zona ya existe";
                        
                    }
                    else
                    {
                        rpta = CZona.EditarZona(Convert.ToInt32(this.dtZona.CurrentRow.Cells["Id"].Value),
                    this.txtNombre.Text);
                    }
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
                this.dtZona.DataSource = CZona.MostrarZona();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtZona.SelectedRows.Count == 1)
            {
                this.txtNombre.Text = Convert.ToString(this.dtZona.CurrentRow.Cells["NombreZona"].Value);
             

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
            this.dtZona.CurrentCell = null;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtZona.DataSource = CZona.BuscarZona(this.txtBuscar.Text);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtZona.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CZona.EstadoZona(Convert.ToInt32(this.dtZona.CurrentRow.Cells["Id"].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.MostrarZona();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtZona_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtZona.Columns[e.ColumnIndex].Name == "Estado")
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
