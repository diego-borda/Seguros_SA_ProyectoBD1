using SegurosSA.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Controllers
{
    public class CZona_Hospital
    {
        public static DataTable MostrarZona_Hospital()
        {
            return DZona_Hospital.MostrarZona_Hospital();
        }

        public static object BuscarZona_Hospital(string dato)
        {
            return DZona_Hospital.BuscarZona_Hospital(dato);
        }

        public static object Buscar_ZonayHospital(string dato)
        {
            return DZona_Hospital.Buscar_ZonayHospital(dato);
        }

        public static object Buscar_ZonayHospital2(string dato, string nombreZ)
        {
            return DZona_Hospital.Buscar_ZonayHospital2(dato, nombreZ);
        }

        public static string InsertarZona_Hospital(int idZona, int idHospital)
        {
            return DZona_Hospital.InsertarZona_Hospital(idZona, idHospital);
        }

        public static string EditarZona_Hospital(int idZonaHospital, int idZona, int idHospital)
        {
            return DZona_Hospital.EditarZona_Hospital(idZonaHospital, idZona, idHospital);
        }

        public static string EstadoZona_ZonaHospital(int IdZonaHospital)
        {
            return DZona_Hospital.EstadoZona_Hospital(IdZonaHospital);
        }

        public static DataTable Validar_ZonaHospital(int idZona, int idhospital)
        {
            return DZona_Hospital.ValidarZona_Hospital(idZona, idhospital);
        }
    }
}
