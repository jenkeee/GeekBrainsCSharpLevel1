using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5SurnameNameCity
{
    class Program
    {
        /// <summary>
        /// Задача 5.
        /// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        /// б) *Сделать задание, только вывод организовать в центре экрана.
        /// в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
        /// Рассахатский
        /// </summary>
        static void Main(string[] args)
        {
            MyHeader(text: "Задача 5. Имя, фамилия, город проживания.");
            ///////////////////////////////////////////////////////////////


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
