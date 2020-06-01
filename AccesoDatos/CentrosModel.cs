using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace AccesoDatos
{
    public class CentrosModel
    {
        Conexion con = new Conexion();
        public DataTable MostrarCentros()
        {
            DataTable Paciente = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarCentros",cn );
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
        public DataTable MostrarNombreCentroMedico(int cedula)
        {
            DataTable Paciente = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarNombreCentroMedico", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;
            SqlDataAdapter ejecutar = new SqlDataAdapter(command);
            cn.Open();
        
                command.ExecuteNonQuery();
                ejecutar.Fill(Paciente);
                 cn.Close();
                return Paciente;
           
               
           
        }
        public void InsertarCentro(string nombre,string direccion,int telefono)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("InsertarCentro", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
            command.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
            command.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = direccion;
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
        public void EliminarCentro(string nombre, string direccion)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("EliminarCentro", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
            command.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = direccion;
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

       
    }
}
