
using Data;
using SegurosSA.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Controllers
{
    public class CConsultas
    {
        public static DataTable MostrarConsultas()
        {
            return DConsultas.MostrarConsultas();
        }


        public static string EstadoConsulta(int IdConsulta)
        {
            return DConsultas.EstadoConsulta(IdConsulta);
        }

        public static object BuscarConsulta(string dato)
        {
            return DConsultas.BuscarConsulta(dato);
        }

        public static string CancelarConsulta(int IdConsulta)
        {
            return DConsultas.CancelarConsulta(IdConsulta);
        }

        public static string NuevaConsulta(int IdContrato,  float gastosAdic,DateTime Fecha)
        {
            return DConsultas.NuevaConsulta( IdContrato,  gastosAdic,Fecha);
        }

        public static string InsertarConsulta(int idHospital, int idmedico, int IdContrato, string especialidad, DateTime fecha, float gastosAdic)
        {
            return DConsultas.InsertarConsulta(idHospital,idmedico, IdContrato, especialidad, fecha, gastosAdic);
        }

        public static string ValidacionConsulta( int IdContrato,DateTime fecha)
        {
            return DConsultas.ValidarConsulta( IdContrato,fecha);
        }

        public static string ValidacionConsultaEditar(int IdContrato, int IdConsulta, DateTime fecha)
        {
            return DConsultas.ValidarConsultaEditar(IdContrato, IdConsulta, fecha);
        }

        public static string EditarConsulta(int idConsulta, int idHospital, int idmedico, int IdContrato, string especialidad, DateTime fecha, float gastosAdic)
        {
            return DConsultas.EditarConsulta(idConsulta,idHospital, idmedico, IdContrato, especialidad, fecha, gastosAdic);
        }

    }
}
