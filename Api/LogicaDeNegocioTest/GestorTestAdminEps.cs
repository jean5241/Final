using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace LogicaDeNegocioTest
{
    [TestClass]
    public class GestorTestAdminEps
    {
        [TestMethod]
        public void TestValidarAdminEps()
        {

            bool respuesta = true;
            GestorAdminEps Gp = new GestorAdminEps();
            Convertidor obj1 = new Convertidor();
            Assert.AreEqual(respuesta, (Gp.ValidarAdminEps("SURA","798")));
        }
    }
}
