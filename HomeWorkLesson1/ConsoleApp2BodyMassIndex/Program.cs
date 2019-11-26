﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2BodyMassIndex
{
    class Program
    {
        /// <summary>
        /// Задача 2.
        /// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела
        /// (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
        /// Рассахатский
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MyHeader(text: "Задача 2. Рассчитать и вывести индекс массы тела.");
            ////////////////////////////////////////////////////////////////////
            int weight = getIntFromConsole();
            WriteLine(weight);

            ////////////////////////////////////////////////////////////////////
            MyFooter();
        }

        /// <summary>
        /// Ввод целого числа массы человека с консоли
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static int getIntFromConsole(string message = "Введите массу тела в килограммах")
        {
            while (true)
            {
                Write($"{message}:>");
                if (int.TryParse(ReadLine(), out int number))
                {
                    if (number >= 20 && number <= 100)
                    {
                        return number;
                    }
                    WriteLine("Введенная масса нарушает границу нормы 20-100 кг.");
                    Beep(300,500);
                    continue;
                }
                WriteLine("Ошибка! Введен неверный формат целого числа!");
                Beep(500,500);
            }
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