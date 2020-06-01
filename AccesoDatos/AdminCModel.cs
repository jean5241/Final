using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class AdminCModel
    {
        Conexion conexion = new Conexion();
        public void InsertarAdminCentro(string nombre, string apellido, int cedula, string nombreCentro,string contrasena)
        {
            SqlConnection cn = new SqlConnection(conexion.conexion());
            SqlCommand command = new SqlCommand("actualizarOInsertarADMINCENTRO",cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = apellido;
            command.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;
            command.Parameters.Add("@Contrasena", SqlDbType.Int).Value = contrasena;
            command.Parameters.Add("@NombreCentro", SqlDbType.VarChar, 50).Value = nombreCentro;
            cn.Open();
            try
            {
                command.ExecuteNonQuery();
                cn.Open();
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
        public void EliminarAdminCentro(int cedula)
        {
            SqlConnection cn = new SqlConnection(conexion.conexion());
            SqlCommand command = new SqlCommand("EliminarAdminCentro", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Cedula", SqlDbType.Int).Value = cedula;
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


        public bool ValidarAdminCentro(string usuario, string contrasena)
        {
            bool Paciente = false;
            SqlConnection cn = new SqlConnection(conexion.conexion());
            SqlCommand command = new SqlCommand("ValidarCEps", cn);
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

