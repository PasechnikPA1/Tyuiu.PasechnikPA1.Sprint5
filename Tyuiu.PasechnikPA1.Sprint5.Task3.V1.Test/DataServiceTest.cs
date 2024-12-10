using Tyuiu.PasechnikPA1.Sprint5.Task3.V1.Lib;
using System.IO;
namespace Tyuiu.PasechnikPA1.Sprint5.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\1\Павел\repos\Tyuiu.PasechnikPA1.Sprint5\Tyuiu.PasechnikPA1.Sprint5.Task3.V1\bin\Debug\net8.0\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
