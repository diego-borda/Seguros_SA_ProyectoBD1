using Model;
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

namespace View2.Servicios
{
    public partial class frmDetalleHospitalizacion : Form
    {
        public int idhosp;
        public int idContrato;
        private bool IsEditar = false;
        private bool IsNuevo = false;

        public frmDetalleHospitalizacion(int idHospitalizacion, int idContrato)
        {
            InitializeComponent();
            this.idhosp = idHospitalizacion;
            this.idContrato = idContrato;
        }

        private void frmDetalleHospitalizacion_Load(object sender, EventArgs e)
        {
            Mostrar();
            Botones();
            Tooltip();
            Limpiar();
        }

        private void Mostrar()
        {
            this.txtIdDetalle.Text = idhosp.ToString();
            this.dtDetalleH.DataSource = CDetalleHospitalizacion.MostrarDetallesHosp(idhosp);
            this.dtpFechaF.Value = DateTime.Today;
            this.dtDetalleH.CurrentCell = null;
            this.dtDetalleH.Columns[1].Visible = false;
            this.dtDetalleH.Columns[2].Visible = false;
        }

        private void Tooltip()
        {
            ttGasto.SetToolTip(this.txtGasto, "Haga doble click en este cuadro de texto para buscar Gasto");
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
            this.txtGasto.Enabled = valor;
            this.txtCosto.Enabled = valor;
            this.dtpFechaF.Enabled = valor;
            this.txtDescripcion.ReadOnly = !valor;
        }

        private void Limpiar()
        {
            this.txtGasto.Text = string.Empty;
            this.txtCosto.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.dtpFechaF.Value = DateTime.Today;
        }

        private void txtGasto_DoubleClick(object sender, EventArgs e)
        {
            frmDialogGastos fdg = new frmDialogGastos();
            fdg.ShowDialog();
            if (fdg.DialogResult == DialogResult.OK)
            {
                this.gasto.Text = fdg.dtGasto.Rows[fdg.dtGasto.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtGasto.Text = fdg.dtGasto.Rows[fdg.dtGasto.CurrentRow.Index].Cells[1].Value.ToString();
                this.txtCosto.Text = fdg.dtGasto.Rows[fdg.dtGasto.CurrentRow.Index].Cells[2].Value.ToString();
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtDetalleH.DataSource = CDetalleHospitalizacion.BuscarDetalleHosp(idhosp, this.txtBuscar.Text);
        }

        private void dtpFechaF_ValueChanged(object sender, EventArgs e)
        {
            if (this.IsNuevo == true)
            {
                DateTime dt = DateTime.Today;
                if (dtpFechaF.Value < dt)
                {
                    MessageBox.Show("No puede registrar una fecha menor que hoy", "Error del Sistema : Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpFechaF.Value = DateTime.Today;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
        }


        ///////////////////////////////////////////////////////////////////////
        /////        Hay que hacer la validacion del estado de la hospitalizacion          ///////
        /////          para saber si se pueden agregar mas detalles                                ///////
        ////////////////////////////////////////////////////////////////////////
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "", s;
                s = CDetalleHospitalizacion.ValidarDetalleHosp(idhosp, idContrato, this.dtpFechaF.Value);
                if (this.IsNuevo)
                {

                    if (!string.IsNullOrEmpty(s))
                    {
                        if (s == "Limite del tiempo de hospit alcanzado")
                        {
                            this.dtpFechaF.Focus();
                            rpta = "Esta fecha NO es Valida, la fecha de su hospitalizacion ha caducado";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Se ha excedido su valor de cobertura")
                        {
                            rpta = "Ya ha superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Ya no tiene cobertura (por hospitalizacion)")
                        {
                            rpta = "Sus Gastos por Hospitalizacion ya han superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (s == "Ya no tiene cobertura para esta hospitalizacion (por consulta y hosp)")
                        {
                            rpta = "Sus Gastos por Hospitalizacion y Consultas ya han superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(MontoConsulta()))
                        {
                            rpta = CDetalleHospitalizacion.InsertarDetalleHosp(idhosp, idContrato, int.Parse(gasto.Text), (float)Convert.ToDouble(this.txtCosto.Text)
                                                                                                                     , this.txtDescripcion.Text, this.dtpFechaF.Value);
                            MessageBox.Show("Datos Ingresados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            rpta = CDetalleHospitalizacion.InsertarDetalleHosp(idhosp, idContrato, int.Parse(gasto.Text), (float)Convert.ToDouble(this.txtCosto.Text)
                                                                                                                     , this.txtDescripcion.Text, this.dtpFechaF.Value);
                            char[] chars = { ' ' };
                            string st = MontoConsulta();
                            string result = st.TrimStart(chars);
                            MessageBox.Show(" Se ha excedido su monto de Cobertura \n Le faltan: $" + result + " para cubrir completamente su Hospitalizacion", "Sistema de Reservas : Datos Ingresados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        if (s == "Limite del tiempo de hospit alcanzado")
                        {
                            this.dtpFechaF.Focus();
                            rpta = "Esta fecha NO es Valida, la fecha de su hospitalizacion ha caducado";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Se ha excedido su valor de cobertura")
                        {
                            rpta = "Ya ha superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Ya no tiene cobertura (por hospitalizacion)")
                        {
                            rpta = "Sus Gastos por Hospitalizacion ya han superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else if (s == "Ya no tiene cobertura para esta hospitalizacion (por consulta y hosp)")
                        {
                            rpta = "Sus Gastos por Hospitalizacion y Consultas ya han superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(MontoConsulta()))
                        {
                            rpta = CDetalleHospitalizacion.EditarDetalleHosp(int.Parse(this.dtDetalleH.Rows[this.dtDetalleH.CurrentRow.Index].Cells[0].Value.ToString()), idhosp, idContrato, int.Parse(gasto.Text),
                                (float)Convert.ToDouble(this.txtCosto.Text), this.txtDescripcion.Text, this.dtpFechaF.Value);
                            MessageBox.Show("Datos Actualizados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            rpta = CDetalleHospitalizacion.EditarDetalleHosp(int.Parse(this.dtDetalleH.Rows[this.dtDetalleH.CurrentRow.Index].Cells[0].Value.ToString()), idhosp, idContrato, int.Parse(gasto.Text),
                                (float)Convert.ToDouble(this.txtCosto.Text), this.txtDescripcion.Text, this.dtpFechaF.Value);
                            char[] chars = { ' ' };
                            string st = MontoConsulta();
                            string result = st.TrimStart(chars);
                            MessageBox.Show(" Se ha excedido su monto de Cobertura \n Le faltan: $" + result + " para cubrir completamente su Hospitalizacion", "Sistema de Reservas : Datos Ingresados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private string MontoConsulta()
        {
            string s = CDetalleHospitalizacion.NuevoDetalleHosp(idhosp, idContrato, this.dtpFechaF.Value);
            if (string.IsNullOrEmpty(s))
            {
                return s = null;
            }
            else
                return s;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtDetalleH.SelectedRows.Count == 1)
            {
                this.gasto.Text = Convert.ToString(this.dtDetalleH.CurrentRow.Cells[2].Value);
                this.txtGasto.Text = Convert.ToString(this.dtDetalleH.CurrentRow.Cells[3].Value);
                this.txtCosto.Text = Convert.ToString(this.dtDetalleH.CurrentRow.Cells[4].Value);
                this.txtDescripcion.Text = Convert.ToString(this.dtDetalleH.CurrentRow.Cells[5].Value);
                this.dtpFechaF.Value = Convert.ToDateTime(this.dtDetalleH.CurrentRow.Cells[6].Value);

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
            if (this.dtDetalleH.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CDetalleHospitalizacion.EstadoDetalleHosp(Convert.ToInt32(this.dtDetalleH.CurrentRow.Cells[0].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros: Hospitalizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            this.dtDetalleH.CurrentCell = null;
        }

        private void dtDetalleH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtDetalleH.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (Convert.ToString(e.Value) == "Habilitado")
                {
                    e.CellStyle.ForeColor = Color.Green;

                }
                if (Convert.ToString(e.Value) == "Deshabilitado")
                {
                    e.CellStyle.ForeColor = Color.Red;

                }
              
            }
        }
    }
}
