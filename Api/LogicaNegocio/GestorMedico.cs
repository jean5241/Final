using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
namespace LogicaNegocio
{
   public class GestorMedico
    {
   MedicoModel obj1 = new MedicoModel();

        public DataTable MostrarInfomedico(int cedula, string nombre)
        {
            
            DataTable medico = new DataTable();
            medico = obj1.MostrarInfoMedico(cedula,nombre);
            return medico;
        }

        public DataTable MostrarmedicosxCentro(string nombre)
        {
            DataTable medico = new DataTable();
            medico = obj1.MostrarMedicoXCentro(nombre);
            return medico;
        }
        public void Insertarmedico(string nombre, string apellido, int cedula,string nombreCentro)
        {
            obj1.InsertarMedico(nombre,apellido, cedula, nombreCentro);
        }
        public void Eliminarrmedico(int cedula, string nombre)
        {
           obj1.EliminarMedico(cedula,nombre);
        }

        public bool ValidarMedico(int usuario, string contrasena)
        {
            bool Medico=false;
            Medico = obj1.ValidarMedico(usuario, contrasena);
            if ((Medico == true))
            {
                Medico = true;
            }
            return Medico;
            
        }

        public bool ValidarExisMedico(int cedula)
        {
            bool Medico = false;
            Medico = obj1.ValidarMedicoExistente(cedula);
            if (Medico == true)
            {
                Medico = true;
            }
            return Medico;
        }
    }
}
