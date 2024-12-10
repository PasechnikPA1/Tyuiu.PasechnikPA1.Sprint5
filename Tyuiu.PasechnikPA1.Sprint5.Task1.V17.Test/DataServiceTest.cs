using Tyuiu.PasechnikPA1.Sprint5.Task1.V17.Lib;
using System.IO;
namespace Tyuiu.PasechnikPA1.Sprint5.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\\Users\\Павел\\source\\repos\\Tyuiu.PasechnikPA1.Sprint5\\Tyuiu.PasechnikPA1.Sprint5.Task1.V17\\bin\\Debug\\net8.0\\OutputFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
