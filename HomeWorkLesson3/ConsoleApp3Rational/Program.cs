using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3Rational
{
    class Program
    {
        /// <summary>
        /// Задача 3.
        /// *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть
        /// методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все
        /// разработанные элементы класса.
        /// * Добавить свойства типа int для доступа к числителю и знаменателю;
        /// * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
        /// ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException
        /// ("Знаменатель не может быть равен 0");
        /// *** Добавить упрощение дробей.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 2. С клавиатуры вводятся числа плюс обработка исключительных ситуаций.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Первая звездочка. Класс рациональных чисел.");
            Rational one = new Rational(1,2);
            Rational two = new Rational(1,3);
            WriteLine($"Первое число = {one} и второе число = {two}");
            WriteLine($"Результат суммирования чисел = {one + two}");
            WriteLine($"Результат разности чисел = {one - two}");
            WriteLine($"Результат произведения чисел = {one * two}");
            WriteLine($"Результат частности чисел = {one / two}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Вторая звездочка. Дополнительный доступ к числителю и знаменателю через свойства.");
            Rational one1 = new Rational(1,3);
            WriteLine($"Число = {one1}");
            WriteLine($"Его числитель = {one1.Num} и его знаменатель = {one1.Denom}");
            one1.Num = 6;
            one1.Denom = 7;
            WriteLine($"Измененное число = {one1}");
            WriteLine($"Теперь числитель = {one1.Num} и знаменатель = {one1.Denom}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Третья звездочка. Свойство только для чтения, чтобы получить десятичную дробь числа.");
            Rational one2 = new Rational(1,6);
            WriteLine($"Число = {one2}");
            WriteLine($"Десятичная дробь этого числа = {one2.GetDecValue}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Две звездочки. Свойство только для чтения, чтобы получить десятичную дробь числа.");
            Rational one3 = new Rational(1,6);
            WriteLine("Присвоение знаменателю числа 0");
            ReadKey();
            try
            {
                one3.Denom = 0;
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Три звездочки. Упрощение дробей.");
            Rational one4 = new Rational(21,42);
            WriteLine($"Число до упрощения дробей: {one4}");
            one4.DoPrunningRational();
            WriteLine($"Это же число после упрощения дробей: {one4}");
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }
}
