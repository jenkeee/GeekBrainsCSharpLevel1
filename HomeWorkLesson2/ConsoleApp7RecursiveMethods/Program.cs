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


            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт Б. Рекурсивный метод суммы чисел от a до b.");

            
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }
}
