using SegurosSA.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Controllers
{
    public class CMedico
    {
        
        public static DataTable MostrarMedico()
        {
            return DMedico.MostrarMedico();
        }
        public static string InsertarMedico(int idHospital,string primernombre, string segundonombre, string primerapellido,
                                        string segundoapellido, string especialidad, string telefono)
        {
            return DMedico.InsertarMedico(idHospital,primernombre, segundonombre, primerapellido, segundoapellido,
                        especialidad, telefono);
        }
        public static string EditarMedico(int idHospital, int idMedico, string primernombre, string segundonombre, string primerapellido,
                                      string segundoapellido, string especialidad, string telefono)
        {
            return DMedico.EditarMedico(idHospital,idMedico, primernombre, segundonombre, primerapellido, segundoapellido,
                        especialidad, telefono);
        }

        public static string EstadoMedico(int IdMedico)
        {
            return DMedico.EstadoMedico(IdMedico);
        }

        public static object BuscarMedico(string dato)
        {
            return DMedico.BuscarMedico(dato);
        }

        public static object BuscarMedico2(string nombre, string dato)
        {
            return DMedico.BuscarMedico2(nombre, dato);
        }
    }
}
