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
            long sum = GetSumGoodNumbers(); //подсчет суммы хороших чисел в диапазоне
            WriteLine($"Результат суммирования: {sum}");
            WriteLine($"Время выполения программы: {DateTime.Now - begin}");
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Суммирование всех хороших чисел на выбранном диапазоне
        /// </summary>
        /// <param name="from">от</param>
        /// <param name="to">до</param>
        /// <returns>сумма чисел</returns>
        private static long GetSumGoodNumbers(int from = 1, int to = 1_000_000_000)
        {
            long sum = default;
            for (int i = from; i < to; i++)
            {
                if (isGoodInt(i)) //определение хорошего числа
                {
                    sum += i;
                }
            }
            return sum;
        }
        /// <summary>
        /// Определение что это хорошее число
        /// </summary>
        /// <param name="number">число</param>
        /// <returns>оно - хорошее</returns>
        private static bool isGoodInt(int number)
        {
            return (number % SumNumbersInNumber(number) == 0);
        }
        /// <summary>
        /// Подсчет суммы цифр числа
        /// </summary>
        /// <param name="num">число</param>
        /// <returns>сумма его цифр</returns>
        private static int SumNumbersInNumber(int num)
        {
            int sum = default;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }
    }
}
