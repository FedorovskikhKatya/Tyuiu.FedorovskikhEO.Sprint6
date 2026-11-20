using Tyuiu.FedorovskikhEO.Sprint6.Task2.V22.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            double[] wait = { 7.76, 7.36, 7.26, 7.90, 15.88, 2.00, 4.35, 5.63, 6.49, 6.49, 6.32 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
