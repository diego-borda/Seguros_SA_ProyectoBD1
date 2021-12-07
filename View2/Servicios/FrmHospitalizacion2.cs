using Model;
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

namespace View2.Servicios
{
    public partial class FrmHospitalizacion2 : Form
    {
        private bool IsEditar = false;
        private bool IsNuevo = false;
        public FrmHospitalizacion2()
        {
            InitializeComponent();
        }

        private void frmHospitalizacion_Load(object sender, EventArgs e)
        {
            Mostrar();
            Botones();
            ToolTips();
            Limpiar();

        }

        private void Mostrar()
        {
            this.dtHospit.DataSource = CHospitalizacion.MostrarHospitalizacion();
            this.dtHospit.Columns["IdHospital"].Visible = false;
            this.dtHospit.Columns["IdMedico"].Visible = false;
          //  this.dtHospit.Columns["IdContrato"].Visible = false;
            this.dtHospit.CurrentCell = null;

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
            //this.txtHospital.Enabled = valor;
            this.txtContrato.Enabled = valor;
            this.txtHospital.Enabled = false;
            this.txtMedico.Enabled = false;
            this.dtpFechaI.Enabled = valor;
            this.dtpFechaF.Enabled = valor;
        }

        private void Limpiar()
        {
            this.txtContrato.Text = string.Empty;
            this.txtHospital.Text = string.Empty;
            this.txtMedico.Text = string.Empty;
            this.dtpFechaI.Value = DateTime.Today;
            this.dtpFechaF.Value = DateTime.Today;
        }

        private void ToolTips()
        {
            ttAseg.SetToolTip(this.txtContrato, "Haga doble click en este cuadro de texto para buscar Asegurado");
            ttHosp.SetToolTip(this.txtHospital, "Primero inserte un Asegurado");
            ttMedico.SetToolTip(this.txtMedico, "Primero inserte un Hospital");
        }

        private void txtContrato_DoubleClick(object sender, EventArgs e)
        {
            frmDialogAsegCateg fdac = new frmDialogAsegCateg();
            fdac.ShowDialog();
            if (fdac.DialogResult == DialogResult.OK)
            {
                contrato.Text = fdac.dtAsegCateg.Rows[fdac.dtAsegCateg.CurrentRow.Index].Cells["IdContrato"].Value.ToString();
                categoria.Text = fdac.dtAsegCateg.Rows[fdac.dtAsegCateg.CurrentRow.Index].Cells["Categoria Asegurado"].Value.ToString();
                zona.Text = fdac.dtAsegCateg.Rows[fdac.dtAsegCateg.CurrentRow.Index].Cells["NombreZona"].Value.ToString();
                this.txtContrato.Text = fdac.dtAsegCateg.Rows[fdac.dtAsegCateg.CurrentRow.Index].Cells["Nombre Asegurado"].Value.ToString();
                this.txtHospital.Enabled = true;
                this.txtHospital.Text = " ";
            }
            else
            {
                MessageBox.Show("Elija un Contrato de Poliza para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtHospital_DoubleClick(object sender, EventArgs e)
        {
            frmDialogZonaHospital_Hospital fdzh = new frmDialogZonaHospital_Hospital(categoria.Text, zona.Text);
            fdzh.ShowDialog();
            if (fdzh.DialogResult == DialogResult.OK)
            {
                hospital.Text = fdzh.dtSZona.Rows[fdzh.dtSZona.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtHospital.Text = fdzh.dtSZona.Rows[fdzh.dtSZona.CurrentRow.Index].Cells["NombreHospital"].Value.ToString();
                this.txtMedico.Enabled = true;
                this.txtMedico.Text = " ";
            }
            else
            {
                MessageBox.Show("Elija un Hospital para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMedico_DoubleClick(object sender, EventArgs e)
        {
            frmDialogMed fdm = new frmDialogMed(this.txtHospital.Text);
            fdm.ShowDialog();
            if (fdm.DialogResult == DialogResult.OK)
            {
                medico.Text = fdm.dtMedico.Rows[fdm.dtMedico.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtMedico.Text = fdm.dtMedico.Rows[fdm.dtMedico.CurrentRow.Index].Cells[3].Value.ToString() + " " + fdm.dtMedico.Rows[fdm.dtMedico.CurrentRow.Index].Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Elija un Médico para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpFechaI_ValueChanged(object sender, EventArgs e)
        {
            if (this.IsNuevo == true)
            {
                DateTime dt = DateTime.Today;
                if (dtpFechaI.Value < dt)
                {
                    MessageBox.Show("No puede registrar una fecha menor que hoy", "Error del Sistema : Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpFechaI.Value = DateTime.Today;
                }
            }
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (this.dtHospit.SelectedRows.Count == 1)
            {
                frmDialogVerDetalle fdh = new frmDialogVerDetalle(int.Parse(this.dtHospit.Rows[this.dtHospit.CurrentRow.Index].Cells[0].Value.ToString()));
                fdh.ShowDialog();
            }
        }

        private void btnVerAgregar_Click(object sender, EventArgs e)
        {
            if (this.dtHospit.SelectedRows.Count == 1)
            {
                if (this.dtHospit.Rows[this.dtHospit.CurrentRow.Index].Cells["Estado"].Value.ToString() == "En proceso")
                {
                    this.contrato.Text = this.dtHospit.Rows[this.dtHospit.CurrentRow.Index].Cells["IdContrato"].Value.ToString();
                    frmDetalleHospitalizacion fdh = new frmDetalleHospitalizacion(int.Parse(this.dtHospit.Rows[this.dtHospit.CurrentRow.Index].Cells[0].Value.ToString()),
                        int.Parse(contrato.Text));
                    fdh.ShowDialog();
                    Mostrar();
                }

                else
                    MessageBox.Show("No se pueden agregar mas detalles a esta Hospitalizacion por su Estado", "Sistema de Seguros: Hospitalizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Debe tener seleccionada una fila para Agregar Detalles", "Sistema de Seguros: Hospitalizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtHospit.DataSource = CHospitalizacion.BuscarHospitalizacion(this.txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtHospit.SelectedRows.Count == 1)
            {
                this.hospital.Text = Convert.ToString(this.dtHospit.CurrentRow.Cells[1].Value);
                this.medico.Text = Convert.ToString(this.dtHospit.CurrentRow.Cells[2].Value);
                this.contrato.Text = Convert.ToString(this.dtHospit.CurrentRow.Cells[3].Value);
                this.txtHospital.Text = Convert.ToString(this.dtHospit.CurrentRow.Cells[4].Value);
                this.txtMedico.Text = Convert.ToString(this.dtHospit.CurrentRow.Cells[5].Value);
                this.txtContrato.Text = Convert.ToString(this.dtHospit.CurrentRow.Cells[6].Value);
                this.dtpFechaI.Value = Convert.ToDateTime(this.dtHospit.CurrentRow.Cells[7].Value);
                this.dtpFechaF.Value = Convert.ToDateTime(this.dtHospit.CurrentRow.Cells[8].Value);

                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Modificar", "Sistema de Seguros", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        

        

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtHospit.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CHospitalizacion.EstadoHospitalizacion(Convert.ToInt32(this.dtHospit.CurrentRow.Cells[0].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros: Hospitalizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado porque su contrato de poliza puede estar Finalizado, Cancelado o Deshabilitado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.Mostrar();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Seguros: Hospitalizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.dtHospit.CurrentCell = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "", s;
                DateTime fechaf = this.dtpFechaF.Value;
                DateTime fechai = this.dtpFechaI.Value;
                int diferencia = (fechaf - fechai).Days;

                if (this.IsNuevo)
                {
                    s = CHospitalizacion.ValidarHospitalizacion(Convert.ToInt32(contrato.Text), this.dtpFechaI.Value, this.dtpFechaF.Value);
                    if (!string.IsNullOrEmpty(s))
                    {
                        if (s == "fecha hospit no coincide con fecha contrato poliza")
                        {
                            this.dtpFechaI.Focus();
                            this.dtpFechaF.Focus();
                            rpta = "Lo Sentimos, la fecha de esta Hospitalización está fuera de la fecha de vigencia de su Contrato de Póliza";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Ya esta hospitalizado")
                        {
                            rpta = "El Asegurado que inserto ya esta hospitalizado";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Ya no tiene cobertura para esta hospitalizacion (por consulta)")
                        {
                            rpta = "No se puede cubrir su hospitalizacion debido a que las consultas de este mes han superado el valor de Cobertura de su Poliza";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Ya no tiene cobertura (por hospitalizacion)")
                        {
                            rpta = "Sus Gastos por Hospitalizacion ya han superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (diferencia <= 0)
                    {
                        rpta = "Por favor verifique las fechas";
                        this.dtpFechaF.Focus();
                    }
                    else
                    {
                        rpta = CHospitalizacion.InsertarHospitalizacion(Convert.ToInt32(hospital.Text), Convert.ToInt32(medico.Text), Convert.ToInt32(contrato.Text),
                               dtpFechaI.Value, dtpFechaF.Value);
                        if (rpta != "OK")
                        {
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Datos Ingresados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    s = CHospitalizacion.ValidarHospitalizacion_Editar(int.Parse(this.dtHospit.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(contrato.Text), this.dtpFechaI.Value, this.dtpFechaF.Value);
                    if (!string.IsNullOrEmpty(s))
                    {
                        if (s == "fecha hospit no coincide con fecha contrato poliza")
                        {
                            this.dtpFechaI.Focus();
                            this.dtpFechaF.Focus();
                            rpta = "Lo Sentimos, la fecha de esta Hospitalización está fuera de la fecha de vigencia de su Contrato de Póliza";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Ya esta hospitalizado")
                        {
                            rpta = "El Asegurado que inserto ya esta hospitalizado";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Ya no tiene cobertura para esta hospitalizacion (por consulta)")
                        {
                            rpta = "Sus consultas ya han superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Ya no tiene cobertura (por hospitalizacion)")
                        {
                            rpta = "Sus Gastos por Hospitalizacion ya han superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (diferencia <= 0)
                    {
                        rpta = "Por favor verifique las fechas";
                        this.dtpFechaF.Focus();
                    }
                    else
                    {
                        rpta = CHospitalizacion.EditarHospitalizacion(int.Parse(this.dtHospit.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(hospital.Text), Convert.ToInt32(medico.Text), Convert.ToInt32(contrato.Text),
                               dtpFechaI.Value, dtpFechaF.Value);
                        if (rpta != "OK")
                        {
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Datos Actualizados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelarHospitalizacion_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtHospit.SelectedRows.Count == 1)
            {
                if (this.dtHospit.CurrentRow.Cells["Estado"].Value.ToString() == "Finalizada" || this.dtHospit.CurrentRow.Cells["Estado"].Value.ToString() == "Deshabilitada"
                    || this.dtHospit.CurrentRow.Cells["Estado"].Value.ToString() == "Cancelada")
                {
                    MessageBox.Show("Esta Hospitalizacion no puede ser cancelada", "Sistema de Seguros: Hospitalizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        rpta = CHospitalizacion.CancelarHospitalizacion(Convert.ToInt32(this.dtHospit.CurrentRow.Cells[0].Value));
                        if (rpta == "OK")
                            MessageBox.Show("Hospitalizacion Cancelada con éxito", "Sistema de Seguros: Hospitalizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("La Hospitalizacion no pudo ser cancelada", "Sistema de Seguros: Hospitalizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                Mostrar();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para CANCELAR", "Sistema de Seguros: Hospitalizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dtHospit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtContratos.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (Convert.ToString(e.Value) == "En proceso")
                {
                    e.CellStyle.ForeColor = Color.Blue;

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
