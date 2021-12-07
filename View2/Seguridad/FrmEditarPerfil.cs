using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegurosSA.Data;
using SegurosSA.Controllers;
using Seguridad;


namespace View2.Seguridad
{
    public partial class FrmEditarPerfil : Form
    {
        public FrmEditarPerfil()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarPerfil_Load(object sender, EventArgs e)
        {
            CargarUsuario();
            EditarContraseñar();
        }

        private void CargarUsuario()
        {
            lblUsuario.Text = CaUsuario.Usuario;
            lblNombre.Text = CaUsuario.Nombre;
            lblApellido.Text = CaUsuario.Apellido;
            lblEmail.Text = CaUsuario.Email;
            lblRol.Text = CaUsuario.Rol;


            //edit panel

            txtUsuario.Text = CaUsuario.Usuario;
            txtEmail.Text = CaUsuario.Email;
            txtContraseña.Text = CaUsuario.Contraseña;
            txtConfirmar.Text = CaUsuario.Contraseña;
            txtActual.Text = "";
        }
        private void EditarContraseñar()
        {
            lnkEditar.Text = "Editar";
            txtContraseña.Enabled = false;
            txtConfirmar.Enabled = false;
            txtConfirmar.UseSystemPasswordChar = false;

        }

        private void reset()
        {
            CargarUsuario();
            EditarContraseñar();
        }


        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lnkEditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            CargarUsuario();
        }

        private void lnkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lnkEditar.Text == "Editar")
            {
                lnkEditar.Text = "Cancelar";
                txtContraseña.Enabled= true;
                txtContraseña.Text = "";
                txtConfirmar.Enabled= true;
                txtConfirmar.Text = "";
            }
            else if (lnkEditar.Text == "Cancelar")
            {
                reset();
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
                if (txtContraseña.Text == txtConfirmar.Text)
                {
                    if (txtActual.Text == CaUsuario.Contraseña)
                    {
                        var cUsuario = new CUsuario(
                            idUsuario : CaUsuario.IdUsuario,
                            loginName: txtUsuario.Text,
                            contraseña: txtConfirmar.Text,
                            email: txtEmail.Text);
                        var result = cUsuario.editUsuario();
                        MessageBox.Show(result);
                        reset();
                        panel1.Visible = false;
                     
                    }
                    else
                        MessageBox.Show("Contraseña actual incorrecta");
                }
                else
                    MessageBox.Show("Contraseña incorrecta ");
            
            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            reset();
        }
    }
}


