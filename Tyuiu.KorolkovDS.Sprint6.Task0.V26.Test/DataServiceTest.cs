using Tyuiu.KorolkovDS.Sprint6.Task0.V26.Lib;

namespace Tyuiu.KorolkovDS.Sprint6.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 3;
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            double wait = 0.769;
            Assert.AreEqual(wait, res);
        }
    }
}
