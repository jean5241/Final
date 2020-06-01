using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
   public class PacienteModel
    {
        Conexion con = new Conexion();

     
        public DataTable MostrarPaciente(int cedula, string nombreEps)
        {
            DataTable Paciente = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarPacienteXCedula", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@cedula",SqlDbType.Int).Value=cedula;
            command.Parameters.Add("@nombreEps", SqlDbType.VarChar, 50).Value = nombreEps;
            SqlDataAdapter ejecutar = new SqlDataAdapter(command);
            cn.Open();
            
                command.ExecuteNonQuery();  
                ejecutar.Fill(Paciente);
                
            cn.Close();


           return Paciente;    
            
        }
        public void InsertarPaciente(string nombre,string apellido,int cedula,int telefono,string direccion,string nombreEps, string contrasena)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("ActualizarOInsertar", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Nombre", SqlDbType.VarChar,50).Value = nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = apellido;
            command.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@Telefono", SqlDbType.Int).Value = telefono;
            command.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = direccion;
            command.Parameters.Add("@NombreEps", SqlDbType.VarChar, 50).Value = nombreEps;
            command.Parameters.Add("@Contrasena", SqlDbType.VarChar, 50).Value = contrasena;
            cn.Open();
            try
            {
                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception e)
            {
               ;
                throw new Exception(e.Message);

            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable MostrarPaciente1(string nombre)
        {
            DataTable Paciente = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarPaciente", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = nombre;
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

        public bool ValidarPaciente (int usuario , string contrasena)
        {
            bool Paciente = false;
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("ValidarCPaciente", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = usuario;
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

        public bool ValidarPacienteExistente(int cedula)
        {
            bool Paciente = false;
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("ValidarExistenciaPaciente", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@cedula", SqlDbType.VarChar, 50).Value = cedula;
            cn
                .Open();
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

        public void EliminarPaciente(int cedula, string nombre)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("EliminarPaciente", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = nombre;
            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();

        }

        public void LoginError(int cedula, string ip, DateTime fecha)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("LoginError", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@username", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@ip", SqlDbType.VarChar, 50).Value = ip;
            command.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();

        }

        public void LoginRegistros(int cedula, DateTime fecha)
        {
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("Loginr", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@username", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
            cn.Open();
            command.ExecuteNonQuery();
            cn.Close();

        }
        public DataTable MostrarLoginError()
        {
            DataTable Paciente = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarLoginError", cn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ejecutar = new SqlDataAdapter(command);
            cn.Open();

            command.ExecuteNonQuery();
            ejecutar.Fill(Paciente);

            cn.Close();


            return Paciente;

        }
        public DataTable MostrarLoginRegistros()
        {
            DataTable Paciente = new DataTable();
            SqlConnection cn = new SqlConnection(con.conexion());
            SqlCommand command = new SqlCommand("MostrarLoginRegistros", cn);
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
