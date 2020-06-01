using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatosServicios
{
   public class AdminCentroModel
    {
        Convertidor obj1 = new Convertidor();

        public void InsertarAdminCentro(string nombre, string apellido, int cedula, string nombreCentro, string contrasena)
        {
            var url = $"http://localhost:51971/api/AdminCentro?nombre=" + nombre + "&apellido=" + apellido + "&cedula=" + cedula + "&nombreCentro=" + nombreCentro + "&contrasena=" + contrasena;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
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
            /* var url = $"http://localhost:51971/api/AdminCentro";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var postData = "nombre=" + nombre;
            postData += "?apellido=" + apellido;
            postData += "?cedula=" + cedula;
            postData += "?nombreCentro=" + nombreCentro;
            postData += "?contrasena=" + contrasena;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }*/
        }

        public void EliminarAdminCentro(int cedula)
        {
            var url = $"http://localhost:51971/api/AdminCentro?cedula=" + cedula;
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

        public bool ValidarAdminCentro(string usuario, string contrasena)
        {
            var url = $"http://localhost:51971/api/AdminCentro?usuario=" + usuario + "&contrasena=" + contrasena;
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
    }
}
