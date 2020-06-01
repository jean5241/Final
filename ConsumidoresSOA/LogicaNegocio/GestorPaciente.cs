using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosServicio;
namespace LogicaNegocio
{
    public class GestorPaciente
    {
        PacienteModel obj1 = new PacienteModel();
        public DataTable LoginError()
        {
            return obj1.LoginError();
        }
        public DataTable LoginRegistro()
        {
            return obj1.LoginRegistro();
        }
    }
}
