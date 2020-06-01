using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
namespace LogicaNegocio
{
   public class GestorPaciente
    {
        PacienteModel obj1 = new PacienteModel();

      /*public DataTable MostrarPacienteXCedula(int cedula)
        {      

            DataTable Paciente = new DataTable();
            Paciente = obj1.MostrarPaciente(cedula);
            return Paciente;
        }*/
        
        public DataTable MostrarPacienteXEps(int cedula,string nombre)
        {
            DataTable Paciente = new DataTable();
            Paciente = obj1.MostrarPaciente(cedula, nombre);
            return Paciente;
        }

        public bool ValidarPaciente(int usuario, string contrasena)
        {
            bool Paciente=false;
            Paciente = obj1.ValidarPaciente(usuario, contrasena);
            if((Paciente == true))
            {
                Paciente = true;
            }
            return Paciente;
        }

        public bool ValidarExisPaciente(int cedula)
        {
            bool Paciente = false;
            Paciente = obj1.ValidarPacienteExistente(cedula);
            if (Paciente == true)
            {
                Paciente = true;
            }
            return Paciente;
        }

        public void InsertarPaciente(string nombre, string apellido,int cedula,int telefono, string direccion,string nombreEps,string contrasena)
        {
            obj1.InsertarPaciente(nombre,apellido,cedula,telefono,direccion,nombreEps,contrasena);
        }
        public void EliminarPaciente(int cedula, string nombre)
        {
            obj1.EliminarPaciente(cedula,nombre);
        }

        public void LoginError(int cedula, string ip)
        {
            DateTime fecha = DateTime.Now;
            obj1.LoginError(cedula, ip, fecha);
        }

        public void LoginRegistro(int cedula)
        {
            DateTime fecha = DateTime.Now;
            obj1.LoginRegistros(cedula, fecha);
        }
        public DataTable MostrarLoginError()
        {
            DataTable nocitas = new DataTable();
            nocitas = obj1.MostrarLoginError();
            return nocitas;

        }
        public DataTable MostrarLoginRegistro()
        {
            DataTable nocitas = new DataTable();
            nocitas = obj1.MostrarLoginRegistros();
            return nocitas;

        }
    }
}
