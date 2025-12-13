using Tyuiu.AtakishievRS.Sprint6.Task5.V26.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string tempFile = Path.GetTempFileName();
            File.WriteAllLines(tempFile, new[] { "10", "25", "3", "15", "7", "20" });

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(tempFile);

            double[] expected = { 10, 25, 15, 20 };

            Assert.AreEqual(expected.Length, result.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }

            File.Delete(tempFile);
        }
    }
}
