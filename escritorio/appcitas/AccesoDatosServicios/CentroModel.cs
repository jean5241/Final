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
    public class CentroModel
    {

        Convertidor obj1 = new Convertidor();
        public DataTable MostrarCentros()
        {
            DataTable dataTable = new DataTable();
            var url = $"http://localhost:51971/api/Centro";
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
            } /* DataTable dataTable = new DataTable();


            var url = $"http://localhost:51971/api/Centro";
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
                // throw new Exception(e.Message);
                if (e.Message == "Error Parsing Column Name:null")
                {
                    MessageBox.Show("No se encontraron resultados");
                }
                else
                {
                    MessageBox.Show("Se presento el siguiente error" + e.Message);
                }
            }*/
        }

        public void InsertarCentro(string nombre, string direccion, int telefono)
        {
            var url = $"http://localhost:51971/api/Centro?nombre=" + nombre + "&direccion=" + direccion + "&telefono=" + telefono;
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
                //throw new Exception(e.Message);
                if (e.Message == "Error Parsing Column Name:null")
                {
                    MessageBox.Show("No se encontraron resultados");
                }
                else
                {
                    MessageBox.Show("Se presento el siguiente error" + e.Message);
                }
            }
            /* var url = $"http://localhost:51971/api/Centro";
             var request = (HttpWebRequest)WebRequest.Create(url);
             var postData = "nombre=" + nombre;
              postData += "?direccion=" + direccion;
             postData += "?telefono=" + telefono;
             var data = Encoding.ASCII.GetBytes(postData);

             request.Method = "POST";
             request.ContentType = "application/x-www-form-urlencoded";
             request.ContentLength = data.Length;

             using (var stream = request.GetRequestStream())
             {
                 stream.Write(data, 0, data.Length);
             }*/
        }

        public void EliminarCentro(string nombre, string direccion)
        {
            var url = $"http://localhost:51971/api/Centro?nombres=" + nombre + "&direccion=" + direccion;
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
                //throw new Exception(e.Message);
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
        public DataTable MostrarNombreCentroMedico(int cedula)
        {
            DataTable dataTable = new DataTable();


            var url = $"http://localhost:51971/api/Centro?cedula=" + cedula;
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
    }
}
        
    