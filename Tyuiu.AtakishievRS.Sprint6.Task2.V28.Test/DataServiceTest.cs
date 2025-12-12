using Tyuiu.AtakishievRS.Sprint6.Task2.V28.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            var result = ds.GetMassFunction(-5, 5);

            double[] expected = {
        15.48,  // x = -5
        11.75,  // x = -4  
        9.41,   // x = -3
        7.91,   // x = -2
        6.94,   // x = -1
        2.00,   // x = 0
        -2.13,  // x = 1
        -5.89,  // x = 2
        -9.28,  // x = 3
        -12.38, // x = 4
        -12.69  // x = 5
    };

            Assert.AreEqual(expected.Length, result.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.001);
            }
        }
    }
}
