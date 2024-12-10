using Tyuiu.PasechnikPA1.Sprint5.Task2.V13.Lib;
namespace Tyuiu.PasechnikPA1.Sprint5.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = $@"C:\Users\Павел\source\repos\Tyuiu.PasechnikPA1.Sprint5\Tyuiu.PasechnikPA1.Sprint5.Task2.V13\bin\Debug\net8.0\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
