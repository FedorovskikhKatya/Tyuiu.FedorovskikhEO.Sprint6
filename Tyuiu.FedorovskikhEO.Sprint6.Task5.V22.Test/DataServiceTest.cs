using System.IO;
using Tyuiu.FedorovskikhEO.Sprint6.Task5.V22.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask5V22.txt";

            string[] nums = { "-17", "0", "12", "-14,32", "5", "-7,84", "12,89", "-1,57", "-3,64", "-13,26", "-8,91", "-17,77", "35", "-9", "13,83", "12,76", "8,86", "0", "-1,49", "-7" };

            File.WriteAllLines(path, nums);

            double[] wait = { 12, 12.89, 35, 13.83, 12.76, 8.86 };

            double[] res = ds.LoadFromDataFile(path);

            CollectionAssert.AreEqual(wait, res);

            File.Delete(path);
        }
    }
}

