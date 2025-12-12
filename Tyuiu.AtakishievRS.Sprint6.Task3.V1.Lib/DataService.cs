using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtakishievRS.Sprint6.Task3.V1.Lib
{
    public class DataService : ISprint6Task3V1
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = (int[,])matrix.Clone();

            int[] firstColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                firstColumn[i] = result[i, 0];
            }

            Array.Sort(firstColumn);

            for (int i = 0; i < rows; i++)
            {
                result[i, 0] = firstColumn[i];
            }

            return result;
        }
    }
   
}
