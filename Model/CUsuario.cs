using Seguridad;
using SegurosSA.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Controllers
{
    public class CUsuario
    {
        DUsuario dUsuario = new DUsuario();

        private int IdUsuario;
        private string LoginName;
        private string Contraseña;
        private string Email;

        public CUsuario(int idUsuario, string loginName, string contraseña, string email)
        {
            IdUsuario = idUsuario;
            LoginName = loginName;
            Contraseña = contraseña;
            Email = email;
        }

        public CUsuario()
        {

        }
        public string editUsuario()
        {
            try {
            dUsuario.EditarUsuario(IdUsuario, LoginName, Contraseña, Email);
            Validar_acceso(LoginName, Contraseña);
                return "Ingreso incorrecto de los datos";
            }
            catch (Exception ex)
            {
                return "Ya esta registrado este usuario, intentalo de nuevo";
            }
        }

        public static string InsertarUsuario(string nombreUsaurio,string contraseña,  string nombre,
            string apellido,string email, string rol )
        {
            return DUsuario.InsertarUsuario(nombreUsaurio, contraseña, nombre,apellido, email,rol );
        }


        public static string EstadoUsuario(int IdUsuario)
        {
            return DUsuario.EstadoUsuario(IdUsuario);
        }


        public static object BuscarUsuario(string dato)
        {
            return DUsuario.BuscarUsuario(dato);
        }

        public static DataTable ValidarUsuario(string nombreUsuario)
        {
            return DUsuario.ValidarUsuario(nombreUsuario);
        }

        public static DataTable MostrarUsuario()
        {
            return DUsuario.MostrarUsuario();
        }


        public bool Validar_acceso(string usuario, string contraseña)
        {
            return dUsuario.Login(usuario, contraseña);
        }


        public static string EditarUsuarioAdmin(int idUsuario, string nombreUsaurio,  string email, string rol)
        {
            return DUsuario.EditarUsuarioAdmin(idUsuario,  nombreUsaurio,
                        email, rol);
        }


        public void AnyMethod()
        {
            if (CaUsuario.Rol == CaRoles.Administrador)
            {
                //code
            }
            if (CaUsuario.Rol == CaRoles.GerenteAsegurador || CaUsuario.Rol == CaRoles.GerenteHospital || CaUsuario.Rol == CaRoles.RecepcionistaAsegurador || CaUsuario.Rol == CaRoles.RecepcionistaHospital)
            {
                //code
            }
        }
    }
}
