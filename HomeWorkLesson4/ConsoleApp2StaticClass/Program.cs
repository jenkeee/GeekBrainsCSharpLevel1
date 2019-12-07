using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2StaticClass
{
    class Program
    {
        /// <summary>
        /// Задача 2
        ///
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 2. Добавление статического класса StaticClass.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт А. Статический класс решения поставленной задачи.");
            int[] arrInts = StaticClass.GetArrayWithRandomNum(20); //получить массив
            WriteLine("Массив элементов из случайных чисел:");
            Array.ForEach(arrInts, WriteLine); //вывод массива
            WriteLine();
            int count = StaticClass.GetCountGoodNumbers(arrInts); //получить количество пар
            WriteLine($"Кол-во пар элементов массива, в которых только одно число делится на три = {count}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт Б. Статический метод считывания массива из текстового файла.");
            
            StaticClass.SaveArrayToFile(arrInts,@"..\..\data.txt");


            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }
}
