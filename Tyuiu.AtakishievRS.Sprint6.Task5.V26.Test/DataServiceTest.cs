using Tyuiu.AtakishievRS.Sprint6.Task5.V26.Lib;
namespace Tyuiu.AtakishievRS.Sprint6.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\bogra\Desktop\ПРОГАВУЗТИУ\Файлы\InPutFileTask5V26.txt";

            if (!File.Exists(path))
            {
                Assert.Fail($"Файл не найден: {path}");
                return;
            }

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(path);

            Assert.IsNotNull(result);
        }
    }
}
