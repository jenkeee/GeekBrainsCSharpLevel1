using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1TableFunction
{
    class Program
    {
        /// <summary>
        /// Задача 1
        /// Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа
        /// double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и
        /// функцией a*sin(x).
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 1. Таблица функции.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Таблица функции возведения в куб числа (y = x * x * x):");
            TableToConsole(MyFunc1, 0, -5, 5);
            MyHelper.MyPause();
            WriteLine("Таблица функции возведения в квадрат числа с прибавкой (y = a * x ^ 2):");
            TableToConsole(MyFunc2, 3, -5, 5);
            MyHelper.MyPause();
            WriteLine("Таблица функции синуса с прибавкой (y = a * sin(x)):");
            TableToConsole(MyFunc3, 3, -5, 5);
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Вывод значения функции в консоль
        /// </summary>
        /// <param name="fun">Функция</param>
        /// <param name="a">Добавка</param>
        /// <param name="x">Аргумент начальный</param>
        /// <param name="end">Предел аргумента</param>
        private static void TableToConsole(Fun fun, double a, double x, double end)
        {
            WriteLine("-------- A -------- X -------- Y -");
            while (x <= end)
            {
                WriteLine($"| {a,8:F3} | {x,8:F3} | {fun(a, x),8:F3} |");
                x++;
            }
            WriteLine("----------------------------------");
        }
        /// <summary>
        /// Описание типа делеагата
        /// </summary>
        /// <param name="a">добавка</param>
        /// <param name="x">аргумент</param>
        /// <returns>значение функции</returns>
        private delegate double Fun(double a, double x);
        /// <summary>
        /// Куб функция
        /// </summary>
        /// <param name="a">добавка</param>
        /// <param name="x">аргумент</param>
        /// <returns>значение функции</returns>
        private static double MyFunc1(double a, double x) => x * x * x;
        /// <summary>
        /// Возведение в квадрат
        /// </summary>
        /// <param name="a">добавка</param>
        /// <param name="x">аргумент</param>
        /// <returns>значение функции</returns>
        private static double MyFunc2(double a, double x) => a * Math.Pow(x, 2);
        /// <summary>
        /// Синус функции
        /// </summary>
        /// <param name="a">добавка</param>
        /// <param name="x">аргумент</param>
        /// <returns>значение функции</returns>
        private static double MyFunc3(double a, double x) => a * Math.Sin(x);
    }
}
