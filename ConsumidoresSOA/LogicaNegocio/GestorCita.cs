using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosServicio;
namespace LogicaNegocio
{
    public class GestorCita
    {
        CitaModel obj1 = new CitaModel();

        public DataTable Nocita()
        {
            return obj1.Nocitas();
        }
        public bool sesion(string usuario, string contrasena)
        {
            bool resultado = false;
            if (usuario == "Admin" && contrasena == "control123")
            {
                resultado = true;
            }

            return resultado;
        }
       
    }
}
