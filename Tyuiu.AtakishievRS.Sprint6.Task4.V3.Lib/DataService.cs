using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtakishievRS.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] results = new double[count];

            for (int i = 0; i < count; i++)
            {
                double x = startValue + i;
                double den = Math.Sin(x) - 3 + x;

                if (den == 0)
                {
                    results[i] = 0;
                }
                else
                {
                    double num = 3 * x - 1.5;
                    double value = num / den + 2;
                    results[i] = Math.Round(value, 2);
                }
            }


            return results;
        }
    }
}
