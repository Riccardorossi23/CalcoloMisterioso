using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMisterioso
{
    [TestClass]
    public class TestCalcoloMisterioso
    {
        [TestMethod]
        public void TestMethodMisterioso1()
        {
            double[] v = new double[] { 3, 2, 4 };
            double numero_attuale = CalcoloMisterioso.CalcoloMisterioso.CalcoloMisterioso1(v);
            double risposta_aspettato = 9;
            Assert.AreEqual(risposta_aspettato, numero_attuale);
        }
        [TestMethod]
        public void TestMethodMisterioso2()
        {
            double[] v = new double[] { 0, 0, 0 };
            double numero_attuale = CalcoloMisterioso.CalcoloMisterioso.CalcoloMisterioso1(v);
            double risposta_aspettato = 0;
            Assert.AreEqual(risposta_aspettato, numero_attuale);
        }
        [TestMethod]
        public void TestMethodMisterioso3()
        {
            double[] v = new double[] { 3, 2, 4};
            double numero_attuale = CalcoloMisterioso.CalcoloMisterioso.CalcoloMisterioso2(v);
            double risposta_aspettato = 24;
            Assert.AreEqual(risposta_aspettato, numero_attuale);

        }
    }
}

