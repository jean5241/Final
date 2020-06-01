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
    public class CitaModel
    {
        Convertidor obj1 = new Convertidor();
        public DataTable ObtenerInfoCita(string nombreCentro)
        {

            DataTable dataTable = new DataTable();


            var url = $"http://localhost:51971/api/Cita?nombreCentro=" + nombreCentro;
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
                if (e.Message == "Error Parsing Column Name:null")
                {
                    return dataTable;
                }
                else
                {
                    return dataTable;
                }
            }
        }

        public void ReservarCita(int id, int cedula)
        {
            var url = $"http://localhost:51971/api/Cita?iden=" + id + "&cedula=" + cedula;
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
                if (e.Message == "Error Parsing Column Name:null")
                {
                    MessageBox.Show("No se encontraron resultados");
                }
                else
                {
                    MessageBox.Show("Se presento el siguiente error" + e.Message);
                }
            }
            /* var url = $"http://localhost:51971/api/Eps";
             var request = (HttpWebRequest)WebRequest.Create(url);
             var postData = "id=" + id;
             postData += "?cedula=" + cedula;
             postData += "?fecha=" + fecha;
             var data = Encoding.ASCII.GetBytes(postData);

             request.Method = "POST";
             request.ContentType = "application/x-www-form-urlencoded";
             request.ContentLength = data.Length;

             using (var stream = request.GetRequestStream())
             {
                 stream.Write(data, 0, data.Length);
             }*/
        }

        public DataTable CitaXPaciente(int cedula)
        {
            DataTable dataTable = new DataTable();


            var url = $"http://localhost:51971/api/Cita?cedula=" + cedula;
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
                if (e.Message == "Error Parsing Column Name:null")
                {
                    return dataTable;
                }
                else
                {
                    return dataTable;
                }
            }
        }
        //corregir
        public string CancelarCita(int iden)
        {
            var url = $"http://localhost:51971/api/Cita?iden=" + iden + "&falso=f";
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
                        if (strReader == null) return "No se encontro";
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd().Replace("\\", "");

                            return "satisfactorio";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (e.Message == "Error Parsing Column Name:null")
                {
                    return "No se encontraron resultados";
                }
                else
                {
                    return "Se presento el siguiente error" + e.Message;
                }
            }
        }

        public void InsertarCita(string nombreCentro, DateTime horaIn, DateTime horaFin, DateTime fecha, string consultorio)
        {
            var url = $"http://localhost:51971/api/Cita?nombreCentro="+nombreCentro+"&horaIn="+ horaIn.ToString("HH:mm:ss") +"&horaFin="+horaFin.ToString("HH:mm:ss")+ "&fecha="+ fecha.ToShortDateString() + "&consultorio="+consultorio;
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
                if (e.Message == "Error Parsing Column Name:null")
                {
                    MessageBox.Show("No se encontraron resultados");
                }
                else
                {
                    MessageBox.Show("Se presento el siguiente error" + e.Message);
                }
            }
            /* var url = $"http://localhost:51971/api/Eps";
             var request = (HttpWebRequest)WebRequest.Create(url);
             var postData = "nombreCentro=" + nombreCentro;
             postData += "?horaIn=" + horaIn;
             postData += "?horafin=" + horaFin;
             postData += "?fecha=" + fecha;
             postData += "?consutorio=" + consultorio;
             var data = Encoding.ASCII.GetBytes(postData);

             request.Method = "POST";
             request.ContentType = "application/x-www-form-urlencoded";
             request.ContentLength = data.Length;

             using (var stream = request.GetRequestStream())
             {
                 stream.Write(data, 0, data.Length);
             }
         }*/
            /* public DataTable MostrarCitasmedico(DateTime fecha, int cedula)
             {
                 DateTime Hoy = DateTime.Today;
                 var url = $"http://localhost:51971/api/Cita?id=" + id+ "?fecha="+fecha+ "&horaIn="+ horaIn;
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
                             if (strReader == null) return "No se encontro";
                             using (StreamReader objReader = new StreamReader(strReader))
                             {
                                 string responseBody = objReader.ReadToEnd().Replace("\\", "");

                                 return "satisfactorio";
                             }
                         }
                     }
                 }
                 catch (Exception e)
                 {
                     throw new Exception(e.Message);
                 }
             }*/
        }

        public void EliminarCita(int id)
        {
            var url = $"http://localhost:51971/api/Cita/" + id;
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
                if (e.Message == "Error Parsing Column Name:null")
                {
                    MessageBox.Show("No se encontraron resultados");
                }
                else
                {
                    MessageBox.Show("Se presento el siguiente error" + e.Message);
                }
            }
        }
        public void NoCita(int cedula)
        {
            var url = $"http://localhost:51971/api/Cita?cedula=" + cedula + "&falsa=false";
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
                if (e.Message == "Error Parsing Column Name:null")
                {
                    MessageBox.Show("Error registrando");
                }
                else
                {
                    MessageBox.Show("Se presento el siguiente error" + e.Message);
                }
            }
        }
    }
}
      
