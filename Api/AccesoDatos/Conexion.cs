using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace AccesoDatos
{
   public class Conexion
    {
        public string conexion()
        {
            string con = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SALUDATUALCANCE3;Data Source=DESKTOP-5EK5HLL\SQLEXPRESS03";
            return con;
        }
    }
}
