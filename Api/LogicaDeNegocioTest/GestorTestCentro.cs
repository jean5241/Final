using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace LogicaDeNegocioTest
{
    [TestClass]
    public class GestorTestCentro
    {
        [TestMethod]
        public void TestMostrarInfocentros()
        {

            string EpsEsperada = "[{‘Nombre’:’ClinicaAntioquia’},{‘Nombre’:’CaldasAntioquia’},{‘Nombre’:’Comfama’}]".Replace("’", "'");
            Gestorcentro Gp = new Gestorcentro();
            Convertidor obj1 = new Convertidor();
            Assert.AreEqual(EpsEsperada, obj1.DataTableToJsonObj(Gp.MostrarInfocentros()).Replace("\"", "'"));
        }

        [TestMethod]
        public void TestMostrarNombreCentroMedico()
        {

            string EpsEsperada = "[{‘Nombre’:’ClinicaAntioquia’},{‘Nombre’:’CaldasAntioquia’},{‘Nombre’:’CaldasAntioquia’}]".Replace("’", "'");
            Gestorcentro Gp = new Gestorcentro();
            Convertidor obj1 = new Convertidor();
            Assert.AreEqual(EpsEsperada, obj1.DataTableToJsonObj(Gp.MostrarNombreCentroMedico(43165413)).Replace("\"", "'"));
        }
    }
}
