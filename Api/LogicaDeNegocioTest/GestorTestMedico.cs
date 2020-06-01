using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace LogicaDeNegocioTest
{
    [TestClass]
    public class GestorTestMedico
    {
       [TestMethod]
        public void TestMostrarInfoMedico()
        {
            string pacienteEsperado1 = "[{‘Nombre’:’Roberto’,’Apellido’:’Gonzales’,’Cedula’:’1546523’,’NombreCentro’:’ClinicaAntioquia’}]".Replace("’", "'");
            GestorMedico obj = new GestorMedico();
            Convertidor conver = new Convertidor();
            Assert.AreEqual(pacienteEsperado1, conver.DataTableToJsonObj(obj.MostrarInfomedico(1546523, "ClinicaAntioquia")).Replace("\"", "'"));

        }

        [TestMethod]
        public void TestMostrarMedicosXCentro()
        {
            string pacienteEsperado1 = "[{‘Nombre’:’Roberto’},{‘Nombre’:’Juan’}]".Replace("’", "'");
            GestorMedico obj = new GestorMedico();
            Convertidor conver = new Convertidor();
            Assert.AreEqual(pacienteEsperado1, conver.DataTableToJsonObj(obj.MostrarmedicosxCentro("ClinicaAntioquia")).Replace("\"", "'"));

        }
    }
}
