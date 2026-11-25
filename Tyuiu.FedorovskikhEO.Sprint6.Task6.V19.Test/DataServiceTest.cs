using System.IO;
using Tyuiu.FedorovskikhEO.Sprint6.Task6.V19.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task6.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = Path.Combine(@"C:\DataSprint6\InPutDataFileTask6V19.txt");

            string res = ds.CollectTextFromFile(path);
            string wait = "HqrXl PAlR TwlB AWkgYPxilmC";

            Assert.AreEqual(wait, res);

        }
    }
}
