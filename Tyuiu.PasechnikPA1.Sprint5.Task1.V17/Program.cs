﻿using Tyuiu.PasechnikPA1.Sprint5.Task1.V17.Lib;
namespace Tyuiu.PasechnikPA1.Sprint5.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Крутикова В. П. | АСОиУБ-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Обработка файлов                                                   *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #17                                                              *");
            Console.WriteLine("* Выполнил: Крутикова Валерия Павловна | АСОиУБ-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дана функция на диапазоне [-5;5] с шагом 1. Произвести проверку деления  *");
            Console.WriteLine("* на ноль. При деление на ноль вернуть значение 0. Результат сохранить     *");
            Console.WriteLine("* в текстовый файл OutPutFileTask1.txt и вывести на консоль.               *");
            Console.WriteLine("* Значения окрулить до двух знаков после запятой.                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine($"начало диапазона = {startValue}");
            Console.WriteLine($"конец диапазона = {stopValue}");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
