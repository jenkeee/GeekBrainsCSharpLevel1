using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2CountNumbersOfNumber
{
    class Program
    {
        /// <summary>
        /// Задача 2
        /// Написать метод подсчета количества цифр числа.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text:"Задача 2. Написать метод подсчета количества цифр числа.");
            ///////////////////////////////////////////////////////////////////////////////////
            int number = MyHelper.GetNumberFromConsole("Введите число (int)");
            int count = GetCountNumbersInNumber(number);
            WriteLine($"Количество цифр в этом числе: {count}");
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Метод подсчета количества цифр числа
        /// </summary>
        /// <param name="number">число</param>
        /// <returns>количество цифр в этом числе</returns>
        private static int GetCountNumbersInNumber(int number)
        {
            int count = default;
            while (number > 0)
            {
                count++;
                number = number / 10;
            }
            return count;
        }
    }
}
