using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace AccesoDatos
{
   public class MedicoModel
    {
        Conexion con = new Conexion();
        public bool ValidarMedico(int usuario, string contrasena)
        {
            bool Paciente = false;
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("ValidarCMedico", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@usuario", SqlDbType.Int).Value = usuario;
            command.Parameters.Add("@contrasena", SqlDbType.VarChar, 50).Value = contrasena;
            cn.Open();

            SqlDataReader reg = null;

            try
            {
                reg = command.ExecuteReader();
                if (reg.Read())
                {
                    Paciente = true;
                }
                else
                {
                    Paciente = false;
                }

                reg.Close();
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
        public DataTable MostrarInfoMedico(int cedula, string nombre)
        {
            DataTable medico = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarInfoMedico", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@cedula", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = nombre;
            SqlDataAdapter ejecutar = new SqlDataAdapter(command);
            cn.Open();
          
                command.ExecuteNonQuery();
                ejecutar.Fill(medico);
                cn.Close();
                return medico;
          
               
        }

        public bool ValidarMedicoExistente(int cedula)
        {
            bool Medico = false;
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("ValidarExistenciaMedico", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@cedula", SqlDbType.VarChar, 50).Value = cedula;
            SqlDataReader reg = null;
            cn.Open();
            try
            {
                reg = command.ExecuteReader();
                if (reg.Read())
                {
                    Medico = true;
                }
                else
                {
                    Medico = false;
                }

                reg.Close();
                cn.Close();
                return Medico;

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
        public void InsertarMedico(string nombre, string apellido, int cedula, string nombreCentro)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("ActualizarOInsertarMedico", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = apellido;
            command.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@NombreCentro", SqlDbType.VarChar, 50).Value = nombreCentro;
           
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
        public void EliminarMedico( int cedula, string nombre)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("EliminarMedico", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@Nombre", SqlDbType.VarChar,50).Value = nombre;
            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();
        }
        public DataTable MostrarMedicoXCentro(string nombre)
        {
            DataTable medico = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarMedicoXCentro", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
            SqlDataAdapter ejecutar = new SqlDataAdapter(command);
            cn.Open();
            try
            {
                command.ExecuteNonQuery();
                ejecutar.Fill(medico);
                cn.Close();
                return medico;
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
