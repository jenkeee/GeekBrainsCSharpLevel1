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
        static void Main()
        {
            MyHeader(text: "Задача 5. Имя, фамилия, город проживания.");
            ///////////////////////////////////////////////////////////////
            WriteLine("Пункт А. Вывод на экран имени, фамилии и города проживания.");
            string myName = "Андрей";
            string mySurname = "Рассахатский";
            string myCity = "Кузнецк";
            WriteLine($"Фамилия: {mySurname} Имя: {myName} Город: {myCity}");
            MyFooter("Для продолжения нажмите любую кнопку ...");
            Clear();
            //////////////////////////////////////////////////////////////
            SetCursorPosition(30,12);
            WriteLine("Пункт Б. Вывод на экран в центре экрана.");
            SetCursorPosition(30,14);
            WriteLine($"Фамилия: {mySurname} Имя: {myName} Город: {myCity}");
            SetCursorPosition(30,16);
            WriteLine("Для продолжения нажмите любую кнопку ...");
            ReadKey();
            Clear();
            ///////////////////////////////////////////////////////////////
            MyPrint("Пункт В. Вывод на экран с помощью метода.", 30, 9);
            MyPrint($"Фамилия: {mySurname} Имя: {myName} Город: {myCity}", 30, 11);
            ///////////////////////////////////////////////////////////////
            MyFooter();
        }
        /// <summary>
        /// Вывод текста в определенном месте экрана
        /// </summary>
        /// <param name="message"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private static void MyPrint(string message, int x, int y)
        {
            SetCursorPosition(x, y);
            WriteLine(message);
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
