using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1Form
{
    class Program
    {
        /// <summary>
        /// Задача 1.
        /// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        /// а) используя  склеивание;
        /// б) используя форматированный вывод;
        /// в) используя вывод со знаком $.
        /// Рассахатский
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MyHeader(text: "Задача 1. Написать программу «Анкета». Последовательно задаются вопросы...");



            MyFooter();
        }

        /// <summary>
        /// Вывод моей шапки консольного приложения
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        static void MyHeader(string title = "Geekbrains. C# Уровень 1.", string text = "")
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

        static void MyFooter(string text = "Для выхода нажмите любую кнопку ...")
        {
            WriteLine(text);
            ReadKey();
        }
    }
}
