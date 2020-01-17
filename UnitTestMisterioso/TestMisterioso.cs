using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMisterioso
{
    [TestClass]
    public class TestCalcoloMisterioso
    {
        [TestMethod]
        public void TestMethodMisterioso()
        {
            double [] v = new double[] {3,2,4};
            double numero_attuale = CalcoloMisterioso.CalcoloMisterioso.CalcoloMisterioso1(v);
            double risposta_aspettato = 9;
            Assert.AreEqual(risposta_aspettato, numero_attuale);
        }
    }
}
