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
using SegurosSA.View;

namespace SegurosSA.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    CUsuario usuario = new CUsuario();
                    var validarLogin = usuario.Validar_acceso(txtUsuario.Text, txtContraseña.Text);
                    if (validarLogin == true)
                    {
                        FrmPrincipal mainMenu = new FrmPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        
                            msgError("Error al ingresar los datos o su cuenta esta deshabilitado \n Intentalo de nuevo");
                            txtContraseña.Clear();
                            txtUsuario.Focus();
                        
                    }

                }
                else msgError("Please enter password");
            }
            else msgError("please enter usernane");
        }

        private void msgError(string msg)
            {
                lblerror.Text = "  " + msg;
                lblerror.Visible = true;

            }

        private void Logout(object sender, FormClosedEventArgs e)
            {
                txtUsuario.Clear();
                txtContraseña.Clear();
                lblerror.Visible = false;
                this.Show();
                txtUsuario.Focus();
            }

        }
    }




