using SegurosSA.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Controllers
{
   public class CZona
    {
        public static DataTable MostrarZona()
        {
            return DZona.MostrarZona();
        }

        public static string InsertarZona(string nombre)
        {
            return DZona.InsertarZona(nombre);
        }

        public static string EditarZona(int idZona, string nombre)
        {
            return DZona.EditarZona(idZona, nombre);
        }

           public static string EstadoZona(int IdZona)
        {
            return DZona.EstadoZona(IdZona);
        }

        public static object BuscarZona(string dato)
        {
            return DZona.BuscarZona(dato);
        }
        public static DataTable ValidarZona(string nombreZona)
        {
            return DZona.ValidarZona(nombreZona);
        }

        public static DataTable ValidarZonaEditar(int idZona,string nombreZona)
        {
            return DZona.ValidarZonaEditar(idZona,nombreZona);
        }
    }
}
