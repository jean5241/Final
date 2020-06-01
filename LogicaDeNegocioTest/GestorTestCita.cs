using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace LogicaDeNegocioTest
{
    [TestClass]
    public class GestorTestCita
    {
        [TestMethod]
        public void TestObtenerCita()
        {
            string pacienteEsperado1 = "[{‘id’:’2041’,’NombreCentro’:’ClinicaAntioquia’,’HoraInicio’:’09:20:30’,’HoraFinalizacion’:’10:20:30’,’Fecha’:’1/06/2020 12:00:00 a. m.’},{‘id’:’2042’,’NombreCentro’:’ClinicaAntioquia’,’HoraInicio’:’12:00:00’,’HoraFinalizacion’:’13:00:00’,’Fecha’:’1/06/2020 12:00:00 a. m.’}]";
            GestorCita obj = new GestorCita();
            Convertidor conver = new Convertidor();
            Assert.AreEqual(pacienteEsperado1, conver.DataTableToJsonObj(obj.ObtenerCita("ClinicaAntioquia")).Replace("\"", "'"));


        }
        public void TestCitaXpaciente()
        {
            string pacienteEsperado1 = "[{‘Id’:’15’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’15:00:00’,’HoraFin’:’16:00:00’,’Fecha’:’8/09/2019 12:00:00 a. m.’},{‘Id’:’16’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’12:01:00’,’HoraFin’:’13:24:00’,’Fecha’:’8/06/2019 12:00:00 a. m.’},{‘Id’:’1013’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’," +
                "’HoraInicio’:’17:00:00’,’HoraFin’:’18:00:00’,’Fecha’:’30/05/2020 12:00:00 a. m.’},{‘Id’:’1015’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’16:00:00’,’HoraFin’:’17:00:00’,’Fecha’:’30/05/2020 12:00:00 a. m.’},{‘Id’:’1016’,’Nombre’:’Cecilia’,’Nombre1’:’CaldasAntioquia’,’HoraInicio’:’12:30:00’,’HoraFin’:’15:20:00’,’Fecha’:’8/06/2019 12:00:00 a. m.’}," +
                "{‘Id’:’1018’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’12:00:00’,’HoraFin’:’14:03:00’,’Fecha’:’6/06/2019 12:00:00 a. m.’},{‘Id’:’1021’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’18:00:00’,’HoraFin’:’19:00:00’,’Fecha’:’31/05/2020 12:00:00 a. m.’},{‘Id’:’1022’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’06:00:20’," +
                "’HoraFin’:’07:00:20’,’Fecha’:’30/05/2020 12:00:00 a. m.’},{‘Id’:’1023’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’12:00:00’,’HoraFin’:’13:00:00’,’Fecha’:’21/05/2020 12:00:00 a. m.’},{‘Id’:’1024’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’10:00:00’,’HoraFin’:’11:00:00’,’Fecha’:’7/06/2019 12:00:00 a. m.’},{‘Id’:’1026’,’Nombre’:’Cecilia’," +
                "’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’19:00:00’,’HoraFin’:’20:00:00’,’Fecha’:’31/05/2020 12:00:00 a. m.’},{‘Id’:’1027’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’12:00:00’,’HoraFin’:’13:00:00’,’Fecha’:’6/01/2020 12:00:00 a. m.’},{‘Id’:’1031’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’16:00:00’,’HoraFin’:’17:00:00’,’Fecha’:’6/02/2020 12:00:00 a. m.’}," +
                "{‘Id’:’1032’,’Nombre’:’Cecilia’,’Nombre1’:’ClinicaAntioquia’,’HoraInicio’:’14:00:00’,’HoraFin’:’15:00:00’,’Fecha’:’6/01/2020 12:00:00 a. m.’}]".Replace("’", "'");
            GestorCita obj = new GestorCita();
            Convertidor conver = new Convertidor();
            Assert.AreEqual(pacienteEsperado1, conver.DataTableToJsonObj(obj.CitaXPaciente(43165413)).Replace("\"", "'"));


        }
        public void TestNocitas()
        {
            string pacienteEsperado1 = "[{‘id’:’1’,’Nombre’:’Cecilia’,’Apellido’:’Meza’,’cedula’:’43165413’,’fecha’:’30/05/2020 1:00:00 p. m.’},{‘id’:’2’,’Nombre’:’Cecilia’,’Apellido’:’Meza’,’cedula’:’43165413’,’fecha’:’31/05/2020 6:12:04 p. m.’},{‘id’:’3’,’Nombre’:’Cecilia’,’Apellido’:’Meza’,’cedula’:’43165413’,’fecha’:’31/05/2020 6:46:11 p. m.’},{‘id’:’4’,’Nombre’:’Cecilia’,’Apellido’:’Meza’,’cedula’:’43165413’,’fecha’:’31/05/2020 10:56:18 p. m.’}]".Replace("’", "'");
            GestorCita obj = new GestorCita();
            Convertidor conver = new Convertidor();
            Assert.AreEqual(pacienteEsperado1, conver.DataTableToJsonObj(obj.MostrarNoCitas()).Replace("\"", "'"));


        }
      
    }
}
