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
            MyHeader(text: "Задача 1. Написать программу «Анкета».");
            ///////////////////////////////////////////////////////////////
            string surname = getStringFromConsole("Введите фамилию человека");
            string name = getStringFromConsole("Введите имя человека");
            int age = getIntFromConsole("Введите возраст человека");
            int growth = getIntFromConsole("Введите рост человека (см)");
            int weight = getIntFromConsole("Введите вес человека (кг)");
            WriteLine("\n\nВывод информации:\n");
            WriteLine("Используя склеивание:");
            WriteLine("Фамилия: " + surname + " Имя: " + name + " Возраст: " + age + " лет Рост: " + growth + " см Вес: " + weight + " кг.");
            WriteLine("\nИспользуя форматированный вывод:");
            WriteLine("Фамилия: {0} Имя: {1} Возраст: {2} лет Рост: {3} см Вес: {4} кг.", surname, name, age, growth, weight);
            WriteLine("\nИспользуя вывод со знаком $:");
            WriteLine($"Фамилия: {surname} Имя: {name} Возраст: {age} лет Рост: {growth} см Вес: {weight} кг.");
            ///////////////////////////////////////////////////////////////
            MyFooter();
        }
        /// <summary>
        /// Получение строки с консоли
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static string getStringFromConsole(string message)
        {
            Write($"{message}:>");
            return ReadLine();
        }
        /// <summary>
        /// Получение числа с консоли
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
                    return number;
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
