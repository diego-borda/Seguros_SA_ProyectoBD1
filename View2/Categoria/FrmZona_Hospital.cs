using Seguridad;
using SegurosSA.Controllers;
using SegurosSA.Data;
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
    public partial class FrmZona_Hospital : Form
    {
        private bool IsEditar = false;
        private bool IsNuevo = false;
        public FrmZona_Hospital()
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
            this.txtIdZona.Enabled = valor;
            this.txtIdHospital.Enabled = valor;
        }

        private void Limpiar()
        {
            this.txtIdZona.Text = string.Empty;
            this.txtIdHospital.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdHospital.Focus();
        }

        private void FrmZona_Hospital_Load_1(object sender, EventArgs e)
        {
            Botones();
            Permisos();
            MostrarZonaHospital();
            this.ttHospital.SetToolTip(this.txtIdHospital,"Doble click para buscar Hospital");
            this.ttZona.SetToolTip(this.txtIdZona, "Doble click para buscar un Zona");

        }

        private void  MostrarZonaHospital()
        {
            this.dtZona_Hospital.DataSource = CZona_Hospital.MostrarZona_Hospital();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                DataTable dato;
                dato = CZona_Hospital.Validar_ZonaHospital(Convert.ToInt32(this.idZona.Text), Convert.ToInt32(this.idHos.Text));


                if (this.IsNuevo)
                {
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "No valido")
                        {
                            this.txtIdZona.Focus();
                            this.txtIdHospital.Focus();
                            rpta = "Este Hospital no es CONCERTADO o esta DESHABILITADO";
                        }

                        if (dr["Resultado"].ToString() == "Ya Existe")
                        {
                            this.txtIdZona.Focus();
                            this.txtIdHospital.Focus();
                            rpta = "Este Hospital ya EXISTE";
                        }

                    }
                    else
                    {
                        rpta = CZona_Hospital.InsertarZona_Hospital(Convert.ToInt32(this.idZona.Text), Convert.ToInt32(this.idHos.Text));
                        //this.txtUsuario.Text = string.Empty;
                        //this.txtContraseña.Text = string.Empty;
                        //this.txtUsuario.Focus();
                    }

                }
                else
                {

                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "No valido")
                        {
                            this.txtIdZona.Focus();
                            this.txtIdHospital.Focus();
                            rpta = "Este Hospital no es CONCERTADO o esta DESHABILITADO";
                        }

                        if (dr["Resultado"].ToString() == "Ya Existe")
                        {
                            this.txtIdZona.Focus();
                            this.txtIdHospital.Focus();
                            rpta = "Este Hospital ya EXISTE";
                        }
                    }
                    else
                    {
                        rpta = CZona_Hospital.EditarZona_Hospital(Convert.ToInt32(this.dtZona_Hospital.CurrentRow.Cells[0].Value),
                               (Convert.ToInt32(this.idZona.Text)), (Convert.ToInt32(this.idHos.Text)));
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
                    this.dtZona_Hospital.DataSource = CZona_Hospital.MostrarZona_Hospital();


                }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtZona_Hospital.SelectedRows.Count == 1)
            {
                this.txtIdZona.Text = Convert.ToString(this.dtZona_Hospital.CurrentRow.Cells["NombreZona"].Value);
                this.idZona.Text = Convert.ToString(this.dtZona_Hospital.CurrentRow.Cells["IdZona"].Value);
                this.txtIdHospital.Text = Convert.ToString(this.dtZona_Hospital.CurrentRow.Cells["NombreHospital"].Value);
                this.idHos.Text = Convert.ToString(this.dtZona_Hospital.CurrentRow.Cells["IdHospital"].Value);

                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                this.txtIdHospital.Focus();

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
            this.dtZona_Hospital.CurrentCell = null;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtZona_Hospital.DataSource = CZona_Hospital.BuscarZona_Hospital(this.txtBuscar.Text);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtZona_Hospital.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CZona_Hospital.EstadoZona_ZonaHospital(Convert.ToInt32(this.dtZona_Hospital.CurrentRow.Cells["Id_ZonaHospital"].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.MostrarZonaHospital();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtIdZona_MouseDoubleClick(object sender, MouseEventArgs e)
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
                MessageBox.Show("Elija un Zona para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtIdHospital_MouseDoubleClick(object sender, EventArgs e)
        {
            frmDialogHosp fda = new frmDialogHosp(true);
            fda.ShowDialog();
            if (fda.DialogResult == DialogResult.OK)
            {
                idHos.Text = fda.dtHosp.Rows[fda.dtHosp.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtIdHospital.Text = fda.dtHosp.Rows[fda.dtHosp.CurrentRow.Index].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Elija un Hospital para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtZonaHospital_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dtZona_Hospital_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtZona_Hospital.Columns[e.ColumnIndex].Name == "Estado")
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
