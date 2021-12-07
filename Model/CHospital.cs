using SegurosSA.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Controllers
{
   public class CHospital
    {
        public static DataTable MostrarHospital()
        {
            return DHospital.MostrarHospital();
        }

        public static string InsertarHospital(string nombre, string tipo, int noDepartamentos,
                                        string direccion, string telefono)
        {
            return DHospital.InsertarHospital(nombre, tipo, noDepartamentos, 
                        direccion, telefono);
        }

        public static string EditarHospital(int idHospital, string nombre, string tipo, int noDepartamentos,
                             string direccion, string telefono)
        {
            return DHospital.EditarHospital(idHospital, nombre, tipo, noDepartamentos,
                        direccion, telefono);
        }

        public static string EstadoHospital(int IdHospital)
        {
            return DHospital.EstadoHospital(IdHospital);
        }

        public static object BuscarHospital(string dato)
        {
            return DHospital.BuscarHospital(dato);
        }

        public static DataTable ValidarHospital(string nombre)
        {
            return DHospital.ValidarHospital(nombre);
        }
    }
}
