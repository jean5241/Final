using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace LogicaDeNegocioTest
{
    [TestClass]
    public class GestorTestPaciente
    {
        [TestMethod]
        public void TestMostrarPacienteXEps()
        {
            string pacienteEsperado = "[{'IDPaciente':'4','IDeps':'1','Nombre':'Juan','Apellido':'Ramos','Cedula':'1026163147','Telefono':'322682565','Direccion':'Caldas','Contrasena':'Ju700'}]";
            GestorPaciente Gp = new GestorPaciente();
            Convertidor conver = new Convertidor();
            string resultado = conver.DataTableToJsonObj(Gp.MostrarPacienteXEps(1026163147, "SURA"));
           string  resultadoconvertido= resultado.Replace("\"", "'");
            Assert.AreEqual(pacienteEsperado, resultadoconvertido);
            
        }

        [TestMethod]
        public void TestMostrarLoginError()
        {
            string pacienteEsperado1  = "[{‘Id’:’1’,’Username’:’43165413’,’ipCliente’:’192.168.1.2’,’numero’:’10’,’fecha’:’31 / 05 / 2020 10:52:21 p.m.’}]";
            GestorPaciente Gp = new GestorPaciente();
            Convertidor conver = new Convertidor();
            Assert.AreEqual(pacienteEsperado1,conver.DataTableToJsonObj(Gp.MostrarLoginError()).Replace("\"", "'"));

        }
        [TestMethod]
        public void TestMostrarLoginRegistro()
        {
            string pacienteEsperado1 = "[{‘id’:’1’,’Username’:’43165413’,’fecha’:’30/05/2020 1:00:00 p. m.’},{‘id’:’2’,’Username’:’43165413’,’fecha’:’12/05/2020 12:00:00 p. m.’},{‘id’:’3’,’Username’:’43165413’,’fecha’:’31/05/2020 6:09:19 p. m.’},{‘id’:’4’,’Username’:’43165413’,’fecha’:’31/05/2020 6:34:09 p. m.’},{‘id’:’5’,’Username’:’43165413’,’fecha’:’31/05/2020 6:44:37 p. m.’},{‘id’:’6’,’Username’:’43165413’,’fecha’:’31/05/2020 10:54:18 p. m.’}]".Replace("’", "'");
            Convertidor conver = new Convertidor();
            GestorPaciente Gp = new GestorPaciente();
            Assert.AreEqual(pacienteEsperado1, conver.DataTableToJsonObj(Gp.MostrarLoginRegistro()).Replace("\"", "'"));

        }
        

       [TestMethod]
        public void TestValidarPaciente()
        {
            bool ValidarPaciente = true;
            GestorPaciente Gp = new GestorPaciente();
            Assert.AreEqual(ValidarPaciente, Gp.ValidarPaciente(43165413,"Cecilia4316"));

        }
    }
}
