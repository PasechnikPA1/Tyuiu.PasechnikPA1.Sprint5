using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tyuiu.PasechnikPA1.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double count = 0;
            string[] array;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    array = line.Split(" ");
                    for (int i = 0; i < array.Length; i++)
                    {
                        res = res + Math.Round(Convert.ToDouble(array[i]), 3);
                        count++;
                    }

                }
            }
            //double res = 6997;
            //double count = 1000;
            return res / count;
        }
    }
}
