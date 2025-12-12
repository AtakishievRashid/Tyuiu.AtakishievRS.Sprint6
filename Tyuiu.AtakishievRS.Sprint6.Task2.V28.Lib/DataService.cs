using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtakishievRS.Sprint6.Task2.V28.Lib
{
    public class DataService : ISprint6Task2V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] results = new double[count];

            for (int i = 0; i < count; i++)
            {
                double x = startValue + i;
                double den = 3 * x - 1;

                if (Math.Abs(den) < 0.000001)
                {
                    results[i] = 0;
                }
                else
                {
                    double sinX = Math.Sin(x);
                    double a = (sinX - 2 * x) / den;
                    double b = sinX - 3 * x + 2;
                    results[i] = Math.Round(a + b, 2);
                }
            }

            return results;
        }
    }
}
