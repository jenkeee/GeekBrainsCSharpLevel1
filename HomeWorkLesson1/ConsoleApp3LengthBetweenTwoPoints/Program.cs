using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3LengthBetweenTwoPoints
{
    class Program
    {
        /// <summary>
        /// Задача 3.
        /// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и
        /// x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя
        /// спецификатор формата .2f (с двумя знаками после запятой);
        /// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
        /// Рассахатский
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MyHeader(text: "Задача 3. Подсчет расстояния между двумя точками.");
            ///////////////////////////////////////////////////////////////
            WriteLine("Пункт А. Простой расчет.");
            WriteLine("Введите координаты первой точки:");
            int x1 = getIntFromConsole("x1 =");
            int y1 = getIntFromConsole("y1 =");
            WriteLine("Введите координаты второй точки:");
            int x2 = getIntFromConsole("x2 =");
            int y2 = getIntFromConsole("y2 =");

            double length1 =  Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //подсчет расстояния

            WriteLine($"Расстояние между двумя точками: {length1:F2}");
            WriteLine("Для продолжения нажмите любую кнопку ...\n");
            ReadKey();
            ///////////////////////////////////////////////////////////////
            WriteLine("Пункт Б. Расчет в виде метода.");
            WriteLine("Введите координаты первой точки:");
            x1 = getIntFromConsole("x1 =");
            y1 = getIntFromConsole("y1 =");
            WriteLine("Введите координаты второй точки:");
            x2 = getIntFromConsole("x2 =");
            y2 = getIntFromConsole("y2 =");

            double length2 = calculateFormula(x1, y1, x2, y2);

            WriteLine($"Расстояние между двумы точками: {length2:F2}");
            ///////////////////////////////////////////////////////////////
            MyFooter();
        }

        private static double calculateFormula(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        private static int getIntFromConsole(string message)
        {
            while (true)
            {
                Write($"{message}:>");
                if (int.TryParse(ReadLine(), out int number))
                {
                    return number;
                }
                WriteLine("Ошибка! Неверный формат введеного целого числа.");
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
