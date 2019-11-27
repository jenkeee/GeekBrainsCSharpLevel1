using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp6CreateClass
{
    /// <summary>
    /// Мой класс с инструментами, который может пригодиться в моей учебе
    /// </summary>
    static class MyToolsClass
    {
        /// <summary>
        /// Вывод текста в определенном месте экрана
        /// </summary>
        /// <param name="message"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        internal static void MyPrint(string message, int x, int y)
        {
            SetCursorPosition(x, y);
            WriteLine(message);
        }
        /// <summary>
        /// Приостановка в консоли
        /// </summary>
        internal static void MyPause()
        {
            ReadKey();
        }
        /// <summary>
        /// Вывод моей шапки консольного приложения
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
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
        /// <param name="text"></param>
        internal static void MyFooter(string text = "Для выхода нажмите любую кнопку ...")
        {
            WriteLine("\n" + text);
            ReadKey();
        }

    }
}
