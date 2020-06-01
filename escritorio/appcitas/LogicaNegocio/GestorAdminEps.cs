using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosServicios;

namespace LogicaNegocio
{
    public class GestorAdminEps
    {
        AdminEpsModel obj1 = new AdminEpsModel();

        public void InsertarAdminEps(string nombre, string apellido, int cedula, string nombreCentro,string contrasena)
        {
            obj1.InsertarAdminEps(nombre, apellido, cedula, nombreCentro, contrasena);
        }
        public void EliminarAdminEps(int cedula)
        {
            obj1.EliminarAdminEps(cedula);
        }

        public bool ValidarAdminEps(string usuario, string contrasena)
        {
            bool Aeps=false;
            Aeps = obj1.ValidarAdminEps(usuario, contrasena);
            if ((Aeps == true))
            {
                Aeps = true;
            }
            return Aeps;

        }
    }
}
