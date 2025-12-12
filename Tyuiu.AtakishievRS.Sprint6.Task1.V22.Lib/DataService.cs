using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AtakishievRS.Sprint6.Task1.V22.Lib
{
    public class DataService : ISprint6Task1V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] results = new double[count];

            for (int i = 0; i < count; i++)
            {
                double x = startValue + i;
                double mainPart = 3 * x + 2;
                double denominator = Math.Cos(x) + 1;

                if (Math.Abs(denominator) <= 0) 
                {
                    results[i] = 0;
                }
                else
                {
                    results[i] = mainPart - (x / denominator);
                }

                results[i] = Math.Round(results[i], 2);
            }

            return results;
        }
    }
}
