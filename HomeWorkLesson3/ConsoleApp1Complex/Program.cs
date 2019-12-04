using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1Complex
{
    class Program
    {
        /// <summary>
        /// Задача 1.
        /// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
        /// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
        /// в) Добавить диалог с использованием switch демонстрирующий работу класса.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 1. Комплексные числа.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания А. Дописать структуру Complex, добавив метод вычитания комплексных чисел.");
            SComplex c1 = new SComplex(10,10);
            SComplex c2 = new SComplex(1,1);
            WriteLine($"Два комплексных числа: {c1} и {c2}");
            WriteLine($"Сумма чисел = {c1 + c2}");
            WriteLine($"Разность чисел = {c1 - c2}");
            WriteLine($"Произведение чисел = {c1 * c2}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания Б. Дописать класс Complex, добавив методы вычитания и произведения чисел.");
            Complex com1 = new Complex(10, 10);
            Complex com2 = new Complex(1,1);
            WriteLine($"Два комплексных числа: {com1} и {com2}");
            WriteLine($"Сумма чисел = {com1 + com2}");
            WriteLine($"Разность чисел = {com1 - com2}");
            WriteLine($"Произведение чисел = {com1 * com2}");
            WriteLine($"Частное чисел = {com1 / com2}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания В. Добавить диалог с использованием switch, демонстрирующий работу класса.");



            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }
}
