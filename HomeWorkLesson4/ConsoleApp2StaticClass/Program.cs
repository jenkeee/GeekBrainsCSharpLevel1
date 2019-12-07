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
        /// Реализуйте задачу 1 в виде статического класса StaticClass;
        /// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        /// б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
        /// в)**Добавьте обработку ситуации отсутствия файла на диске.
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
            int[] arrLoaded = StaticClass.LoadArrayFromFile(@"..\..\data.txt");
            WriteLine("Массив загруженных элементов из файла:");
            Array.ForEach(arrLoaded, WriteLine); //вывод массива
            WriteLine();
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт В. Обработка ситуации отсутствия файла на диске.");
            MyHelper.MyPause("Начинаю считывать данные из файла 'не существует.txt'. Нажмите любую кнопку...");
            int[] arrNoLoaded = default;
            try
            {
                arrNoLoaded = StaticClass.LoadArrayFromFile(@"..\..\не существует.txt");
            }
            catch (Exception e)
            {
                MyHelper.MyPause(e.Message + "\nДальнейшая работа программы невозможна. Нажмите любую кнопку ...");
                return;
            }
            WriteLine("Массив загруженных элементов из файла:");
            Array.ForEach(arrNoLoaded, WriteLine); //вывод массива
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }
}
