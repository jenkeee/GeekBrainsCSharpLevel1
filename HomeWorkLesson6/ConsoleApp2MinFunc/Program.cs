using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2MinFunc
{
    class Program
    {
        /// <summary>
        /// Задача 2
        /// Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию
        /// в виде делегата. 
        /// а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и
        /// на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором
        /// хранятся различные функции.
        /// б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она
        /// возвращает минимум через параметр (с использованием модификатора out). 
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 2. Программа нахождения минимума функции.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания А. Меню с различными функциями.");
            while (GetSwitchFromConsole(out int swtch))
            {
                WriteLine(swtch);
            }


            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Выбор через консоль у пользователя необходимой функции
        /// </summary>
        /// <param name="swtch">вертает выбор пользователя</param>
        /// <param name="message">приглашение</param>
        /// <returns>не отмена</returns>
        private static bool GetSwitchFromConsole(out int swtch, string message = "Выберите дальнейшее действие (q-отмена)")
        {
            WriteLine(message);
            if (MyHelper.GetNumberFromConsole(out int swt, "Выберите функцию (1-квадрат, 2-куб, 3-синус, 4-квадратичная)", 1, 4))
            {
                swtch = swt;
                return true;
            }
            swtch = default;
            return false;
        }
    }
}
