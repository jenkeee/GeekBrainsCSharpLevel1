using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp7RecursiveMethods
{
    class Program
    {
        /// <summary>
        /// Задача 7.
        /// a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        /// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 7. Рекурсивные методы.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт А. Рекурсивный метод вывода на экран чисел от a до b (a < b).");
            var (noCancel, numberA, numberB) = InputNumbersFromUser(); //Ввод входных значений с консоли
            if (noCancel)
            {
                PrintNumberRecursive(numberA, numberB); //рекурсивный вывод чисел на экран
            }
            WriteLine("\n");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт Б. Рекурсивный метод суммы чисел от a до b. (число а может быть больше b)");
            (noCancel, numberA, numberB) = InputNumbersFromUser(); //Ввод входных значений с консоли
            if (noCancel)
            {
                int sum = SummNumberRecursive(numberA, numberB); //рекурсивная сумма чисел
                WriteLine($"Сумма чисел = {sum}");
            }
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Ввод входных значений с консоли
        /// </summary>
        /// <returns>Введенные пользователем значения и признак что числа введены</returns>
        private static (bool, int, int) InputNumbersFromUser()
        {
            bool noCancel = MyHelper.GetNumberFromConsole(out int numberA, "Пожалуйств введите число a (int) q-отмена");
            if (noCancel)
            {
                noCancel = MyHelper.GetNumberFromConsole(out int numberB, "Пожалуйста введите число b (int) q-отмена");
                return (noCancel, numberA, numberB);
            }
            return (noCancel, default, default); //пользователь отменил ввод
        }
        /// <summary>
        /// Рекурсивный вывод чисел на экран
        /// </summary>
        /// <param name="a">от</param>
        /// <param name="b">до</param>
        private static void PrintNumberRecursive(int a, int b)
        {
            Write($"{a} ");
            if (a < b)
            {
                PrintNumberRecursive(a + 1, b); //пробег по всем числам
            }
        }
        /// <summary>
        /// Рекурсивная сумма чисел
        /// </summary>
        /// <param name="a">от</param>
        /// <param name="b">до</param>
        /// <returns></returns>
        private static int SummNumberRecursive(int a, int b)
        {
            if (a < b)
            {
                return a + SummNumberRecursive(a + 1, b); //пробег если первое меньше второго
            }
            if (a > b)
            {
                return a + SummNumberRecursive(a - 1, b); //пробег если первое больше второго
            }
            return a; //конечный метод
        }
    }
}
