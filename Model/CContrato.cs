
using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CContrato
    {
        public static DataTable MostrarContratos()
        {
            return DContrato.MostrarContratos();
        }

        public static DataTable MostrarContratosCategoria()
        {
            return DContrato.MostrarContratosCategoria();
        }
        public static string EstadoContrato(int IdConsulta)
        {
            return DContrato.EstadoContrato(IdConsulta);
        }

        public static string CancelarContrato(int IdConsulta)
        {
            return DContrato.CancelarContrato(IdConsulta);
        }

        public static object BuscarContrato(string dato)
        {
            return DContrato.BuscarContrato(dato);
        }
        public static object BuscarContratosH(string dato)
        {
            return DContrato.BuscarContratosH(dato);
        }

        public static DataTable ValidarContrato(int idPoliza, int idAseg, DateTime FechaI, DateTime FechaF)
        {
            return DContrato.ValidarContrato(idPoliza, idAseg, FechaI, FechaF);
        }

        public static DataTable ValidarContrato_Editar(int idPoliza, int idContrato,int idAseg, DateTime FechaI, DateTime FechaF)
        {
            return DContrato.ValidarContrato_Editar(idPoliza, idContrato, idAseg, FechaI, FechaF);
        }

        public static string InsertarContrato(int idPoliza, int IdAseg, DateTime FechaI, DateTime FechaF, string descripcion, float costo, float valorCob)
        {
            return DContrato.InsertarContrato(idPoliza, IdAseg, FechaI, FechaF, descripcion, costo, valorCob);
        }

        public static string EditarContrato(int idContrato, int idPoliza, int IdAseg, DateTime FechaI, DateTime FechaF, string descripcion, float costo, float valorCob)
        {
            return DContrato.EditarContrato(idContrato, idPoliza, IdAseg, FechaI, FechaF, descripcion, costo, valorCob);
        }
    }
}
