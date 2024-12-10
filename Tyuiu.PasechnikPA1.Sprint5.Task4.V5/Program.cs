using Tyuiu.PasechnikPA1.Sprint5.Task4.V5.Lib;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PasechnikPA1.Sprint5.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Чазова С.Р | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:    Чтение данных из текстового файла                              *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Чазова Софья Романовна | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask4V0.txt. Создать папку в ручную*");
            Console.WriteLine("* С:/DataSprint5/ и скопировать в неё файл) в котором есть вещественное   *");
            Console.WriteLine("*  значение из файла и подставить вместо Х в формуле Y = 4.26x/sin(x)     *");
            Console.WriteLine("*Вычислить значение (округлить до 3 знаков), вернуть  результат на консоль*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt ";
            Console.WriteLine("Данные находятся в файле:  " + path);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
