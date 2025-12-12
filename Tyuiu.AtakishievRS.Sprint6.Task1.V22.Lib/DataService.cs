using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtakishievRS.Sprint6.Task1.V22.Lib
{
    public class DataService : ISprint6Task1V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int сount = stopValue - startValue + 1;
            double[] results = new double[сount];

            for (int i = 0; i < сount; i++)
            {
                double x = startValue + i;
                double num = x;
                double den = 3 * x + 2 * Math.Cos(x) + 1;

                if (den == 0)
                {
                    results[i] = 0;
                }
                else
                {
                    results[i] = num / den;
                }
            }

            return results;
        }
    }
}
