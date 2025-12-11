using Tyuiu.AtakishievRS.Sprint6.Task0.V9.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            double res = ds.Calculate(1);
            double wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
