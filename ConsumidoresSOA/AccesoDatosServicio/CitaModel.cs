using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AccesoDatosServicio
{
    public class CitaModel
    {
        Convertidor obj1 = new Convertidor();
        public DataTable Nocitas()
        {

            DataTable dataTable = new DataTable();
            //int idProdcuto = 15429219;

            var url = $"http://localhost:51971/api/Cita";
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
                throw new Exception(e.Message);
            }
        }
      
       
    }
}
