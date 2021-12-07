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
    public class DContrato
    {
        public static DataTable MostrarContratos()
        {
            DataTable DtResultado = new DataTable("MostrarContratos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_ContratoPoliza";
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

        public static DataTable MostrarContratosAu()
        {
            DataTable DtResultado = new DataTable("MostrarContratos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_ContratoPoliza";
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


        public static object BuscarContratosH(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarContrato");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_ContratoPoliza_Aux";
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

        public static DataTable MostrarContratosCategoria()
        {
            DataTable DtResultado = new DataTable("MostrarContratos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_ContratoPoliza_Categoria";
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


        public static string EstadoContrato(int IdConsulta)
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
                SqlCmd.CommandText = "Estado_ContratoPoliza";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdConsulta = new SqlParameter();
                ParIdConsulta.ParameterName = "@idcontrato";
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

        public static string CancelarContrato(int IdConsulta)
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
                SqlCmd.CommandText = "Cancelar_ContratoPoliza";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdConsulta = new SqlParameter();
                ParIdConsulta.ParameterName = "@idcontrato";
                ParIdConsulta.SqlDbType = SqlDbType.Int;
                ParIdConsulta.Value = IdConsulta;
                SqlCmd.Parameters.Add(ParIdConsulta);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() >= 1 ? "OK" : "NO se Ingreso el Registro";

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

        public static object BuscarContrato(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarContrato");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_ContratoPoliza";
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

        public static DataTable ValidarContrato(int idPoliza,int idAseg, DateTime FechaI, DateTime FechaF)
        {
            DataTable DtResultado = new DataTable("ValidarContrato");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validacion_ContratoPoliza";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPoliza = new SqlParameter();
                ParPoliza.ParameterName = "@idpoliza";
                ParPoliza.SqlDbType = SqlDbType.Int;
                ParPoliza.Value = idPoliza;
                SqlCmd.Parameters.Add(ParPoliza);

                SqlParameter ParAseg = new SqlParameter();
                ParAseg.ParameterName = "@idasegurado";
                ParAseg.SqlDbType = SqlDbType.Int;
                ParAseg.Value = idAseg;
                SqlCmd.Parameters.Add(ParAseg);

                SqlParameter ParFechaI = new SqlParameter();
                ParFechaI.ParameterName = "@fechaI";
                ParFechaI.SqlDbType = SqlDbType.Date;
                ParFechaI.Size = 60;
                ParFechaI.Value = FechaI;
                SqlCmd.Parameters.Add(ParFechaI);

                SqlParameter ParFechaF = new SqlParameter();
                ParFechaF.ParameterName = "@fechaf";
                ParFechaF.SqlDbType = SqlDbType.Date;
                ParFechaF.Size = 60;
                ParFechaF.Value = FechaF;
                SqlCmd.Parameters.Add(ParFechaF);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static DataTable ValidarContrato_Editar(int idPoliza, int idContrato, int idAseg, DateTime FechaI, DateTime FechaF)
        {
            DataTable DtResultado = new DataTable("ValidarContrato");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = CONEXION.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validacion_ContratoPoliza2";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPoliza = new SqlParameter();
                ParPoliza.ParameterName = "@idpoliza";
                ParPoliza.SqlDbType = SqlDbType.Int;
                ParPoliza.Value = idPoliza;
                SqlCmd.Parameters.Add(ParPoliza);

                SqlParameter ParContrato = new SqlParameter();
                ParContrato.ParameterName = "@idcontrato";
                ParContrato.SqlDbType = SqlDbType.Int;
                ParContrato.Value = idContrato;
                SqlCmd.Parameters.Add(ParContrato);

                SqlParameter ParAseg = new SqlParameter();
                ParAseg.ParameterName = "@idasegurado";
                ParAseg.SqlDbType = SqlDbType.Int;
                ParAseg.Value = idAseg;
                SqlCmd.Parameters.Add(ParAseg);

                SqlParameter ParFechaI = new SqlParameter();
                ParFechaI.ParameterName = "@fechaI";
                ParFechaI.SqlDbType = SqlDbType.Date;
                ParFechaI.Size = 60;
                ParFechaI.Value = FechaI;
                SqlCmd.Parameters.Add(ParFechaI);

                SqlParameter ParFechaF = new SqlParameter();
                ParFechaF.ParameterName = "@fechaf";
                ParFechaF.SqlDbType = SqlDbType.Date;
                ParFechaF.Size = 60;
                ParFechaF.Value = FechaF;
                SqlCmd.Parameters.Add(ParFechaF);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static string InsertarContrato(int idPoliza, int IdAseg,DateTime FechaI,DateTime FechaF, string descripcion,float costo,float valorCob)
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
                SqlCmd.CommandText = "Nuevo_ContratoPoliza";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParPoliza = new SqlParameter();
                ParPoliza.ParameterName = "@idpoliza";
                ParPoliza.SqlDbType = SqlDbType.Int;
                ParPoliza.Value = idPoliza;
                SqlCmd.Parameters.Add(ParPoliza);

                SqlParameter ParAseg = new SqlParameter();
                ParAseg.ParameterName = "@idasegurado";
                ParAseg.SqlDbType = SqlDbType.Int;
                ParAseg.Value = IdAseg;
                SqlCmd.Parameters.Add(ParAseg);

                SqlParameter ParFechaI = new SqlParameter();
                ParFechaI.ParameterName = "@FechaI";
                ParFechaI.SqlDbType = SqlDbType.Date;
                ParFechaI.Size = 60;
                ParFechaI.Value = FechaI;
                SqlCmd.Parameters.Add(ParFechaI);

                SqlParameter ParFechaF = new SqlParameter();
                ParFechaF.ParameterName = "@FechaF";
                ParFechaF.SqlDbType = SqlDbType.Date;
                ParFechaF.Size =60;
                ParFechaF.Value = FechaF;
                SqlCmd.Parameters.Add(ParFechaF);

                SqlParameter ParDesc = new SqlParameter();
                ParDesc.ParameterName = "@descripcion";
                ParDesc.SqlDbType = SqlDbType.VarChar;
                ParDesc.Size = 500;
                ParDesc.Value = descripcion;
                SqlCmd.Parameters.Add(ParDesc);

                SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@costo";
                ParCosto.SqlDbType = SqlDbType.Float;
                ParCosto.Value = costo;
                SqlCmd.Parameters.Add(ParCosto);

                SqlParameter ParValorCob = new SqlParameter();
                ParValorCob.ParameterName = "@valorCob";
                ParValorCob.SqlDbType = SqlDbType.Float;
                ParValorCob.Value = valorCob;
                SqlCmd.Parameters.Add(ParValorCob);

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

        public static string EditarContrato(int idContrato,int idPoliza, int IdAseg, DateTime FechaI, DateTime FechaF, string descripcion, float costo, float valorCob)
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
                SqlCmd.CommandText = "Editar_ContratoPoliza";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParContrato = new SqlParameter();
                ParContrato.ParameterName = "@idcontrato";
                ParContrato.SqlDbType = SqlDbType.Int;
                ParContrato.Value = idContrato;
                SqlCmd.Parameters.Add(ParContrato);

                SqlParameter ParPoliza = new SqlParameter();
                ParPoliza.ParameterName = "@idpoliza";
                ParPoliza.SqlDbType = SqlDbType.Int;
                ParPoliza.Value = idPoliza;
                SqlCmd.Parameters.Add(ParPoliza);

                SqlParameter ParAseg = new SqlParameter();
                ParAseg.ParameterName = "@idasegurado";
                ParAseg.SqlDbType = SqlDbType.Int;
                ParAseg.Value = IdAseg;
                SqlCmd.Parameters.Add(ParAseg);

                SqlParameter ParFechaI = new SqlParameter();
                ParFechaI.ParameterName = "@FechaI";
                ParFechaI.SqlDbType = SqlDbType.Date;
                ParFechaI.Size = 60;
                ParFechaI.Value = FechaI;
                SqlCmd.Parameters.Add(ParFechaI);

                SqlParameter ParFechaF = new SqlParameter();
                ParFechaF.ParameterName = "@FechaF";
                ParFechaF.SqlDbType = SqlDbType.Date;
                ParFechaF.Size = 60;
                ParFechaF.Value = FechaF;
                SqlCmd.Parameters.Add(ParFechaF);

                SqlParameter ParDesc = new SqlParameter();
                ParDesc.ParameterName = "@descripcion";
                ParDesc.SqlDbType = SqlDbType.VarChar;
                ParDesc.Size = 500;
                ParDesc.Value = descripcion;
                SqlCmd.Parameters.Add(ParDesc);

                SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@costo";
                ParCosto.SqlDbType = SqlDbType.Float;
                ParCosto.Value = costo;
                SqlCmd.Parameters.Add(ParCosto);

                SqlParameter ParValorCob = new SqlParameter();
                ParValorCob.ParameterName = "@valorCob";
                ParValorCob.SqlDbType = SqlDbType.Float;
                ParValorCob.Value = valorCob;
                SqlCmd.Parameters.Add(ParValorCob);

                rpta = SqlCmd.ExecuteNonQuery() >= 1 ? "OK" : "NO se Ingreso el Registro";

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
