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

namespace View2.Servicios
{
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private bool IsEditar = false;
        private bool IsNuevo = false;

     
        private void frmConsultas_Load(object sender, EventArgs e)
        {
            MostrarConsultas();
            ToolTips();
            ToolTipMedico();
            Botones();
            this.dtpFecha.Value = DateTime.Today;
            this.dtConsultas.CurrentCell = null;
        }

        private void ToolTips()
        {
            ToolTip toolTipHospital = new ToolTip();
            toolTipHospital.ToolTipTitle = "Como Insertar";
            toolTipHospital.UseFading = true;
            toolTipHospital.UseAnimation = true;
            toolTipHospital.IsBalloon = true;
            toolTipHospital.ShowAlways = false;
            toolTipHospital.AutoPopDelay = 6000;
            toolTipHospital.InitialDelay = 400;
            toolTipHospital.ReshowDelay = 100;
            toolTipHospital.SetToolTip(this.txtHospital, "Haga doble click en este cuadro de texto para buscar hospital");

            ToolTip toolTipContrato = new ToolTip();
            toolTipContrato.ToolTipTitle = "Como Insertar";
            toolTipContrato.UseFading = true;
            toolTipContrato.UseAnimation = true;
            toolTipContrato.IsBalloon = true;
            toolTipContrato.ShowAlways = false;
            toolTipContrato.AutoPopDelay = 6000;
            toolTipContrato.InitialDelay = 400;
            toolTipContrato.ReshowDelay = 100;
            toolTipContrato.SetToolTip(this.txtAsegurado, "Haga doble click en este cuadro de texto para buscar Asegurado");

        }

        private void ToolTipMedico()
        {
            ToolTip toolTipMedico = new ToolTip();
            ToolTip toolTipMedico2 = new ToolTip();
            toolTipMedico2.ShowAlways = false;
            toolTipMedico.ToolTipTitle = "Como Insertar";
            toolTipMedico.UseFading = true;
            toolTipMedico.UseAnimation = true;
            toolTipMedico.IsBalloon = true;
            toolTipMedico.ShowAlways = true;
            toolTipMedico.AutoPopDelay = 6000;
            toolTipMedico.InitialDelay = 400;
            toolTipMedico.ReshowDelay = 100;
            if (this.txtHospital.Text == "")
            {
                toolTipMedico.SetToolTip(this.txtMedico, "Primero inserte un Hospital, luego 2X click en este cuadro de texto");
            }
            else
            {
                toolTipMedico.ShowAlways = false;
                toolTipMedico.Active = false;
                toolTipMedico2.ToolTipTitle = "Como Insertar";
                toolTipMedico2.UseFading = true;
                toolTipMedico2.UseAnimation = true;
                toolTipMedico2.IsBalloon = true;
                toolTipMedico2.ShowAlways = true;
                toolTipMedico2.AutoPopDelay = 6000;
                toolTipMedico2.InitialDelay = 400;
                toolTipMedico2.ReshowDelay = 100;
                toolTipMedico2.SetToolTip(this.txtMedico, "Haga doble click en este cuadro de texto para buscar Medico");
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
            this.txtHospital.Enabled = valor;
            this.txtAsegurado.Enabled = valor;
            if (string.IsNullOrEmpty(this.txtHospital.Text))
            {
                this.txtMedico.Enabled = false;
            }
            this.dtpFecha.Enabled = valor;
            this.txtGastos.ReadOnly = !valor;
        }

        private void MostrarConsultas()
        {
            this.dtConsultas.DataSource = CConsultas.MostrarConsultas();
            this.dtConsultas.Columns["ID Hospital"].Visible = false;
            this.dtConsultas.Columns["IdMedico"].Visible = false;
            // foreach(DataGridViewRow row in dtConsultas.Rows)
            // {
            //     foreach(DataGridViewCell cell in row.Cells)
            //     {
            //         do
            //         {
            //             MessageBox.Show("Por favor cambie el Gasto en el Contrato #"+ this.dtConsultas.CurrentRow.Cells[0].Value.ToString());
            //         } while (!(int.Parse(this.dtConsultas.CurrentRow.Cells[10].Value.ToString()) == 0) && ((this.dtConsultas.CurrentRow.Cells[10].Value.ToString() == "Finalizado")
            //             || (this.dtConsultas.CurrentRow.Cells[10].Value.ToString() == "Es Hoy")));                   
            //     }
            //}

        }

        private void Limpiar()
        {
            this.txtAsegurado.Text = string.Empty;
            this.txtEspecialidad.Text = string.Empty;
            this.txtGastos.Text = string.Empty;
            this.txtHospital.Text = string.Empty;
            this.txtMedico.Text = string.Empty;
            this.dtpFecha.Value = DateTime.Today;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.dtConsultas.CurrentCell = null;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtConsultas.SelectedRows.Count == 1)
            {
                try
                {

                    rpta = CConsultas.EstadoConsulta(Convert.ToInt32(this.dtConsultas.CurrentRow.Cells["IdConsulta"].Value));
                    if (rpta == "OK")
                        MessageBox.Show("El estado ha sido actualizado", "Sistema de Seguros: Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("El estado no pudo ser actualizado porque su contrato de poliza puede estar Finalizado, Cancelado o Deshabilitado", "Sistema de Seguros Medicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                this.MostrarConsultas();
            }

            else
                MessageBox.Show("Debe tener seleccionada una fila para actualizar el ESTADO", "Sistema de Seguros: Hospitalizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.dtConsultas.DataSource = CConsultas.BuscarConsulta(this.txtBuscar.Text);
        }


        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (this.IsNuevo == true)
            {
                DateTime dt = DateTime.Today;
                if (dtpFecha.Value < dt)
                {
                    MessageBox.Show("No puede registrar una fecha menor que hoy", "Error del Sistema : Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpFecha.Value = DateTime.Today;
                }
            }
        }


        private void txtIdHospital_DoubleClick(object sender, EventArgs e)
        {
            frmDialogHosp fdh = new frmDialogHosp(false);
            fdh.ShowDialog();
            if (fdh.DialogResult == DialogResult.OK)
            {
                hospital.Text = fdh.dtHosp.Rows[fdh.dtHosp.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtHospital.Text = fdh.dtHosp.Rows[fdh.dtHosp.CurrentRow.Index].Cells[1].Value.ToString();
                this.txtMedico.Enabled = true;
                this.txtMedico.Text = " ";
            }
            else
            {
                MessageBox.Show("Elija un hospital para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.txtEspecialidad.Text = fdm.dtMedico.Rows[fdm.dtMedico.CurrentRow.Index].Cells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("Elija un Médico para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtAsegurado_DoubleClick(object sender, EventArgs e)
        {
            frmDialogContrato fdc = new frmDialogContrato();
            fdc.ShowDialog();
            if (fdc.DialogResult == DialogResult.OK)
            {
                contrato.Text = fdc.dtCon.Rows[fdc.dtCon.CurrentRow.Index].Cells[0].Value.ToString();
                this.txtAsegurado.Text = fdc.dtCon.Rows[fdc.dtCon.CurrentRow.Index].Cells["Nombre Asegurado"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Elija un Contrato de Poliza para continuar", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "", s;

                if (this.IsNuevo)
                {
                    s = CConsultas.ValidacionConsulta(Convert.ToInt32(contrato.Text), this.dtpFecha.Value);
                    if (!string.IsNullOrEmpty(s))
                    {
                        if (s == "fecha consulta no coincide")
                        {
                            this.dtpFecha.Focus();
                            rpta = "Lo Sentimos, la fecha de esta Consulta está fuera de la fecha de vigencia de su Contrato de Póliza";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Ya no tiene cobertura para esta consulta")
                        {
                            rpta = "Ya ha superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if(s == "Ya se acabo su cobertura para esta consulta")
                        {
                            rpta = "Ya ha superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(MontoConsulta()))
                        {
                            rpta = CConsultas.InsertarConsulta(Convert.ToInt32(hospital.Text), Convert.ToInt32(medico.Text), Convert.ToInt32(contrato.Text), this.txtEspecialidad.Text, this.dtpFecha.Value, (float)Convert.ToDouble(this.txtGastos.Text));
                            MessageBox.Show("Datos Ingresados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            rpta = CConsultas.InsertarConsulta(Convert.ToInt32(hospital.Text), Convert.ToInt32(medico.Text), Convert.ToInt32(contrato.Text), this.txtEspecialidad.Text, this.dtpFecha.Value, (float)Convert.ToDouble(this.txtGastos.Text));
                            string st = ":" + MontoConsulta();
                            st = st.Replace(" " + " " + " " + " " + " " + " " + " " + " ", "$");
                            MessageBox.Show(" Se ha excedido su monto de Cobertura \n Le faltan" + st + " para cubrir completamente su consulta", "Sistema de Reservas : Datos Ingresados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                else
                {
                    s = CConsultas.ValidacionConsultaEditar(Convert.ToInt32(contrato.Text), Convert.ToInt32(this.dtConsultas.CurrentRow.Cells[0].Value), this.dtpFecha.Value);
                    if (!string.IsNullOrEmpty(s))
                    {
                        if (s == "fecha consulta no coincide")
                        {
                            this.dtpFecha.Focus();
                            rpta = "Lo Sentimos, la fecha de esta Consulta está fuera de la fecha de vigencia de su Contrato de Póliza";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (s == "Ya no tiene cobertura para esta consulta")
                        {
                            rpta = "Ya ha superado el valor de Cobertura de su Poliza para este mes";
                            MessageBox.Show(rpta, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(MontoConsulta()))
                        {
                            rpta = CConsultas.EditarConsulta(Convert.ToInt32(this.dtConsultas.CurrentRow.Cells[0].Value), Convert.ToInt32(hospital.Text), Convert.ToInt32(medico.Text), 
                                Convert.ToInt32(contrato.Text), this.txtEspecialidad.Text, this.dtpFecha.Value, (float)Convert.ToDouble(this.txtGastos.Text));
                            MessageBox.Show("Datos Actualizados", "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            rpta = CConsultas.EditarConsulta(Convert.ToInt32(this.dtConsultas.CurrentRow.Cells[0].Value), Convert.ToInt32(hospital.Text), Convert.ToInt32(medico.Text), Convert.ToInt32(contrato.Text), this.txtEspecialidad.Text, this.dtpFecha.Value, (float)Convert.ToDouble(this.txtGastos.Text));
                            string st = ":" + MontoConsulta();
                            st = st.Replace(" " + " " + " " + " " + " " + " " + " " + " ", "$");
                            MessageBox.Show(" Se ha excedido su monto de Cobertura \n Le faltan" + st + " para cubrir completamente su consulta", "Sistema de Reservas : Datos Ingresados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                MostrarConsultas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private string MontoConsulta()
        {
            string s = CConsultas.NuevaConsulta(Convert.ToInt32(contrato.Text), (float)Convert.ToDouble(this.txtGastos.Text),
                this.dtpFecha.Value);
            if (string.IsNullOrEmpty(s))
            {
                return s = null;
            }
            else
                return s;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dtConsultas.SelectedRows.Count == 1)
            {
                this.hospital.Text = Convert.ToString(this.dtConsultas.CurrentRow.Cells[1].Value);
                this.medico.Text = Convert.ToString(this.dtConsultas.CurrentRow.Cells[2].Value);
                this.contrato.Text = Convert.ToString(this.dtConsultas.CurrentRow.Cells["IdContrato"].Value);
                this.txtHospital.Text = Convert.ToString(this.dtConsultas.CurrentRow.Cells[4].Value);
                this.txtMedico.Text = Convert.ToString(this.dtConsultas.CurrentRow.Cells[5].Value);
                this.txtEspecialidad.Text = Convert.ToString(this.dtConsultas.CurrentRow.Cells["Especialidad"].Value);
                this.txtAsegurado.Text = Convert.ToString(this.dtConsultas.CurrentRow.Cells[6].Value);
                this.dtpFecha.Value = Convert.ToDateTime(this.dtConsultas.CurrentRow.Cells["Fecha"].Value);
                this.txtGastos.Text = Convert.ToString(this.dtConsultas.CurrentRow.Cells[10].Value);

                this.IsNuevo = false;
                this.IsEditar = true;
                this.Botones();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila antes de Modificar", "Sistema de Seguros", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            string rpta;
            if (this.dtConsultas.SelectedRows.Count == 1)
            {
                if (this.dtConsultas.CurrentRow.Cells["Estado"].Value.ToString() == "Cancelado" || this.dtConsultas.CurrentRow.Cells["Estado"].Value.ToString() == "Deshabilitado"
                    || this.dtConsultas.CurrentRow.Cells["Estado"].Value.ToString() == "Finalizado")
                {
                    MessageBox.Show("Esta Consulta no puede ser cancelada", "Sistema de Seguros: Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        rpta = CConsultas.CancelarConsulta(Convert.ToInt32(this.dtConsultas.CurrentRow.Cells[0].Value));
                        if (rpta == "OK")
                            MessageBox.Show("Consulta Cancelada con éxito", "Sistema de Seguros: Conultas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("La Consulta no pudo ser cancelada", "Sistema de Seguros: Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    MostrarConsultas();
                }
            }
            else
                MessageBox.Show("Debe tener seleccionada una fila para CANCELAR", "Sistema de Seguros: Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtConsultas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtConsultas.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (Convert.ToString(e.Value) == "Finalizado")
                {
                    e.CellStyle.ForeColor = Color.Green;

                }
                if (Convert.ToString(e.Value) == "Cancelado")
                {
                    e.CellStyle.ForeColor = Color.Red;

                }
                if (Convert.ToString(e.Value) == "Proximamente")
                {
                    e.CellStyle.ForeColor = Color.YellowGreen;

                }
                if (Convert.ToString(e.Value) == "Es Hoy")
                {
                    e.CellStyle.ForeColor = Color.Blue;

                }
                if (Convert.ToString(e.Value) == "Deshabilitado")
                {
                    e.CellStyle.ForeColor = Color.Olive;

                }
            }
        }
    }
}
