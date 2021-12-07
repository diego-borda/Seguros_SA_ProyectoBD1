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
    public class DHospitalizacion
    {
        public static DataTable MostrarHospitalizacion()
        {
            DataTable DtResultado = new DataTable("MostrarHospital");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Hospitalizacion";
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

        public static string EstadoHospital(int idHospitalizacion)
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
                SqlCmd.CommandText = "Estado_Hospitalizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idhospitalizacion";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Value = idHospitalizacion;
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

        public static object BuscarHospitalizacion(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarHospital");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_Hospitalizacion";
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

        public static string CancelarHospitalizacion(int idHospitalizacion)
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
                SqlCmd.CommandText = "Cancelar_Hospitalizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idhospitalizacion";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Value = idHospitalizacion;
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

        public static string ValidarHospitalizacion(int IdContrato, DateTime FechaI,DateTime FechaF)
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
                SqlCmd.CommandText = "Validacion_Hospitalizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@IdContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = IdContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParFechaI = new SqlParameter();
                ParFechaI.ParameterName = "@fechaI";
                ParFechaI.SqlDbType = SqlDbType.DateTime;
                ParFechaI.Value = FechaI;
                SqlCmd.Parameters.Add(ParFechaI);

                SqlParameter ParFechaF = new SqlParameter();
                ParFechaF.ParameterName = "@fechaF";
                ParFechaF.SqlDbType = SqlDbType.DateTime;
                ParFechaF.Value = FechaF;
                SqlCmd.Parameters.Add(ParFechaF);

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

        public static string ValidarHospitalizacion_Editar(int idHospitalizacion, int idContrato, DateTime FechaI, DateTime FechaF)
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
                SqlCmd.CommandText = "Validacion_Hospitalizacion2";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdHospit = new SqlParameter();
                ParIdHospit.ParameterName = "@idhospitalizacion";
                ParIdHospit.SqlDbType = SqlDbType.Int;
                ParIdHospit.Value = idHospitalizacion;
                SqlCmd.Parameters.Add(ParIdHospit);

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@IdContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = idContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParFechaI = new SqlParameter();
                ParFechaI.ParameterName = "@fechaI";
                ParFechaI.SqlDbType = SqlDbType.DateTime;
                ParFechaI.Value = FechaI;
                SqlCmd.Parameters.Add(ParFechaI);

                SqlParameter ParFechaF = new SqlParameter();
                ParFechaF.ParameterName = "@fechaF";
                ParFechaF.SqlDbType = SqlDbType.DateTime;
                ParFechaF.Value = FechaF;
                SqlCmd.Parameters.Add(ParFechaF);

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

        public static string InsertarHospitalizacion(int idHospital, int idMedico, int  idContrato, DateTime FechaI, DateTime FechaF)
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
                SqlCmd.CommandText = "Insertar_Hospitalizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdHospital= new SqlParameter();
                ParIdHospital.ParameterName = "@idHospital";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Value = idHospital;
                SqlCmd.Parameters.Add(ParIdHospital);

                SqlParameter ParIdMedico = new SqlParameter();
                ParIdMedico.ParameterName = "@idmedico";
                ParIdMedico.SqlDbType = SqlDbType.Int;
                ParIdMedico.Value = idMedico;
                SqlCmd.Parameters.Add(ParIdMedico);

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@idContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = idContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParFechaI = new SqlParameter();
                ParFechaI.ParameterName = "@fechaI";
                ParFechaI.SqlDbType = SqlDbType.Date;
                ParFechaI.Value = FechaI;
                SqlCmd.Parameters.Add(ParFechaI);

                SqlParameter ParFechaF= new SqlParameter();
                ParFechaF.ParameterName = "@fechaF";
                ParFechaF.SqlDbType = SqlDbType.Date;
                ParFechaF.Value =FechaF;
                SqlCmd.Parameters.Add(ParFechaF);


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

        public static string EditarHospitalizacion(int idHospitalizacion,int idHospital, int idMedico, int idContrato, DateTime FechaI, DateTime FechaF)
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
                SqlCmd.CommandText = "Editar_Hospitalizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdHospitaliz = new SqlParameter();
                ParIdHospitaliz.ParameterName = "@idHospitalizacion";
                ParIdHospitaliz.SqlDbType = SqlDbType.Int;
                ParIdHospitaliz.Value = idHospitalizacion;
                SqlCmd.Parameters.Add(ParIdHospitaliz);

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idHospital";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Value = idHospital;
                SqlCmd.Parameters.Add(ParIdHospital);

                SqlParameter ParIdMedico = new SqlParameter();
                ParIdMedico.ParameterName = "@idmedico";
                ParIdMedico.SqlDbType = SqlDbType.Int;
                ParIdMedico.Value = idMedico;
                SqlCmd.Parameters.Add(ParIdMedico);

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@idContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = idContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParFechaI = new SqlParameter();
                ParFechaI.ParameterName = "@fechaI";
                ParFechaI.SqlDbType = SqlDbType.Date;
                ParFechaI.Value = FechaI;
                SqlCmd.Parameters.Add(ParFechaI);

                SqlParameter ParFechaF = new SqlParameter();
                ParFechaF.ParameterName = "@fechaF";
                ParFechaF.SqlDbType = SqlDbType.Date;
                ParFechaF.Value = FechaF;
                SqlCmd.Parameters.Add(ParFechaF);


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
