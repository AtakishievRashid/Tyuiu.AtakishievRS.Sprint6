using Tyuiu.AtakishievRS.Sprint6.Task1.V22.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] result = ds.GetMassFunction(-5, 5);

            double[] expected = {
        -9.10, -7.21, -6.28, -5.91, -6.35,
        2.00, 7.13, 10.89, 14.28, 17.38, 20.69
    };

            Assert.AreEqual(expected.Length, result.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.01);
            }
        }
    }
}
