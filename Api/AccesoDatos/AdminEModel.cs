using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class AdminEModel
    {
        Conexion conexion = new Conexion();
        public void InsertarAdminEps(string nombre, string apellido, int cedula, string nombreCentro, string contrasena)
        {
            SqlConnection cn = new SqlConnection(conexion.conexion());
            SqlCommand command = new SqlCommand("actualizarOInsertarADMINEPS", cn);
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
        public void EliminarAdminEps(int cedula)
        {
            SqlConnection cn = new SqlConnection(conexion.conexion());
            SqlCommand command = new SqlCommand("EliminarAdminEps", cn);
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


        public bool ValidarAdminEps(string usuario, string contrasena)
        {
            bool Paciente = false;
            SqlConnection cn = new SqlConnection(conexion.conexion());
            SqlCommand command = new SqlCommand("ValidarAE", cn);
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
        
    }
}
