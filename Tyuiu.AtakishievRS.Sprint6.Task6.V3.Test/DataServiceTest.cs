using Tyuiu.AtakishievRS.Sprint6.Task6.V3.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string tempFile = Path.GetTempFileName();
            File.WriteAllLines(tempFile, new[] { "apple", "orange", "banana" });

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(tempFile);

            Assert.AreEqual("orange", result.Trim());

            File.Delete(tempFile);
        }
    }
}
