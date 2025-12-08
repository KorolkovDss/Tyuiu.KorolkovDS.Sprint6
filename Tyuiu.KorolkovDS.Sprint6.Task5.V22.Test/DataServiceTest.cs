using Tyuiu.KorolkovDS.Sprint6.Task5.V22.Lib;

namespace Tyuiu.KorolkovDS.Sprint6.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @$"{Directory.GetCurrentDirectory()}InPutDataFileTask5V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
