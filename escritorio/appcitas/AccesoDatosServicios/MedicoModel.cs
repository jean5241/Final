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
   public class MedicoModel
    {
        Convertidor obj1 = new Convertidor();

        public DataTable MostrarInfomedico(int cedula, string nombre)
        {

            DataTable dataTable = new DataTable();


            var url = $"http://localhost:51971/api/Medico?cedula=" + cedula + "&nombreCentro=" + nombre;
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

        public DataTable MostrarmedicosxCentro(string nombre)
        {
            DataTable dataTable = new DataTable();


            var url = $"http://localhost:51971/api/Medico?nombreCentro=" + nombre;
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

         public void Insertarmedico(string nombre, string apellido, int cedula, string nombreCentro)
         {
            var url = $"http://localhost:51971/api/Medico?nombre=" + nombre + "&apellido=" + apellido + "&cedula=" + cedula + "&nombreCentro=" + nombreCentro;
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

            /* var url = $"http://localhost:51971/api/Medico";
             var request = (HttpWebRequest)WebRequest.Create(url);
             var postData = "nombre=" + nombre;
             postData += "&apellido=" + apellido;
             postData += "&cedula=" + cedula;
             postData += "&nombreCentro=" + nombreCentro;

             var data = Encoding.ASCII.GetBytes(postData);

             request.Method = "POST";
             request.ContentType = "application/x-www-form-urlencoded";
             request.ContentLength = data.Length;

             using (var stream = request.GetRequestStream())
             {
                 stream.Write(data, 0, data.Length);
             }*/
        }
      /*  public void Insertarmedico(string nombre, string apellido, int cedula, string nombreCentro)
        {
            var postString = new { clave1="valor1", clave2= "valor2"};
        byte[] data = UTF8Encoding.UTF8.GetBytes(postString);
        HttpWebRequest request;
        request = WebRequest.Create("http://localhost:51971/api/Medico") as HttpWebRequest;
        request.Timeout = 10 * 1000;
        request.Method = "POST";
        request.ContentLength = data.Length;
        request.ContentType = "application/json; charset=utf-8";
        }*/
            public void Eliminarmedico(int cedula, string nombre)
        {
            var url = $"http://localhost:51971/api/Medico?cedula=" +cedula+ "&nombreCentro="+ nombre;
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



    }
}
