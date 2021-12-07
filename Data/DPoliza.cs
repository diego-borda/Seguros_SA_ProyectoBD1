using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Data
{
    public class DPoliza
    {
        public static DataTable MostrarPoliza()
        {
            DataTable DtResultado = new DataTable("MostrarPoliza");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Poliza";
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

        public static DataTable ValidarPoliza(string tipo)
        {
            DataTable DtResultado = new DataTable("ValidarPoliza");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_Poliza";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@tipo";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 60;
                ParNombre.Value = tipo;
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

        public static DataTable ValidarPolizaEditar(int idPoliza,string tipo)
        {
            DataTable DtResultado = new DataTable("ValidarPoliza");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_Poliza_Editar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPoliza = new SqlParameter();
                ParIdPoliza.ParameterName = "@idpoliza";
                ParIdPoliza.SqlDbType = SqlDbType.Int;
                ParIdPoliza.Value = idPoliza;
                SqlCmd.Parameters.Add(ParIdPoliza);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@tipo";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 60;
                ParNombre.Value = tipo;
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

        public static string InsertarPoliza(string tipo, float costo)
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
                SqlCmd.CommandText = "Insertar_Poliza";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 60;
                ParTipo.Value = tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@costo";
                ParCosto.SqlDbType = SqlDbType.Float;
                ParCosto.Size = 60;
                ParCosto.Value = costo;
                SqlCmd.Parameters.Add(ParCosto);

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

        public static string EditarPoliza(int idPoliza, string tipo, float costo)
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
                SqlCmd.CommandText = "Editar_Poliza";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParIdPoliza = new SqlParameter();
                ParIdPoliza.ParameterName = "@IdPoliza";
                ParIdPoliza.SqlDbType = SqlDbType.Int;

                ParIdPoliza.Value = idPoliza;
                SqlCmd.Parameters.Add(ParIdPoliza);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 60;
                ParTipo.Value = tipo;
                SqlCmd.Parameters.Add(ParTipo);

                 SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@costo";
                ParCosto.SqlDbType = SqlDbType.Float;
                ParCosto.Size = 60;
                ParCosto.Value = costo;
                SqlCmd.Parameters.Add(ParCosto);

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

        public static object BuscarPoliza(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarMedico");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_Poliza";
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
