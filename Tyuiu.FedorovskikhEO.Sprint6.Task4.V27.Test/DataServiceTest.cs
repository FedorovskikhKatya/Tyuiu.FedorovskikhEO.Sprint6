using Tyuiu.FedorovskikhEO.Sprint6.Task4.V27.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task4.V27.Test
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

            waitArray[0] = -15.44;
            waitArray[1] = -10.93;
            waitArray[2] = -7.22;
            waitArray[3] = -5.04;
            waitArray[4] = 0.00;
            waitArray[5] = -0.30;
            waitArray[6] = 2.57;
            waitArray[7] = 6.40;
            waitArray[8] = 10.04;
            waitArray[9] = 12.72;
            waitArray[10] = 14.68;

            double[] resArray = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}
