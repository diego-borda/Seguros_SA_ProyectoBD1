using SegurosSA.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosSA.Controllers
{
    public class CGastos
    {
        public static DataTable MostrarGasto()
        {
            return DGastos.MostrarGasto();
        }

        public static string InsertarGasto(string nombre, float costo)
        {
            return DGastos.InsertarGasto(nombre, costo);
        }

        public static string EditarGasto(int idGasto, string nombre, float costo)
        {
            return DGastos.EditarGasto(idGasto, nombre, costo);
        }

        public static string EstadoGasto(int IdGasto)
        {
            return DGastos.EstadoGasto(IdGasto);
        }

        public static object BuscarGasto(string dato)
        {
            return DGastos.BuscarGasto(dato);
        }

        public static DataTable ValidarGasto(string nombre)
        {
            return DGastos.ValidarGasto(nombre);
        }

        public static DataTable ValidarGastoEditar(int idGasto, string nombre)
        {
            return DGastos.ValidarGastoEditar(idGasto, nombre);
        }
     }
}
