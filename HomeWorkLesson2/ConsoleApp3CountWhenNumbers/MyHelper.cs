using System;
using static System.Console;

namespace ConsoleApp3CountWhenNumbers
{
    /// <summary>
    /// Мой класс с полезными инструментами
    /// </summary>
    static class MyHelper
    {
        /// <summary>
        /// Ввод целого числа с консольного приложения
        /// </summary>
        /// <param name="message">Сообщение-приглашение для пользователя</param>
        /// <returns>Введенное пользователем число</returns>
        internal static int GetNumberFromConsole(string message = "Пожалуйста введите целое число (int)")
        {
            while (true)
            {
                Write($"{message}:>");
                if (Int32.TryParse(ReadLine(), out int number))
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
        /// <param name="title">Заголовок консоли</param>
        /// <param name="text">Текст вверху экрана консоли</param>
        internal static void MyHeader(string title = "Geekbrains. C# Уровень 1.", string text = "")
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
        /// Вывод моего подвала
        /// </summary>
        /// <param name="text">Текст внизу экрана консоли</param>
        internal static void MyFooter(string text = "Для выхода нажмите любую кнопку ...")
        {
            WriteLine("\n" + text);
            ReadKey();
        }
    }
}
