using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1ArrayOfNumbers
{
    class Program
    {
        /// <summary>
        /// Задача 1.
        /// Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения
        /// от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать программу, позволяющую
        /// найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной
        /// задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти
        /// элементов: 6; 2; 9; –3; 6 ответ — 2. 
        /// Рассхатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 1. Целочисленный массив из 20 элементов. ");
            ///////////////////////////////////////////////////////////////////////////////////
            int[] arrayInts = GetArrayWithRandomNum(20); //получить целочисленый массив
            WriteLine("Массив элементов из случайных чисел:");
            Array.ForEach(arrayInts, WriteLine); //вывод всех элементов в консоль
            WriteLine();
            int count = GetCountGoodNumbers(arrayInts); //получить количества пар
            WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3 - {count}");
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Получение массива из случайных целых чисел
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        static int[] GetArrayWithRandomNum(int size)
        {
            Random rnd = new Random();
            int[] retArr = new int[size];
            for (int i = 0; i < retArr.Length; i++)
            {
                retArr[i] = rnd.Next(-10_000, 10_000);
            }
            return retArr;
        }
        /// <summary>
        /// Получение количества хороших чисел
        /// </summary>
        /// <param name="arrayInts"></param>
        /// <returns></returns>
        static int GetCountGoodNumbers(int[] arrayInts)
        {
            int count = default;
            for (int i = 0; i < arrayInts.Length - 1; i++)
            {
                if (arrayInts[i] % 3 == 0 ^ arrayInts[i + 1] % 3 == 0) //подсчет всех хороших пар чисел
                {
                    count++;
                }
            }
            return count;
        }
    }
}
