using Tyuiu.PasechnikPA1.Sprint5.Task4.V5.Lib;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Tyuiu.PasechnikPA1.Sprint5.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
