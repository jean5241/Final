using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace AccesoDatos
{
   public class EpsModel
    {
       Conexion con = new Conexion();
        public DataTable MostrarEps()
        {
            DataTable Paciente = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarEps", cn);
            command.CommandType = CommandType.StoredProcedure;
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
        public void InsertarEps(string nombre)//, string direccion, int telefono)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("actualizarOInsertarEps", cn);
            command.CommandType = CommandType.StoredProcedure;
            //con.Open();
            command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
            // command.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
            // command.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = direccion;
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
        public void AsignarEpsACentroMedico(string nombreEps, string nombreCentro)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("CentroXEps", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nombreEps", SqlDbType.VarChar, 50).Value = nombreEps;
            command.Parameters.Add("@nombreCentro", SqlDbType.VarChar, 50).Value = nombreCentro;
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
        public void EliminarEps(string nombre)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("EliminarEps", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
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

        public DataTable MostrarCentrosXEps(string nombreEps)
        {
            DataTable Paciente = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarCentrosXEps", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nombreEps", SqlDbType.VarChar, 50).Value = nombreEps;
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

        
    
    }
}
