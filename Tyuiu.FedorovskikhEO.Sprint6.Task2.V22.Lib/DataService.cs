using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task2.V22.Lib
{
    public class DataService : ISprint6Task2V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double znamуnatel = Math.Cos(x) + x;
                if (znamуnatel == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (2 * x - 3) / znamуnatel + 5;
                }
                y = Math.Round(y, 2);
                valueArray[count] = y;
                count++;

            }
            return valueArray;
        }
    }
}
