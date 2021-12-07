using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SegurosSA.Data
{
    public class DHospital
    {
        public static DataTable MostrarHospital()
        {
            DataTable DtResultado = new DataTable("MostrarHospital");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Hospital";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static string InsertarHospital(string nombre, string tipo, int noDepartamentos, string direccion, string telefono)
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
                SqlCmd.CommandText = "Insertar_Hospital";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@nombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = nombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@tipo";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = tipo;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@Nodeptos";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = noDepartamentos;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@direccion";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 60;
                ParSegundoApellido.Value = direccion;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Value = telefono;
                SqlCmd.Parameters.Add(ParTelefono);


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

        public static DataTable ValidarHospital(string nombre)
        {
            DataTable DtResultado = new DataTable("ValidarPoliza");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_Hospital";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 60;
                ParNombre.Value = nombre;
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

        public static string EditarHospital(int idHospital, string nombre, string tipo, int noDepartamentos, string direccion, string telefono)
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
                SqlCmd.CommandText = "Editar_Hospital";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idHospital";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Value = idHospital;
                SqlCmd.Parameters.Add(ParIdHospital);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 60;
                Parnombre.Value = nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 60;
                ParTipo.Value = tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParDepartamentos = new SqlParameter();
                ParDepartamentos.ParameterName = "@Nodeptos";
                ParDepartamentos.SqlDbType = SqlDbType.Int;
                ParDepartamentos.Size = 60;
                ParDepartamentos.Value = noDepartamentos;
                SqlCmd.Parameters.Add(ParDepartamentos);


                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@direccion";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 500;
                ParDirección.Value = direccion;
                SqlCmd.Parameters.Add(ParDirección);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Value = telefono;
                SqlCmd.Parameters.Add(ParTelefono);



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

        public static string EstadoHospital(int idHospital)
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
                SqlCmd.CommandText = "Estado_Hospital";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@IdHospital";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Value = idHospital;
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

        public static object BuscarHospital(string dato)
        {
             DataTable DtResultado = new DataTable("BuscarHospital");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_Hospital";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@dato";
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
    }
}

