using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Data
{
    public class DZona_Hospital
    {
        public static DataTable MostrarZona_Hospital()
        {
            DataTable DtResultado = new DataTable("MostrarZona_Hospital");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_ZonaHospital";
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

        public static string EditarZona_Hospital(int idZonaHospital, int idZona, int idHospital)
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
                SqlCmd.CommandText = "Editar_ZonaHospital";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdZonaHospital = new SqlParameter();
                ParIdZonaHospital.ParameterName = "@idZonaHospital";
                ParIdZonaHospital.SqlDbType = SqlDbType.Int;

                ParIdZonaHospital.Value = idZonaHospital;
                SqlCmd.Parameters.Add(ParIdZonaHospital);

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParIdZonas = new SqlParameter();
                ParIdZonas.ParameterName = "@idZona";
                ParIdZonas.SqlDbType = SqlDbType.Int;

                ParIdZonas.Value = idZona;
                SqlCmd.Parameters.Add(ParIdZonas);

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idHospital";
                ParIdHospital.SqlDbType = SqlDbType.Int;

                ParIdHospital.Value = idHospital;
                SqlCmd.Parameters.Add(ParIdHospital);


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

        public static DataTable ValidarZona_Hospital(int idZona, int idHospital)
        {
            DataTable DtResultado = new DataTable("ValidarZona_Hospital");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_ZonaHospital";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdZonas = new SqlParameter();
                ParIdZonas.ParameterName = "@idZona";
                ParIdZonas.SqlDbType = SqlDbType.Int;

                ParIdZonas.Value = idZona;
                SqlCmd.Parameters.Add(ParIdZonas);

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idHospital";
                ParIdHospital.SqlDbType = SqlDbType.Int;

                ParIdHospital.Value = idHospital;
                SqlCmd.Parameters.Add(ParIdHospital);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }



        public static string InsertarZona_Hospital(int idZona, int idHospital)
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
                SqlCmd.CommandText = "Insertar_ZonaHospital";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdZona = new SqlParameter();
                ParIdZona.ParameterName = "@idzona";
                ParIdZona.SqlDbType = SqlDbType.Int;
                ParIdZona.Size = 60;
                ParIdZona.Value = idZona;
                SqlCmd.Parameters.Add(ParIdZona);

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idhospital";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Size = 60;
                ParIdHospital.Value = idHospital;
                SqlCmd.Parameters.Add(ParIdHospital);

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


        public static object BuscarZona_Hospital(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarZona_Hospital");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_ZonaHospital";
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

        public static object Buscar_ZonayHospital(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarZona_Hospital");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_ZonayHospital";
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

        public static object Buscar_ZonayHospital2(string dato,string NombreZona)
        {
            DataTable DtResultado = new DataTable("BuscarZona_Hospital");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_ZonayHospital2";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@Dato";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = dato;
                SqlCmd.Parameters.Add(ParDato);

                SqlParameter ParNZona = new SqlParameter();
                ParNZona.ParameterName = "@NZona";
                ParNZona.SqlDbType = SqlDbType.VarChar;
                ParNZona.Size = 60;
                ParNZona.Value = NombreZona;
                SqlCmd.Parameters.Add(ParNZona);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static string EstadoZona_Hospital(int idZonaHospital)
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
                SqlCmd.CommandText = "Estado_ZonaHospital";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdZona = new SqlParameter();
                ParIdZona.ParameterName = "@idZonaHospital";
                ParIdZona.SqlDbType = SqlDbType.Int;
                ParIdZona.Value = idZonaHospital;
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
    }
}
