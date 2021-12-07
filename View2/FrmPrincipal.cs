using Seguridad;
using SegurosSA.View.ViewServicios;
using System;
using System.Windows.Forms;
using View2.Reportes.RecaudacionConsultas;
using View2.Reportes.RecaudacionHospitalizacion;
using View2.Reportes.RecaudacionPoliza;
using View2.Reportes.ReporteAsegurado;
using View2.Seguridad;
using View2.Servicios;

namespace SegurosSA.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            DiseñoLateral();
        }

        private void DiseñoLateral()
        {
            pnlCatalogo.Visible = false;
            pnlServicio.Visible = false;
            pnlRecaudacion.Visible = false;
            //..
        }

        private void hideSubmenu()
        {
            if (pnlCatalogo.Visible == true)
                pnlCatalogo.Visible = false;
            if (pnlServicio.Visible == true)
                pnlServicio.Visible = false;
            if (pnlRecaudacion.Visible == true)
                pnlRecaudacion.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        #region CATALOGO

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlCatalogo);
        }

        private void btnAsegurado_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAsegurado());
            hideSubmenu();
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmGasto());
            hideSubmenu();
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmHospital());
            hideSubmenu();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMedico());
            hideSubmenu();
        }

        private void btnPoliza_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmPoliza());
            hideSubmenu();
        }

        private void btnZonas_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmZonas());
            hideSubmenu();
        }

        private void btnZona_Hospital_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmZona_Hospital());
            hideSubmenu();
        }
        #endregion

        #region SERVICIOS
        private void btnServicio_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlServicio);
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            openChildForm(new frmContrato());
            hideSubmenu();
        }

        private void btnHospitalizacion_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmHospitalizacion2());
            hideSubmenu();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConsultas());
            hideSubmenu();
        }

        #endregion

        #region RECAUDACION

        private void btnReporte_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlRecaudacion);
        }

        private void btnRecaudacionH_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRHospitalizacion());
            hideSubmenu();
        }

        private void btnRecaudacionC_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmReporteConsulta());
            hideSubmenu();
        }

        private void btnRecaudacionTPoliza_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmReportePoliza());
            hideSubmenu();
        }

        private void btnRecaudacionA_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmReporteAsegurado());
            hideSubmenu();
        }

        #endregion

        #region SEGURIDAD
        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmSeguridad());
            hideSubmenu();
        }

        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(childForm);
            pnlCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que quiere cerrar sesion?", "warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
                this.Close();
          

        }

        private void LoaduserData()
        {

            lblUsuario.Text = CaUsuario.Nombre+ " " +CaUsuario.Apellido;
            lblRol.Text = CaUsuario.Rol;
            lblEmail.Text = CaUsuario.Email;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoaduserData();
            Permisos();
        }
        private void Permisos()
        {
            if (CaUsuario.Rol == CaRoles.GerenteHospital)
            {
                btnServicio.Visible = false;
                btnAsegurado.Visible = false;
                btnPoliza.Visible = false;
                btnRecaudacionA.Visible = false;
                btnRecaudacionTpoliza.Visible = false;
                btnSeguridad.Visible = false;
            }
            if (CaUsuario.Rol == CaRoles.GerenteAsegurador)
            {
                btnMedico.Visible = false;
                btnHospital.Visible = false;
                btnZonas.Visible = false;
                btnZona_Hospital.Visible = false;
                btnServicio.Visible = false;
                btnSeguridad.Visible = false;
                btnGastos.Visible = false;
          
                btnRecaudacionH.Visible = false;
                btnRecaudacionC.Visible = false;
            }
            if (CaUsuario.Rol == CaRoles.RecepcionistaHospital)
            {
               btnAsegurado.Visible = false;
               btnGastos.Visible = false;
               btnContrato.Visible = false;
               btnReporte.Visible = false;
               btnSeguridad.Visible = false;
            }
            if (CaUsuario.Rol == CaRoles.RecepcionistaAsegurador)
            {
                btnMedico.Visible = false;
                btnHospital.Visible = false;
                btnZonas.Visible = false;
                btnZona_Hospital.Visible = false;
                btnConsulta.Visible = false;
                btnHospitalizacion.Visible = false;
                btnReporte.Visible = false;
                btnSeguridad.Visible = false;

            }
        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openChildForm(new FrmEditarPerfil());
            hideSubmenu();
        }
    }
    

}
