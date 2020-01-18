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
            double[] v = new double[] { };
            double numero_attuale = CalcoloMisterioso.CalcoloMisterioso.CalcoloMisterioso1(v);
            double risposta_aspettato = double.NaN;
            Assert.AreEqual(risposta_aspettato, numero_attuale);
        }
        [TestMethod]
        public void TestMethodMisterioso3()
        {
            double[] v = new double[] { 2, 7, 9 };
            double numero_attuale = CalcoloMisterioso.CalcoloMisterioso.CalcoloMisterioso2(v);
            double risposta_aspettato = 126;
            Assert.AreEqual(risposta_aspettato, numero_attuale);

        }
        [TestMethod]
        public void TestMethodMisterioso4()
        {
            double[] v = new double[] { 2 };
            double numero_attuale = CalcoloMisterioso.CalcoloMisterioso.CalcoloMisterioso2(v);
            double risposta_aspettato = 2;
            Assert.AreEqual(risposta_aspettato, numero_attuale);
        }
    }
}
        


