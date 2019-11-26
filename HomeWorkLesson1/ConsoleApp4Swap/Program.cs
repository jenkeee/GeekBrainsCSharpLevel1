using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp4Swap
{
    class Program
    {
        /// <summary>
        /// Задача 4.
        /// Написать программу обмена значениями двух переменных:
        /// а) с использованием третьей переменной;
        /// б) *без использования третьей переменной.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHeader(text: "Задача 4. Написать программу обмена значениями двух переменных.");
            ///////////////////////////////////////////////////////////////
            WriteLine("Пункт А. С использованием третей переменной.");
            int one = 1;
            int two = 10;
            WriteLine($"Целые числа до обмена: {one} {two}");
            int temp = one;
            one = two;
            two = temp;
            WriteLine($"Целые числа после обмена: {one} {two}");
            WriteLine("\nДля продолжения нажмите любую кнопку ...\n");
            ReadKey();
            ///////////////////////////////////////////////////////////////
            WriteLine("Пункт Б. Без использования третьей переменной.");
            one = 1;
            two = 10;
            WriteLine($"Целые числа до обмена: {one} {two}");
            one = one - two;
            two = two + one;
            one = -one + two;
            WriteLine($"Целые числа после обмена: {one} {two}");
            ///////////////////////////////////////////////////////////////
            MyFooter();
        }

        /// <summary>
        /// Вывод моей шапки консольного приложения
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        private static void MyHeader(string title = "Geekbrains. C# Уровень 1.", string text = "")
        {
            Title = title;
            WindowWidth = 120;
            BackgroundColor = ConsoleColor.DarkGreen;
            ForegroundColor = ConsoleColor.White;
            WriteLine($"┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            WriteLine($"│{text,-117}│");
            WriteLine($"└─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            WriteLine("");
        }
        /// <summary>
        /// Вывод моей шапки
        /// </summary>
        /// <param name="text"></param>
        private static void MyFooter(string text = "Для выхода нажмите любую кнопку ...")
        {
            WriteLine("\n" + text);
            ReadKey();
        }
    }
}
