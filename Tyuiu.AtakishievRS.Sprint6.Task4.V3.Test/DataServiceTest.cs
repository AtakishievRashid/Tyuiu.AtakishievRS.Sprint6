using Tyuiu.AtakishievRS.Sprint6.Task4.V3.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            var res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 4.34, 4.16, 3.71, 3.27, 2.93, 2.50, 0.71, -47.61, 55.15, 45.17, 14.97 };
            CollectionAssert.AreEqual(wait, res);
        }

    }
}
