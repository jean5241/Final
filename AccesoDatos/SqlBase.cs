using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AccesoDatos
{
    public class SqlBase:IDisposable
    {


        // protected static string connection = ConfigurationManager.AppSettings["CADENA_CONEXION"];
        protected static string connection = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SALUDATUALCANCE3;Data Source=DESKTOP-5EK5HLL\SQLEXPRESS03";
        protected SqlConnection con;
        protected SqlTransaction tran;
        protected bool error;
        public SqlBase()
        {
            try
            {
                error = false;
                con = new SqlConnection(connection);
                con.Open();
                tran = con.BeginTransaction();
            }
            catch(Exception e)
            {
               // error = true;
                throw new Exception(e.Message);
            }
        }
        public void Dispose()
        {
            if (tran != null)
            {
                if (error == true)
                {
                    tran.Rollback();
                }
                else
                {
                    tran.Commit();
                }
            }
            if (connection != null)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }

        }
}
