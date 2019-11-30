using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp6CountGoodNumbers
{
    class Program
    {
        /// <summary>
        /// Задача 6.
        /// *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
        /// «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт
        /// времени выполнения программы, используя структуру DateTime.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 6. Программа подсчета количества хороших чисел в диапазоне от 1 до 1_000_000_000.");
            ///////////////////////////////////////////////////////////////////////////////////
            DateTime begin = DateTime.Now;




            WriteLine($"Время выполения программы: {DateTime.Now - begin}");
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }
}
