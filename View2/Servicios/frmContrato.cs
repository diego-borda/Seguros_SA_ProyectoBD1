using Model;
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
    public partial class frmContrato : Form
    {
        private bool IsEditar = false;
        private bool IsNuevo = false;

        public frmContrato()
        {
            InitializeComponent();
        }

        private void frmContrato_Load(object sender, EventArgs e)
        {
            Fechas();
            MostrarContratos();
            Ocultar();
            Tooltips();
            Botones();
        }

        private void MostrarContratos()
        {
            this.dtContratos.DataSource = CContrato.MostrarContratos();
            this.dtContratos.CurrentCell = null;
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
            this.dtpFechaI.Enabled = valor;
            this.dtpFechaF.Enabled = valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtCobertura.ReadOnly = !valor;
            this.txtAsegurado.Enabled = valor;
            this.txtPoliza.Enabled = valor;
        }


        private void Ocultar()
        {
            this.dtContratos.Columns[1].Visible = false;
            //this.dtContratos.Columns[2].Visible = false;
        }

        private void Fechas()
        {
            this.dtpFechaI.Value = DateTime.Today;
            this.dtpFechaF.Value = DateTime.Today;
        }

        private void txtAsegurado_DoubleClick(object sender, EventArgs e)
        {
            frmDialogAsegurado fda = new frmDialogAsegurado();
            fda.ShowDialog();
            if (fda.DialogResult == DialogResult.OK)
            {
                idaseg.Text = fda.dtAsegu.Rows[fda.dtAsegu.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtAsegurado.Text = fda.dtAsegu.Rows[fda.dtAsegu.CurrentRow.Index].Cells[4].Value.ToString() + " " + fda.dtAsegu.Rows[fda.dtAsegu.CurrentRow.Index].Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("Elija un Asegurado para continuar", "Error del Sistema : Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPoliza_DoubleClick(object sender, EventArgs e)
        {
            frmDialogPoliza fdp = new frmDialogPoliza();
            fdp.ShowDialog();
            if (fdp.DialogResult == DialogResult.OK)
            {
                idpol.Text = fdp.dtPoliza.Rows[fdp.dtPoliza.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtPoliza.Text = fdp.dtPoliza.Rows[fdp.dtPoliza.CurrentRow.Index].Cells[1].Value.ToString();
                this.txtCosto.Text = fdp.dtPoliza.Rows[fdp.dtPoliza.CurrentRow.Index].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Elija una Poliza para continuar", "Error del Sistema : Polizas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Tooltips()
        {
            ttAsegurado.SetToolTip(this.txtAsegurado, "Doble click en el cuadro de texto para insertar");
            ttPoliza.SetToolTip(this.txtPoliza, "Doble click en el cuadro de texto para insertar");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtContratos.DataSource = CContrato.BuscarContrato(this.txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            //this.txtIdCategoria.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtContratos.SelectedRows.Count == 1)
            {
                this.idaseg.Text= Convert.ToString(this.dtContratos.CurrentRow.Cells[2].Value);
                this.idpol.Text= Convert.ToString(this.dtContratos.CurrentRow.Cells[1].Value);
                this.txtAsegurado.Text = Convert.ToString(this.dtContratos.CurrentRow.Cells[6].Value);
                this.txtPoliza.Text = Convert.ToString(this.dtContratos.CurrentRow.Cells[3].Value);
                this.dtpFechaI.Value = Convert.ToDateTime(this.dtContratos.CurrentRow.Cells[7].Value);
                this.dtpFechaF.Value = Convert.ToDateTime(this.dtContratos.CurrentRow.Cells[8].Value);
                this.txtDescripcion.Text = Convert.ToString(this.dtContratos.CurrentRow.Cells[9].Value);
                this.txtCosto.Text = Convert.ToString(this.dtContratos.CurrentRow.Cells[10].Value);
                this.txtCobertura.Text = Convert.ToString(this.dtContratos.CurrentRow.Cells[11].Value);


                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
                //this.txtIdCategoria.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Modificar", "Sistema de Seguros", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {//Acordate de restar las fechas para ingresar o editar

            try
            {
                string rpta = "";
                DataTable dato;
                DateTime fechaf = this.dtpFechaF.Value;
                DateTime fechai = this.dtpFechaI.Value;
                int diferencia = (fechaf - fechai).Days;


                if (this.IsNuevo)
                {
                    dato = CContrato.ValidarContrato(Convert.ToInt32(idpol.Text), Convert.ToInt32(idaseg.Text), this.dtpFechaI.Value, this.dtpFechaF.Value);
                    if (dato.Rows.Count > 0)
                    {
                        
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "Este asegurado ya posee esta poliza")
                        {
                            this.txtPoliza.Focus();
                        }
                        rpta = "Este Asegurado ya posee éste tipo de Poliza";
                    }
                    else if (diferencia <= 0)
                    {
                        rpta = "Por favor verifique las fechas";
                        this.dtpFechaF.Focus();
                    }
                    else
                    {
                        rpta = CContrato.InsertarContrato(Convert.ToInt32(idpol.Text), Convert.ToInt32(idaseg.Text),
                               dtpFechaI.Value, dtpFechaF.Value, txtDescripcion.Text, (float)Convert.ToDouble(txtCosto.Text), (float)Convert.ToDouble(txtCobertura.Text));
                    }

                }

                else
                {
                    dato = CContrato.ValidarContrato_Editar(Convert.ToInt32(idpol.Text), Convert.ToInt32(this.dtContratos.CurrentRow.Cells[0].Value), Convert.ToInt32(idaseg.Text), this.dtpFechaI.Value, this.dtpFechaF.Value);
                    if (dato.Rows.Count > 0)
                    {
                        DataRow dr;
                        dr = dato.Rows[0];

                        if (dr["Resultado"].ToString() == "Este asegurado ya posee esta poliza")
                        {
                            this.txtPoliza.Focus();
                        }
                        rpta = "Este Asegurado ya posee éste tipo de Poliza";
                    }
                    else if (diferencia <= 0)
                    {
                        rpta = "Por favor verifique las fechas";
                        this.dtpFechaF.Focus();
                    }
                    else 
                        rpta = CContrato.EditarContrato(Convert.ToInt32(this.dtContratos.CurrentRow.Cells[0].Value), Convert.ToInt32(idpol.Text), Convert.ToInt32(idaseg.Text),
                               dtpFechaI.Value, dtpFechaF.Value, txtDescripcion.Text, (float)Convert.ToDouble(txtCosto.Text), (float)Convert.ToDouble(txtCobertura.Text));

                }
                if (rpta.Equals("OK"))
                {
                    if (this.IsNuevo)
                    {
                        MessageBox.Show("Datos Ingresados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datos Actualizados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //probar mañana quitando lo de abajo menos el mostrar
                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                MostrarContratos();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtContratos.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CContrato.EstadoContrato(Convert.ToInt32(this.dtContratos.CurrentRow.Cells["IdContrato"].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros: Contrato Poliza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no puede ser cambiado. Su ID de Asegurado esta Deshabilitado", "Sistema de Seguros: Contrato Poliza", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.MostrarContratos();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Seguros: Contrato Poliza", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Limpiar()
        {
            this.txtAsegurado.Text = string.Empty;
            this.txtCobertura.Text = string.Empty;
            this.txtCosto.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtPoliza.Text = string.Empty;
            Fechas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.dtContratos.CurrentCell = null;
        }

        private void dtpFechaI_ValueChanged(object sender, EventArgs e)
        {
            if (this.IsNuevo == true) {
            DateTime dt = DateTime.Today;
            if (dtpFechaI.Value < dt)
            {
                MessageBox.Show("No puede registrar una fecha menor que hoy", "Error del Sistema : Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaI.Value = DateTime.Today;
            }
            }
        }

        private void btnCancelarContrato_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtContratos.SelectedRows.Count == 1)
            {
                if (this.dtContratos.CurrentRow.Cells["Estado"].Value.ToString() == "Cancelado" || this.dtContratos.CurrentRow.Cells["Estado"].Value.ToString() == "Finalizado"
                    || this.dtContratos.CurrentRow.Cells["Estado"].Value.ToString() == "Deshabilitado")
                {
                    MessageBox.Show("Este Contrato no puede ser cancelado", "Sistema de Seguros: Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        rpta = CContrato.CancelarContrato(Convert.ToInt32(this.dtContratos.CurrentRow.Cells["IdContrato"].Value));
                        if (rpta == "OK")
                            MessageBox.Show("Contrato Cancelado con éxito", "Sistema de Seguros: Contrato Poliza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("El Contrato no pudo ser cancelado", "Sistema de Seguros: Contrato Poliza", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                MostrarContratos();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para CANCELAR", "Sistema de Seguros: Contrato Poliza", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtContratos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtContratos.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (Convert.ToString(e.Value) == "Habilitado")
                {
                    e.CellStyle.ForeColor = Color.Green;

                }
                if (Convert.ToString(e.Value) == "Deshabilitado")
                {
                    e.CellStyle.ForeColor = Color.Red;

                }
                if (Convert.ToString(e.Value) == "Cancelado")
                {
                    e.CellStyle.ForeColor = Color.Black;

                }
                if (Convert.ToString(e.Value) == "Proximamente")
                {
                    e.CellStyle.ForeColor = Color.Purple;

                }
                if (Convert.ToString(e.Value) == "Finalizado")
                {
                    e.CellStyle.ForeColor = Color.DarkSeaGreen;

                }
            }
    }
   }
}


