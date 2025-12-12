using Tyuiu.AtakishievRS.Sprint6.Task4.V3.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task4.V3.Test
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
        -0.18, -0.22, -0.28, -0.37, -0.54,
        1.50, 0.28, 0.15, 0.09, 0.06, 0.04
    };

            Assert.AreEqual(expected.Length, result.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.001);
            }
        }
    }
}
