using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocio;

namespace LogicaDeNegocioTest
{
    [TestClass]
    public class GestorTestAdminCentro
    {
        [TestMethod]
        public void TestVlaidarAdminCentro()
        {

            bool respuesta = true;
            GestorAdminCentro Gp = new GestorAdminCentro();
            Convertidor obj1 = new Convertidor();
            Assert.AreEqual(respuesta, (Gp.ValidarAdminCentro("ClinicaAntioquia","123456")));
        }
    }
}
