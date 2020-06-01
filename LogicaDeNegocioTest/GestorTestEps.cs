using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace LogicaDeNegocioTest
{
    [TestClass]
    public class GestorTestEps
    {
        [TestMethod]
        public void TestCentrosXEps()
        {
            string EpsEsperada = "[{‘Nombre’:’ClinicaAntioquia’},{‘Nombre’:’CaldasAntioquia’},{‘Nombre’:’CaldasAntioquia’}]".Replace("’", "'");
            GestorEps Gp = new GestorEps();
            
            Convertidor obj1 = new Convertidor();
            Assert.AreEqual(EpsEsperada, obj1.DataTableToJsonObj(Gp.MostrarEps("SURA")).Replace("\"", "'"));
        }

        public void TestMostrarEps()
        {
            string EpsEsperada = "[{‘IDEps’:’1’,’Nombre’:’SURA’},{‘IDEps’:’4’,’Nombre’:’Sabia’}]".Replace("’", "'");
            Convertidor obj1 = new Convertidor();
            GestorEps Gp = new GestorEps();
            Assert.AreEqual(EpsEsperada, obj1.DataTableToJsonObj(Gp.MostrarEps1()).Replace("\"", "'"));
        }
    }
}
