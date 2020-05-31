using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taschenrechner.Tests
{
    [TestClass()]
    public class RechnerModelTests
    {
        [TestMethod()]
        public void Berechne_DivisionDurchNull_ergbitUnendlich()
        {
            RechnerModel model = new RechnerModel();

            model.Operation = "/";
            model.ErsteZahl = 10;
            model.ZweiteZahl = 0;

            model.Berechne();

            Assert.AreEqual(double.PositiveInfinity, model.Resultat);
        }
    }
}