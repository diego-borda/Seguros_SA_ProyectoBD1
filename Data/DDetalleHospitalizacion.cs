using SegurosSA.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DDetalleHospitalizacion
    {
        public static DataTable MostrarDetallesHosp(int idhosp)
        {
            DataTable DtResultado = new DataTable("MostrarDetallesHosp");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_DetalleHospitalizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdHosp = new SqlParameter();
                ParIdHosp.ParameterName = "@idHospitalizacion";
                ParIdHosp.SqlDbType = SqlDbType.Int;
                ParIdHosp.Value = idhosp;
                SqlCmd.Parameters.Add(ParIdHosp);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static object BuscarDetalleHosp(int idhosp,string dato)
        {
            DataTable DtResultado = new DataTable("BuscarContrato");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_DetalleHosp";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdHosp = new SqlParameter();
                ParIdHosp.ParameterName = "@idHospitalizacion";
                ParIdHosp.SqlDbType = SqlDbType.Int;
                ParIdHosp.Value = idhosp;
                SqlCmd.Parameters.Add(ParIdHosp);

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

        public static string EstadoDetalleHosp(int IdDetalle)
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
                SqlCmd.CommandText = "Estado_DetalleHosp";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdDetalle = new SqlParameter();
                ParIdDetalle.ParameterName = "@idDetalle";
                ParIdDetalle.SqlDbType = SqlDbType.Int;
                ParIdDetalle.Value = IdDetalle;
                SqlCmd.Parameters.Add(ParIdDetalle);


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

        public static string NuevoDetalleHosp(int IdHosp, int IdContrato, DateTime Fecha)
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
                SqlCmd.CommandText = "Gasto_EnDetalleHosp";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdHosp = new SqlParameter();
                ParIdHosp.ParameterName = "@idHosp";
                ParIdHosp.SqlDbType = SqlDbType.Int;
                ParIdHosp.Value = IdHosp;
                SqlCmd.Parameters.Add(ParIdHosp);

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@idContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = IdContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                //Ejecutamos nuestro comando
                rpta = (string)SqlCmd.ExecuteScalar();
                //rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
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

        public static string ValidarDetalleHosp(int IdHosp, int IdContrato, DateTime Fecha)
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
                SqlCmd.CommandText = "Validar_DetalleHosp";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdHosp = new SqlParameter();
                ParIdHosp.ParameterName = "@idHosp";
                ParIdHosp.SqlDbType = SqlDbType.Int;
                ParIdHosp.Value = IdHosp;
                SqlCmd.Parameters.Add(ParIdHosp);

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@idContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = IdContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                //Ejecutamos nuestro comando
                rpta = (string)SqlCmd.ExecuteScalar();
                //rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
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

        public static string InsertarDetalleHosp(int idHosp , int idContrato, int idGasto, float costo,string descr, DateTime fecha)
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
                SqlCmd.CommandText = "Insertar_DetalleHosp";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idHospitalizacion";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Value = idHosp;
                SqlCmd.Parameters.Add(ParIdHospital);

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@idContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = idContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParIdGasto = new SqlParameter();
                ParIdGasto.ParameterName = "@idGasto";
                ParIdGasto.SqlDbType = SqlDbType.Int;
                ParIdGasto.Value = idGasto;
                SqlCmd.Parameters.Add(ParIdGasto);


                 SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@Costo";
                ParCosto.SqlDbType = SqlDbType.Float;
                ParCosto.Value = costo;
                SqlCmd.Parameters.Add(ParCosto);
                
                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descr";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 100;
                ParDescripcion.Value = descr;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = fecha;
                SqlCmd.Parameters.Add(ParFecha);



                //Ejecutamos nuestro comando
                //rpta = (string)SqlCmd.ExecuteScalar();
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

        public static string EditarDetalleHosp(int idDetalle,int idHosp,int idContrato ,int idGasto,  float costo, string descr, DateTime fecha)
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
                SqlCmd.CommandText = "Editar_DetalleHosp";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdDetalle = new SqlParameter();
                ParIdDetalle.ParameterName = "@idDetalle";
                ParIdDetalle.SqlDbType = SqlDbType.Int;
                ParIdDetalle.Value = idDetalle;
                SqlCmd.Parameters.Add(ParIdDetalle);

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idHospitalizacion";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Value = idHosp;
                SqlCmd.Parameters.Add(ParIdHospital);

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@idContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = idContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParIdGasto = new SqlParameter();
                ParIdGasto.ParameterName = "@idGasto";
                ParIdGasto.SqlDbType = SqlDbType.Int;
                ParIdGasto.Value = idGasto;
                SqlCmd.Parameters.Add(ParIdGasto);

                SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@Costo";
                ParCosto.SqlDbType = SqlDbType.Float;
                ParCosto.Value = costo;
                SqlCmd.Parameters.Add(ParCosto);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descr";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 100;
                ParDescripcion.Value = descr;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = fecha;
                SqlCmd.Parameters.Add(ParFecha);



                //Ejecutamos nuestro comando
                //rpta = (string)SqlCmd.ExecuteScalar();
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
