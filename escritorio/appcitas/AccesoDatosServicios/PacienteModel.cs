using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatosServicios
{
    public class PacienteModel
    {
        Convertidor obj1 = new Convertidor();
        public DataTable MostrarPaciente(int cedula, string nombre)
        {

            DataTable dataTable = new DataTable();


            var url = $"http://localhost:51971/api/Paciente?cedula=" + cedula + "&nombre=" + nombre + "&parametroFalso=falso";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return dataTable;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd().Replace("\\", "");

                            return obj1.JsonStringToDataTable(responseBody);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return dataTable;
            }
        }

        public bool ValidarPaciente(int usuario, string contrasena)
        {

            var url = $"http://localhost:51971/api/Paciente?usuario=" + usuario + "&contrasena=" + contrasena;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return false;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd().Replace("\\", "");

                            return bool.Parse(responseBody);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void InsertarPaciente(string nombre, string apellido, int cedula, int telefono, string direccion, string nombreEps, string contrasena)
        {
            var url = $"http://localhost:51971/api/Paciente?nombre=" + nombre + "&apellido=" + apellido + "&cedula=" +
                cedula + "&telefono=" + telefono + "&direccion=" + direccion + "&nombreEps=" + nombreEps + "&contrasena=" + contrasena;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) MessageBox.Show("Eliminado");
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd().Replace("\\", "");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            /* var url = $"http://localhost:51971/api/Paciente";
             var request = (HttpWebRequest)WebRequest.Create(url);
             var postData = "nombre="+nombre;
             postData += "&apellido="+apellido;
             postData += "&cedula="+cedula;
             postData += "&telefono="+telefono;
             postData += "&direccion="+direccion;
             postData += "&nombreEps="+nombreEps;
             postData += "&contrasena="+contrasena;
             var data = Encoding.ASCII.GetBytes(postData);

             request.Method = "POST";
             request.ContentType = "application/x-www-form-urlencoded";
             request.ContentLength = data.Length;

             using (var stream = request.GetRequestStream())
             {
                 stream.Write(data, 0, data.Length);
             }
             */

        }
        public void EliminarPaciente(int cedula, string nombre)
        {
            var url = $"http://localhost:51971/api/Paciente?cedula=" + cedula + "&nombreEps=" + nombre;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) MessageBox.Show("Eliminado");
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd().Replace("\\", "");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void LoginError(int cedula, string ip)
        {
            var url = $"http://localhost:51971/api/Paciente?cedula=" + cedula + "&ip=" + ip + "&falso=false";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) MessageBox.Show("Insertado");
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd().Replace("\\", "");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoginRegistro(int cedula)
        {
            var url = $"http://localhost:51971/api/Paciente?cedula=" + cedula;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) MessageBox.Show("Insertado");
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd().Replace("\\", "");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
      