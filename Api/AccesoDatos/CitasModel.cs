using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace AccesoDatos
{
   public class CitasModel
    {
       Conexion con = new Conexion();
        public DataTable ObtenerInfoCita(string nombre)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            DataTable Paciente = new DataTable();
            SqlCommand command = new SqlCommand("ObtenerCitas", cn);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.Add("@cedula", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@nombreCentro", SqlDbType.VarChar, 50).Value = nombre;
            SqlDataAdapter ejecutar = new SqlDataAdapter(command);
            cn.Open();
          
            command.ExecuteNonQuery();
            ejecutar.Fill(Paciente);
            cn.Close();
            return Paciente;
            
                
            
        }
        public void ReservarCita(int id , int cedula)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("ReservarCita", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cedula", SqlDbType.Int).Value = cedula;
            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
            //con.Open();
            /* try
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
             }*/
        }
        public void InsertarCita( string nombreCentro, DateTime horain, DateTime horafin, DateTime fecha,string consultorio )
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("InsertarCita", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nombreCentro", SqlDbType.VarChar, 50).Value = nombreCentro;
            command.Parameters.Add("@horain", SqlDbType.DateTime).Value = horain;
            command.Parameters.Add("@horafin", SqlDbType.DateTime).Value = horafin;
            command.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
            command.Parameters.Add("@consultorio", SqlDbType.VarChar,50).Value = consultorio;
            cn.Open();
            try
            {
                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);

            }
            finally
            {
                cn.Close();
            }
        }
       
        public DataTable MostrarCitaMedico(int cedula,DateTime fecha )
        {
            DataTable Paciente = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarCitaMedico", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@cedula", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
            SqlDataAdapter ejecutar = new SqlDataAdapter(command);
            cn.Open();
            try
            {
                command.ExecuteNonQuery();
                ejecutar.Fill(Paciente);
                cn.Close();
                return Paciente;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);

            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable CitaXPaciente(int cedula)
        {
            DataTable Paciente = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("CitaXPaciente", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@cedula", SqlDbType.Int).Value = cedula;
            SqlDataAdapter ejecutar = new SqlDataAdapter(command); 
            cn.Open();
           
                command.ExecuteNonQuery();
                ejecutar.Fill(Paciente);
                cn.Close();
                return Paciente;
           
               
            
        }
        public void NoCitas(int cedula, DateTime fecha)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("nocita", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@username", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();

        }
        public DataTable MostrarNoCitas()
        {
            DataTable Paciente = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarNocitas", cn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ejecutar = new SqlDataAdapter(command);
            cn.Open();

            command.ExecuteNonQuery();
            ejecutar.Fill(Paciente);

            cn.Close();


            return Paciente;

        }
    }
}
