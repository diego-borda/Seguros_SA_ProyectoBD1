using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SegurosSA.Data
{
    public abstract class CONEXION
    
    {
        public static string Cn;
        public CONEXION()
        {
            Cn = "Data Source= CARLOSB-PC\\SQLEXPRESS; Initial Catalog =Seguros_SA_v3; user= adminH; password = sistemas123 ";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Cn);
        }
    }
   
}
    
