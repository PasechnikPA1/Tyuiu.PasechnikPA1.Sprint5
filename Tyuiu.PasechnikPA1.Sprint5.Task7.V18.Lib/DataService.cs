﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tyuiu.PasechnikPA1.Sprint5.Task7.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7.txt" });
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = File.ReadAllText(path);
            strLine = strLine.Replace("н", "нн");
            strLine = strLine.Replace("Н", "НН");
            File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);

            return pathSaveFile;
        }
    }
}
