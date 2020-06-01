using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatosServicios;


namespace LogicaNegocio
{
    public class Gestorcentro

    {
        CentroModel obj1 = new CentroModel();
        public DataTable MostrarInfocentros()
        {
            DataTable centros = new DataTable();
            centros = obj1.MostrarCentros();
            return centros;
        }
        public void Insertarcentros(string nombre, string direccion, int telefono)
        {
            obj1.InsertarCentro(nombre, direccion, telefono);
        }
        public void Eliminarcentros(string nombre, string direccion)
        {
            obj1.EliminarCentro(nombre, direccion);
        }
        public DataTable MostrarNombreCentroMedico(int cedula)
        {
            DataTable centros = new DataTable();
            centros = obj1.MostrarNombreCentroMedico(cedula);
            return centros;
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
