using SegurosSA.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Controllers
{
   public class CPoliza
    {
        public static DataTable MostrarPoliza()
        {
            return DPoliza.MostrarPoliza();
        }

        public static string InsertarPoliza(string tipo, float costo)
        {
            return DPoliza.InsertarPoliza(tipo, costo);
        }

        public static string EditarPoliza(int idPoliza, string tipo, float costo)
        {
            return DPoliza.EditarPoliza(idPoliza, tipo, costo);
        }

        public static string EstadoZona(int IdZona)
        {
            return DZona.EstadoZona(IdZona);
        }

    public static object BuscarPoliza(string dato)
        {
            return DPoliza.BuscarPoliza(dato);
        }
        public static DataTable ValidarPoliza(string tipo)
        {
            return DPoliza.ValidarPoliza(tipo);
        }

        public static DataTable ValidarPolizaEditar(int idPoliza, string tipo)
        {
            return DPoliza.ValidarPolizaEditar(idPoliza, tipo);
        }
        }
}
