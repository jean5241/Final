using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaNegocio
{
    public class GestorAdminCentro
    {

   AdminCModel obj1 = new AdminCModel();


        public void InsertarAdminCentro(string nombre, string apellido, int cedula, string nombreCentro, string contrasena)
        {
            obj1.InsertarAdminCentro(nombre, apellido, cedula, nombreCentro, contrasena);
        }
        public void EliminarAdminCentro(int cedula)
        {
            obj1.EliminarAdminCentro(cedula);
        }

        public bool ValidarAdminCentro(string usuario, string contrasena)
        {
            bool AdminC=false;
            AdminC = obj1.ValidarAdminCentro(usuario, contrasena);
            if ((AdminC == true))
            {
                AdminC = true;
            }
            return AdminC;

        }
    }
}
