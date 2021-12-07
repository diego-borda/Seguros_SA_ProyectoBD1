using SegurosSA.Controllers;
using SegurosSA.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Controllers
{
    public class CAsegurado
    {
        public static DataTable MostrarAsegurado()
        {
            return DAsegurado.MostrarAsegurado();
        }

        public static string InsertarAsegurado(string idCategoria, int idZona, string primernombre, string segundonombre, string primerapellido,
                                        string segundoapellido, string direccion, string telefono)
        {
            return DAsegurado.InsertarAsegurado(idCategoria,idZona,primernombre, segundonombre, primerapellido, segundoapellido,
                        direccion, telefono);
        }

        public static string EditarAsegurado(int idAsegurado, string idCategoria,int idZona, string primernombre, string segundonombre, string primerapellido,
                              string segundoapellido, string direccion, string telefono)
        {
            return DAsegurado.EditarAsegurado(idAsegurado,idCategoria,idZona, primernombre, segundonombre, primerapellido, segundoapellido,
                        direccion, telefono);
        }

        public static string EstadoAsegurado(int IdAsegurado)
        {
            return DAsegurado.EstadoAsegurado(IdAsegurado);
        }

        public static object BuscarAsegurado(string dato)
        {
            return DAsegurado.BuscarAsegurado(dato);
        }
    }
}
