using System;
using static System.Console;

namespace ConsoleApp6CountGoodNumbers
{
    /// <summary>
    /// Мой класс с полезными инструментами
    /// </summary>
    static class MyHelper
    {
        /// <summary>
        /// Ввод целого числа с консоли
        /// </summary>
        /// <param name="number">вертаемое введенное целое число</param>
        /// <param name="message">сообщение приглашение</param>
        /// <param name="min">минимум диапазона</param>
        /// <param name="max">максимум диапазона</param>
        /// <returns>признак что число введено</returns>
        internal static bool GetNumberFromConsole(out int number, string message = "Пожалуйста введите целое число (int) (q-отмена)", int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                Write($"{message}:>");
                string buffString = ReadLine();
                if (Int32.TryParse(buffString, out int num)) //введено должно быть число
                {
                    if (num < max && num > min) //число должно быть в допустимом диапазоне
                    {
                        number = num;
                        return true;
                    }
                    WriteLine($"Ошибка! Введенное число превышает разрешенный диапазон от {min} до {max}!");
                }
                else if (buffString == "q") //введена пользовательская команда отмена ввода
                {
                    number = default;
                    return false;
                }
                else //введено не число
                {
                    WriteLine("Ошибка! Введен неверный формат целого числа!");
                }
                Beep(500, 500);
            }
        }
        /// <summary>
        /// Ввод вещественного числа с консоли
        /// </summary>
        /// <param name="number">вертаемое введенное вещественное число</param>
        /// <param name="message">сообщение приглашение</param>
        /// <param name="min">минимум диапазона</param>
        /// <param name="max">максимум диапазона</param>
        /// <returns>признак что число введено</returns>
        internal static bool GetNumberFromConsole(out double number, string message = "Пожалуйста введите вещественное число (double) (q-отмена)", double min = double.MinValue, double max = double.MaxValue)
        {
            while (true)
            {
                Write($"{message}:>");
                string buffString = ReadLine();
                if (Double.TryParse(buffString, out double num))
                {
                    if (num < max && num > min) //число должно быть в допустимом диапазоне
                    {
                        number = num;
                        return true;
                    }
                    WriteLine($"Ошибка! Введенное число превышает разрешенный диапазон от {min:f2} до {max:f2}!");
                }
                else if (buffString == "q") //пользовательская команда отмена ввода
                {
                    number = default;
                    return false;
                }
                else
                {
                    WriteLine("Ошибка! Введен неверный формат вещественного числа!");
                }
                Beep(500, 500);
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
