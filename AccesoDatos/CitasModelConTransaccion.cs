using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace AccesoDatos
{
   public class CitasModelConTransaccion:SqlBase
    {
        public void CancelarCita(int id)
        {
            SqlCommand command = new SqlCommand("CancelarCita", con, tran);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
           
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception e)
            {
                tran.Rollback();
                throw new Exception(e.Message);

            }
            finally
            {
                con.Close();
            }
        }
        public void ReservarCita(int id, int cedula,DateTime fecha)
        {
            SqlCommand command = new SqlCommand("ReservarCita", con, tran);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cedula", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@fecha1", SqlDbType.Date).Value = fecha;
            try
             {
                 command.ExecuteNonQuery();
                 tran.Commit();
             }
             catch (Exception e)
             {
                 tran.Rollback();
                 throw new Exception(e.Message);

             }
             finally
             {
                 con.Close();
             }
        }
        public void EliminarCita(int id)
        {
            SqlCommand command = new SqlCommand("EliminarCita", con, tran);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception e)
            {
                tran.Rollback();
                throw new Exception(e.Message);

            }
            finally
            {
                con.Close();
            }
        }
    }
}
