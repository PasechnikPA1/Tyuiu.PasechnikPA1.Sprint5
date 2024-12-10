using Tyuiu.PasechnikPA1.Sprint5.Task0.V6.Lib;
using System.IO;
namespace Tyuiu.PasechnikPA1.Sprint5.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\\Users\\Павел\\source\\repos\\Tyuiu.PasechnikPA1.Sprint5\\Tyuiu.PasechnikPA1.Sprint5.Task0.V6\\bin\\Debug\\net8.0\\OutputFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
