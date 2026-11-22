using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FedorovskikhEO.Sprint6.Task3.V7.Lib
{
    public class DataService : ISprint6Task3V7
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int count = 0;
            for (int i =0;  i < rows-1; i++)
            {
                for (int j=0; j<columns-1;j++)
                {
                    if (matrix[j, 3] > matrix[j+1,3])
                    {
                        int savedValue=matrix[j, 3];
                        matrix[j,3]=matrix[j+1,3];
                        matrix[j+1,3]=savedValue;
                    }
                }

            }
            return matrix;
        }
    }
}
