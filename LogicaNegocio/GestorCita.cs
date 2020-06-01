using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
using System.Windows.Forms;

namespace LogicaNegocio
{
   
   public    class GestorCita
    {
      CitasModel obj1 = new CitasModel();
        CitasModelConTransaccion obj2 = new CitasModelConTransaccion();
        public DataTable ObtenerCita(string nombreCentro)
        {
            DataTable cita = new DataTable();
            cita = obj1.ObtenerInfoCita(nombreCentro);
            return cita;
        }

        public void ReservarCita(int id, int cedula)
        {
            obj1.ReservarCita(id, cedula);
        }
        
      
        public DataTable CitaXPaciente(int cedula)
        {
            return obj1.CitaXPaciente(cedula);
        }

        public void CancelarCita(int id )
        {
          
                obj2.CancelarCita(id);          
        }
        public DataTable MostrarCitasmedico(DateTime fecha, int cedula)
        {
           DateTime Hoy = DateTime.Today;
           DataTable medico = new DataTable();
            medico = obj1.MostrarCitaMedico(cedula, fecha);
            //hay q sacar el dia para la condicion de cuando es la cita del dia en el sql con datepart
            return medico;
        }

        public void InsertarCita(string nombreCentro, DateTime horaIn, DateTime horaFin, DateTime fecha,string consultorio)
        {
            obj1.InsertarCita(nombreCentro, horaIn, horaFin, fecha,consultorio);
        }

        public void EliminarCita(int id)
        {
            obj2.EliminarCita(id);
        }

        public void NoCitas(int cedula )
        {
            DateTime fecha = DateTime.Now;
            obj1.NoCitas(cedula, fecha);

        }
        public DataTable MostrarNoCitas()
        {
            DataTable nocitas = new DataTable();
            nocitas = obj1.MostrarNoCitas();
            return nocitas;

        }
    }
}
