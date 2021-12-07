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
    public class DConsultas
    {
        public static DataTable MostrarConsultas()
        {
            DataTable DtResultado = new DataTable("MostrarConsultas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Consultas";
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

        public static string EstadoConsulta(int IdConsulta)
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
                SqlCmd.CommandText = "Estado_Consulta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdConsulta = new SqlParameter();
                ParIdConsulta.ParameterName = "@idconsulta";
                ParIdConsulta.SqlDbType = SqlDbType.Int;
                ParIdConsulta.Value = IdConsulta;
                SqlCmd.Parameters.Add(ParIdConsulta);


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

        public static object BuscarConsulta(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarConsulta");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_Consulta";
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

        public static string CancelarConsulta(int IdConsulta)
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
                SqlCmd.CommandText = "Cancelar_Consulta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdConsulta = new SqlParameter();
                ParIdConsulta.ParameterName = "@idconsulta";
                ParIdConsulta.SqlDbType = SqlDbType.Int;
                ParIdConsulta.Value = IdConsulta;
                SqlCmd.Parameters.Add(ParIdConsulta);


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

        public static string InsertarConsulta(int idHospital, int idmedico, int IdContrato, string especialidad, DateTime fecha, float gastosAdic)
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
                SqlCmd.CommandText = "Insertar_Consulta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idHospital";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Value = idHospital;
                SqlCmd.Parameters.Add(ParIdHospital);

                SqlParameter ParIdMedico = new SqlParameter();
                ParIdMedico.ParameterName = "@idmedico";
                ParIdMedico.SqlDbType = SqlDbType.Int;
                ParIdMedico.Value = idmedico;
                SqlCmd.Parameters.Add(ParIdMedico);

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@IdContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = IdContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParEspecialidad = new SqlParameter();
                ParEspecialidad.ParameterName = "@especialidad";
                ParEspecialidad.SqlDbType = SqlDbType.VarChar;
                ParEspecialidad.Size = 100;
                ParEspecialidad.Value = especialidad;
                SqlCmd.Parameters.Add(ParEspecialidad);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Size = 60;
                ParFecha.Value = fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParGastosAd = new SqlParameter();
                ParGastosAd.ParameterName = "@gastosAdic";
                ParGastosAd.SqlDbType = SqlDbType.Float;
                ParGastosAd.Value = gastosAdic;
                SqlCmd.Parameters.Add(ParGastosAd);

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

        public static string NuevaConsulta(int IdContrato,  float gastosAdic, DateTime Fecha)
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
                SqlCmd.CommandText = "Nueva_Consulta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@IdContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = IdContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParGastosAd = new SqlParameter();
                ParGastosAd.ParameterName = "@gastosAdic";
                ParGastosAd.SqlDbType = SqlDbType.Float;
                ParGastosAd.Value = gastosAdic;
                SqlCmd.Parameters.Add(ParGastosAd);

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

        public static string ValidarConsulta(int IdContrato ,DateTime fecha)
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
                SqlCmd.CommandText = "Validacion_Consulta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@IdContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = IdContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Size = 60;
                ParFecha.Value = fecha;
                SqlCmd.Parameters.Add(ParFecha);

                rpta = (string)SqlCmd.ExecuteScalar();
                
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

        public static string ValidarConsultaEditar(int IdContrato, int IdConsulta, DateTime fecha)
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
                SqlCmd.CommandText = "Validacion_Consulta2";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@IdContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = IdContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParIdConsulta = new SqlParameter();
                ParIdConsulta.ParameterName = "@IdConsulta";
                ParIdConsulta.SqlDbType = SqlDbType.Int;
                ParIdConsulta.Value = IdConsulta;
                SqlCmd.Parameters.Add(ParIdConsulta);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Size = 60;
                ParFecha.Value = fecha;
                SqlCmd.Parameters.Add(ParFecha);

                rpta = (string)SqlCmd.ExecuteScalar();

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

        public static string EditarConsulta(int idConsulta,int idHospital, int idmedico, int IdContrato, string especialidad, DateTime fecha, float gastosAdic)
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
                SqlCmd.CommandText = "Editar_Consulta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdConsulta = new SqlParameter();
                ParIdConsulta.ParameterName = "@idConsulta";
                ParIdConsulta.SqlDbType = SqlDbType.Int;
                ParIdConsulta.Value = idConsulta;
                SqlCmd.Parameters.Add(ParIdConsulta);

                SqlParameter ParIdHospital = new SqlParameter();
                ParIdHospital.ParameterName = "@idHospital";
                ParIdHospital.SqlDbType = SqlDbType.Int;
                ParIdHospital.Value = idHospital;
                SqlCmd.Parameters.Add(ParIdHospital);

                SqlParameter ParIdMedico = new SqlParameter();
                ParIdMedico.ParameterName = "@idmedico";
                ParIdMedico.SqlDbType = SqlDbType.Int;
                ParIdMedico.Value = idmedico;
                SqlCmd.Parameters.Add(ParIdMedico);

                SqlParameter ParIdContrato = new SqlParameter();
                ParIdContrato.ParameterName = "@IdContrato";
                ParIdContrato.SqlDbType = SqlDbType.Int;
                ParIdContrato.Value = IdContrato;
                SqlCmd.Parameters.Add(ParIdContrato);

                SqlParameter ParEspecialidad = new SqlParameter();
                ParEspecialidad.ParameterName = "@especialidad";
                ParEspecialidad.SqlDbType = SqlDbType.VarChar;
                ParEspecialidad.Size = 100;
                ParEspecialidad.Value = especialidad;
                SqlCmd.Parameters.Add(ParEspecialidad);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Size = 60;
                ParFecha.Value = fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParGastosAd = new SqlParameter();
                ParGastosAd.ParameterName = "@gastosAdic";
                ParGastosAd.SqlDbType = SqlDbType.Float;
                ParGastosAd.Value = gastosAdic;
                SqlCmd.Parameters.Add(ParGastosAd);

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
