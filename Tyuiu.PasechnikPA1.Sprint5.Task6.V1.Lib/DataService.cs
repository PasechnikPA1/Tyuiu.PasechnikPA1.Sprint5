﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tyuiu.PasechnikPA1.Sprint5.Task6.V1.Lib
{
    public class DataService : ISprint5Task6V1
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char i in line)
                    {
                        if (char.IsDigit(i))
                        {
                            res++;
                        }
                    }
                }
            }
            return res;
        }
    }
}
