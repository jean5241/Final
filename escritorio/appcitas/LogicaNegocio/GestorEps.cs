using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosServicios;
using System.Data;



namespace LogicaNegocio
{
    public class GestorEps
    {
        EpsModel obj1 = new EpsModel();

        public DataTable MostrarEps1()
        {
            DataTable eps = new DataTable();
           eps= obj1.MostrarEps();
            return eps;
        }
        public DataTable MostrarEps(string nombreEps)
        {
            DataTable eps = new DataTable();
           eps= obj1.MostrarCentrosXEps(nombreEps);
            return eps;
        }
        public void InsertarEps(string nombre)//, string direccion, int telefono)
        {
            obj1.InsertarEps(nombre);
        }
        public void AsignarEpsACentroMedico(string nombreEps, string nombreCentro)
        {
            obj1.AsignarEpsACentroMedico(nombreEps, nombreCentro);
        }
        public void EliminarEps(string nombre)
        {
            obj1.EliminarEps(nombre);
        }

        public bool verificarNumero(string parametro)
        {
            bool verificado = false;
            int temp = 0;

            if (int.TryParse(parametro, out temp))
            {
                verificado = true;
            }
            else
            {
                verificado = false;
            }

            return verificado;
        }
        
      }
}
