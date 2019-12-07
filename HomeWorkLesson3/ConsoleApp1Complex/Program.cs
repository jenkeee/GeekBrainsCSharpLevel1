using System;
using System.CodeDom;
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
            SComplex c1 = new SComplex(10, 10);
            SComplex c2 = new SComplex(1, 1);
            WriteLine($"Два комплексных числа: {c1} и {c2}");
            WriteLine($"Сумма чисел = {c1 + c2}");
            WriteLine($"Разность чисел = {c1 - c2}");
            WriteLine($"Произведение чисел = {c1 * c2}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания Б. Дописать класс Complex, добавив методы вычитания и произведения чисел.");
            Complex com1 = new Complex(10, 10);
            Complex com2 = new Complex(1, 1);
            WriteLine($"Два комплексных числа: {com1} и {com2}");
            WriteLine($"Сумма чисел = {com1 + com2}");
            WriteLine($"Разность чисел = {com1 - com2}");
            WriteLine($"Произведение чисел = {com1 * com2}");
            WriteLine($"Частное чисел = {com1 / com2}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания В. Добавить диалог с использованием switch, демонстрирующий работу класса.");
            while (true) //бесконечный цикл
            {
                if (!GetComplexFromConsole(out Complex oneCom1, 1)) //получение первого числа с консоли
                    break;
                if (!GetComplexFromConsole(out Complex oneCom2, 2)) //получение второго числа с консоли
                    break;
                if (!GetSelectActionFromConsole(out int action)) //выбор действия с числами из консоли
                    break;
                Complex rez = DoOperationForNumberSwitch(oneCom1, action, oneCom2); //действие с комплексными числами
                WriteLine($"Результат операции = {rez}");
                WriteLine();
            }
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Получение комплексного числа с консоли
        /// </summary>
        /// <param name="com">число</param>
        /// <param name="num">номер числа - 1 или 2</param>
        /// <returns>успешно введено, не отмена</returns>
        private static bool GetComplexFromConsole(out Complex com, int num)
        {
            WriteLine($"Введите комплексное число номер {num}:");
            bool noCalcel = MyHelper.GetNumberFromConsole(out double re, "Вещественная часть (double) (q-отмена)");
            if (noCalcel)
            {
                noCalcel = MyHelper.GetNumberFromConsole(out double im, "Мнимая часть (double) (q-отмена)");
                com = new Complex(re, im);
                return noCalcel;
            }
            com = default;
            return false;
        }
        /// <summary>
        /// Получение выбора действия с введенными комплексными числами с консоли
        /// </summary>
        /// <param name="action">действие</param>
        /// <returns>выбор</returns>
        private static bool GetSelectActionFromConsole(out int action)
        {
            while (true)
            {
                WriteLine("Выберите действие с комплексными числами:");
                Write("1-сумма, 2-разность, 3-произведение, 4-частное, q-отмена (int):> ");
                string buffString = ReadLine();
                if (Int32.TryParse(buffString, out int num)) //введено должно быть число
                {
                    action = num;
                    return true;
                }
                else if (buffString == "q") //введена пользовательская команда отмена ввода
                {
                    action = default;
                    return false;
                }
                else //введено не число
                {
                    WriteLine("Ошибка! Введен неверный формат целого числа!");
                }
                Beep(500, 500);
            }
        }
        /// <summary>
        /// Операция с двумя комплексными числами исходя из выбранной операции
        /// </summary>
        /// <param name="one">первое</param>
        /// <param name="action">операция</param>
        /// <param name="two">второе</param>
        /// <returns>результат</returns>
        private static Complex DoOperationForNumberSwitch(Complex one, int action, Complex two)
        {
            return action switch
            {
                1 => one + two,
                2 => one - two,
                3 => one * two,
                4 => one / two,
                _ => throw new Exception("Недопустимый выбор операции с числами"),
            };
        }
    }
}
