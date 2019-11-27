using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp6CreateClass
{
    class Program
    {
        /// <summary>
        /// Задача 6.
        /// *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
        /// Рассахатский
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MyHeader(text: "Задача 6. Создать класс с методами, которые могут пригодиться в вашей учебе.");
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
