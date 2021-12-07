using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CDetalleHospitalizacion
    {
        public static DataTable MostrarDetallesHosp(int idhosp)
        {
            return DDetalleHospitalizacion.MostrarDetallesHosp(idhosp);
        }

        public static object BuscarDetalleHosp(int idhosp, string dato)
        {
            return DDetalleHospitalizacion.BuscarDetalleHosp(idhosp, dato);
        }

        public static string EstadoDetalleHosp(int IdDetalle)
        {
            return DDetalleHospitalizacion.EstadoDetalleHosp(IdDetalle);
        }

        public static string InsertarDetalleHosp(int idHosp,int idContrato ,int idGasto, float costo, string descr, DateTime fecha)
        {
            return DDetalleHospitalizacion.InsertarDetalleHosp(idHosp, idContrato, idGasto, costo, descr, fecha);
        }

        public static string EditarDetalleHosp(int idDetalle, int idHosp, int idContrato, int idGasto,  float costo, string descr, DateTime fecha)
        {
            return DDetalleHospitalizacion.EditarDetalleHosp(idDetalle, idHosp, idContrato, idGasto,costo, descr, fecha);
        }

        public static string NuevoDetalleHosp(int IdHosp, int IdContrato, DateTime Fecha)
        {
            return DDetalleHospitalizacion.NuevoDetalleHosp(IdHosp, IdContrato, Fecha);
        }

        public static string ValidarDetalleHosp(int IdHosp, int IdContrato, DateTime Fecha)
        {
            return DDetalleHospitalizacion.ValidarDetalleHosp(IdHosp, IdContrato, Fecha);
        }
    }
}
