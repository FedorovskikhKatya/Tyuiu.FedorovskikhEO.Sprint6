using Tyuiu.FedorovskikhEO.Sprint6.Task1.V23.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task1.V23.Test
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
            double[] waitArray = new double[11];

            waitArray[0] = 3.30;
            waitArray[1] = -12.37;
            waitArray[2] = -14.02;
            waitArray[3] = -5.57;
            waitArray[4] = 0.65;
            waitArray[5] = 0.00;
            waitArray[6] = -0.65;
            waitArray[7] = 5.57;
            waitArray[8] = 14.02;
            waitArray[9] = 12.37;
            waitArray[10] = -3.30;

            double[] resArray = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}
