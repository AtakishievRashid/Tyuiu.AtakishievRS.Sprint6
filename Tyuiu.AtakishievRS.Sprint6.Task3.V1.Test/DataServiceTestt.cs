using Tyuiu.AtakishievRS.Sprint6.Task3.V1.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTestt
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = {
        {25, 20, 28, 2, 6},
        {19, 9, 18, -7, 24},
        {21, 16, 5, -7, -8},
        {30, -13, 1, -15, 2},
        {31, 9, -3, -9, -18}
    };

            int[,] result = ds.Calculate(matrix);

            int[] expectedFirstCol = { 19, 21, 25, 30, 31 };

            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(expectedFirstCol[i], result[i, 0]);
            }
        }
    }
}
