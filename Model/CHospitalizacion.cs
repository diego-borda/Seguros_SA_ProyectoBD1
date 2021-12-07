using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CHospitalizacion
    {
        public static DataTable MostrarHospitalizacion()
        {
            return DHospitalizacion.MostrarHospitalizacion();
        }

        public static object BuscarHospitalizacion(string dato)
        {
            return DHospitalizacion.BuscarHospitalizacion(dato);
        }

        public static string CancelarHospitalizacion( int idHospitalizacion)
        {
            return DHospitalizacion.CancelarHospitalizacion(idHospitalizacion);
        }

        public static string EstadoHospitalizacion(int idHospitalizacion)
        {
            return DHospitalizacion.EstadoHospital(idHospitalizacion);
        }

        public static string ValidarHospitalizacion(int IdContrato, DateTime FechaI, DateTime FechaF)
        {
            return DHospitalizacion.ValidarHospitalizacion(IdContrato,FechaI, FechaF);
        }

        public static string ValidarHospitalizacion_Editar(int idHospitalizacion, int idContrato, DateTime FechaI, DateTime FechaF)
        {
            return DHospitalizacion.ValidarHospitalizacion_Editar(idHospitalizacion, idContrato, FechaI, FechaF);
        }

        public static string InsertarHospitalizacion(int idHospital, int idMedico, int idContrato, DateTime FechaI, DateTime FechaF)
        {
            return DHospitalizacion.InsertarHospitalizacion(idHospital,idMedico,idContrato,FechaI,FechaF);
        }

        public static string EditarHospitalizacion(int idHospitalizacion, int idHospital, int idMedico, int idContrato, DateTime FechaI, DateTime FechaF)
        {
            return DHospitalizacion.EditarHospitalizacion(idHospitalizacion, idHospital, idMedico, idContrato,FechaI,FechaF);
        }
     }
}
