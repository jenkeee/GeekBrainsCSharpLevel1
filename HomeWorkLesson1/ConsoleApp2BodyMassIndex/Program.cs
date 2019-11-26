using System;
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
        static void Main()
        {
            MyHeader(text: "Задача 2. Рассчитать и вывести индекс массы тела.");
            ////////////////////////////////////////////////////////////////////
            int weight = getIntFromConsole("Введите массу тела в килограммах"); 
            double growth = getDoubleFromConsole("Введите рост тела в метрах");
            double bodyMassIndex = CalculateFormula(weight, growth); //расчет массы тела
            WriteLine($"Индекс массы тела равен: {bodyMassIndex:F1}");
            ////////////////////////////////////////////////////////////////////
            MyFooter();
        }
        /// <summary>
        /// Формула расчета
        /// </summary>
        /// <param name="m"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        private static double CalculateFormula(double m, double h)
        {
            return m / (h * h);
        }

        /// <summary>
        /// Ввод вещественного числа роста человека с консоли
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static double getDoubleFromConsole(string message)
        {
            while (true)
            {
                Write($"{message}:>");
                if (double.TryParse(ReadLine(), out double number))
                {
                    if (number >= 0.5 && number <= 2.0)
                    {
                        return number;
                    }
                    WriteLine("Введенный рост тела нарушает границу нормы 0.5 - 2.0 метра.");
                    Beep(300,500);
                    continue;
                }
                WriteLine("Ошибка! Введен неверный формат вещественного числа!");
                Beep(500,500);
            }
        }

        /// <summary>
        /// Ввод целого числа массы человека с консоли
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static int getIntFromConsole(string message)
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
