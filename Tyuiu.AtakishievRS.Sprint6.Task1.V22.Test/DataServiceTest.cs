using Tyuiu.AtakishievRS.Sprint6.Task1.V22.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task1.V22.Test
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
                0.37,  
                0.33,  
                0.30,  
                0.34,  
                1.09,  
                0.00,  
                0.20, 
                0.32,  
                0.37,  
                0.34,  
                0.30   
            };



            Assert.AreEqual(expected.Length, result.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], Math.Round(result[i], 2));
            }
        }
    }
}
