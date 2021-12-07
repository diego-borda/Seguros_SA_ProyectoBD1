using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SegurosSA.Data;
using Seguridad;
namespace SegurosSA.Data
{
    public class DUsuario : CONEXION
    {
        public void EditarUsuario(int idUsuario,string usuario, string contraseña,string email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "EditarUsuario";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@idusuario", idUsuario);
                    command.CommandType = CommandType.StoredProcedure;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable MostrarUsuario()
        {
            DataTable DtResultado = new DataTable("MostrarUsuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static DataTable ValidarUsuario(string nombreUsuario)
        {
            DataTable DtResultado = new DataTable("ValidarPoliza");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@loginName";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 60;
                ParNombre.Value = nombreUsuario;
                SqlCmd.Parameters.Add(ParNombre);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static string EditarUsuarioAdmin(int idUsuario,  string nombreUsaurio, string email, string rol)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = CONEXION.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EditarUsuarioAdmin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParIdUsuario = new SqlParameter();
                ParIdUsuario.ParameterName = "@idUsuario";
                ParIdUsuario.SqlDbType = SqlDbType.Int;
                ParIdUsuario.Value = idUsuario;
                SqlCmd.Parameters.Add(ParIdUsuario);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@usuario";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 60;
                Parnombre.Value = nombreUsaurio;
                SqlCmd.Parameters.Add(Parnombre);

              

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 60;
                ParEmail.Value = email;
                SqlCmd.Parameters.Add(ParEmail);


                SqlParameter ParRol = new SqlParameter();
                ParRol.ParameterName = "@rol";
                ParRol.SqlDbType = SqlDbType.VarChar;
                ParRol.Size = 500;
                ParRol.Value = rol;
                SqlCmd.Parameters.Add(ParRol);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public static object BuscarUsuario(string dato)
        {

            DataTable DtResultado = new DataTable("BuscarMedico");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@Dato";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = dato;
                SqlCmd.Parameters.Add(ParDato);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static string EstadoUsuario(int idUsuario)
        {

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = CONEXION.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Estado_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idUsuario";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Value = idUsuario;
                SqlCmd.Parameters.Add(ParIdHospital);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public static string InsertarUsuario(string nombreUsaurio,string contraseña,  string nombre, string apellido, string email, string rol)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 60;
                ParUsuario.Value = nombreUsaurio;
                SqlCmd.Parameters.Add(ParUsuario);


                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@contraseña";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 60;
                ParContraseña.Value = contraseña;
                SqlCmd.Parameters.Add(ParContraseña);


                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 60;
                ParNombre.Value = nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido = new SqlParameter();
                ParApellido.ParameterName = "@apellido";
                ParApellido.SqlDbType = SqlDbType.VarChar;
                ParApellido.Size = 60;
                ParApellido.Value = apellido;
                SqlCmd.Parameters.Add(ParApellido);

                SqlParameter ParRol = new SqlParameter();
                ParRol.ParameterName = "@rol";
                ParRol.SqlDbType = SqlDbType.VarChar;
                ParRol.Size = 60;
                ParRol.Value = rol;
                SqlCmd.Parameters.Add(ParRol);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 60;
                ParEmail.Value = email;
                SqlCmd.Parameters.Add(ParEmail);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

            


        public bool Login(string usuario, string contraseña)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "Validar_Acceso";
                    comand.Parameters.AddWithValue("@usuario", usuario);
                    comand.Parameters.AddWithValue("@contraseña", contraseña);
              
                    comand.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CaUsuario.IdUsuario = reader.GetInt32(0);
                            CaUsuario.Usuario= reader.GetString(1);
                            CaUsuario.Contraseña = reader.GetString(2);
                            CaUsuario.Nombre = reader.GetString(3);
                            CaUsuario.Apellido = reader.GetString(4);
                            CaUsuario.Rol = reader.GetString(5);
                            CaUsuario.Email = reader.GetString(6);
                    

                        }

                        return true;
                    }
                    else
                        return false;
                }
            }

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
