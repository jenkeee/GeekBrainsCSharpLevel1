using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2Numbers
{
    class Program
    {
        /// <summary>
        /// Задача 2.
        /// а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
        /// Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму
        /// вывести на экран, используя tryParse;
        /// б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные
        /// данные. При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 2. С клавиатуры вводятся числа плюс обработка исключительных ситуаций.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания А. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.");
            WriteLine("Вводите числа типа int через <Enter>, ввести 0 для вывода результата суммирования чисел:");
            int sum1 = Summ();
            WriteLine($"Сумма введенных хороших чисел = {sum1}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания Б. Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. Подсчитать сумму всех нечетных положительных чисел.");
            WriteLine("Вводите числа типа int через <Enter>, ввести 0 для вывода результата суммирования чисел:");
            int sum2 = SummSafety();
            WriteLine($"Сумма введенных хороших чисел = {sum2}");
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Суммирование целых хороших числовых значений с обработкой ошибок
        /// </summary>
        /// <returns>сумма чисел</returns>
        private static int SummSafety()
        {
            int sum = 0;
            while (true)
            {
                if (int.TryParse(ReadLine(), out int number))
                {
                    if (isGoodNumber(number))
                    {
                        sum += number;
                    }
                    if (number == 0)
                    {
                        break;
                    }
                    continue;
                }
                WriteLine("Ошибка! Введен неверный формат целого числа!");
                Beep(500,500);
            }
            return sum;
        }
        /// <summary>
        /// Суммирование целых хороших числовых значений
        /// </summary>
        /// <returns>сумма чисел</returns>
        private static int Summ()
        {
            int sum = 0;
            while (true)
            {
                int number = int.Parse(ReadLine());
                if (isGoodNumber(number))
                {
                    sum += number;
                }
                if (number == 0)
                {
                    break;
                }
            }
            return sum;
        }
        /// <summary>
        /// Определение что это хорошее число - нечетное и положительное
        /// </summary>
        /// <param name="num">число</param>
        /// <returns>является хорошим числом</returns>
        private static bool isGoodNumber(int num) => num % 2 != 0 && num > 0;

    }
}
