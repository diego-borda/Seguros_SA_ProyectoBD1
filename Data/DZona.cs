using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Data
{
    public class DZona
    {
        public static DataTable MostrarZona()
        {
            DataTable DtResultado = new DataTable("MostrarZona");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Zona";
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

        public static string EstadoZona(int idZona)
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
                SqlCmd.CommandText = "Estado_Zonas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdZona = new SqlParameter();
                ParIdZona.ParameterName = "@idZona";
                ParIdZona.SqlDbType = SqlDbType.Int;
                ParIdZona.Value = idZona;
                SqlCmd.Parameters.Add(ParIdZona);


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

        public static string InsertarZona(string nombre)
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
                SqlCmd.CommandText = "Insertar_Zona";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@nombre";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 60;
                ParTipo.Value = nombre;
                SqlCmd.Parameters.Add(ParTipo);

          

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

        public static string EditarZona(int idZona, string nombre)
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
                SqlCmd.CommandText = "Editar_Zona";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParIdZonas = new SqlParameter();
                ParIdZonas.ParameterName = "@IdZona";
                ParIdZonas.SqlDbType = SqlDbType.Int;

                ParIdZonas.Value = idZona;
                SqlCmd.Parameters.Add(ParIdZonas);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 60;
                ParNombre.Value = nombre;
                SqlCmd.Parameters.Add(ParNombre);

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

        public static object BuscarZona(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarMedico");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_Zona";
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

        public static DataTable ValidarZona(string nombreZona)
        {
            DataTable DtResultado = new DataTable("ValidarZona");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_Zonas";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombreZona";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 60;
                ParNombre.Value = nombreZona;
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

        public static DataTable ValidarZonaEditar(int idZona,string nombreZona)
        {
            DataTable DtResultado = new DataTable("ValidarZona");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_Zonas_Editar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdZonas = new SqlParameter();
                ParIdZonas.ParameterName = "@idZona";
                ParIdZonas.SqlDbType = SqlDbType.Int;
                ParIdZonas.Value = idZona;
                SqlCmd.Parameters.Add(ParIdZonas);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombreZona";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 60;
                ParNombre.Value = nombreZona;
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
    }
}
