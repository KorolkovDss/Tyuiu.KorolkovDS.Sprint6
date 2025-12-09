using Tyuiu.KorolkovDS.Sprint6.Task6.V19.Lib;

namespace Tyuiu.KorolkovDS.Sprint6.Task6.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V19.txt";
            DataService ds = new DataService();


            string wait = "HqrXl PAlR TwlB AWkgYPxilmC";
            string res = ds.CollectTextFromFile(path);

            Assert.AreEqual(wait, res);
        }
    }
}
