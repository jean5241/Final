using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatosServicios;
using System.Windows.Forms;

namespace LogicaNegocio
{
   
   public    class GestorCita
    {
      CitaModel obj1 = new CitaModel();

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

        public string CancelarCita(int id, DateTime fecha, string horaIn)
        {
            string[] fechas = new string[3];
            DateTime ahora = DateTime.Now;
            fechas = horaIn.Split(':');
            DateTime final = new DateTime(fecha.Year, fecha.Month, fecha.Day, Convert.ToInt32(fechas[0]), Convert.ToInt32(fechas[1]), Convert.ToInt32(fechas[2]));
            TimeSpan Diferencia = new TimeSpan();
            Diferencia = final - ahora;
            //MessageBox.Show(Diferencia.ToString());
            int hora = Diferencia.Hours;
            //MessageBox.Show(hora.ToString());
            if (hora >= 2)
            {
                obj1.CancelarCita(id);
                return "Se Cancelo Correctamente";
            }
            else
            {
                return "No se pudo cancelar la cita excedio el limite maximo de 2 horas para cancelar";
            }

        }
        /*  public DataTable MostrarCitasmedico(DateTime fecha, int cedula)
          {
             DateTime Hoy = DateTime.Today;
             DataTable medico = new DataTable();
              medico = obj1.MostrarCitaMedico(cedula, fecha);
              //hay q sacar el dia para la condicion de cuando es la cita del dia en el sql con datepart
              return medico;
          }*/

        public void InsertarCita(string nombreCentro, DateTime horaIn, DateTime horaFin, DateTime fecha, string consultorio)
        {
            obj1.InsertarCita(nombreCentro, horaIn, horaFin, fecha, consultorio);
        }

        public void EliminarCita(int id)
        {
            obj1.EliminarCita(id);
        }
        public void NoCita(int cedula)
        {
            obj1.NoCita(cedula);
        }
    }
}
