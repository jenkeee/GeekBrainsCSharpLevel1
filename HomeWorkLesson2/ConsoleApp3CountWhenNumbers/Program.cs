using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3CountWhenNumbers
{
    class Program
    {
        /// <summary>
        /// Задача 3
        /// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех
        /// нечетных положительных чисел.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text:"Задача 3. Подсчитать сумму всех нечетных положительных чисел.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Ввести 0 для выхода из цикла и показа результата.");
            int sumNumbers = CountFromConsoleNumbers();
            WriteLine($"Сумма нечетных и положительных чисел = {sumNumbers}");
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Подсчет суммы введенных чисел с консоли - при этом нечетных и положительных
        /// </summary>
        /// <returns></returns>
        private static int CountFromConsoleNumbers()
        {
            int sumNumbers = 0; //сумма вводимых чисел
            while (true)
            {
                Write("Введите число (int):>");
                if (Int32.TryParse(ReadLine(), out int number))
                {
                    if (number > 0  && number % 2 != 0)
                    {
                        sumNumbers += number;
                    }
                    else if (number == 0)
                    {
                        return sumNumbers;
                    }
                }
                else
                {
                    WriteLine("Ошибка! Введен неверный формат числа! Попробуйте еще раз!");
                    Beep(500,500);
                }
            }
        }


    }
}
