using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp5BodyWeightIndex
{
    class Program
    {
        /// <summary>
        /// Задача 5.
        /// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и
        /// сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        /// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 5. Программа индекс массы тела с рекомендациями по приведению ИМТ к норме.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт А. Вычисление индекса массы тела и собщение, что нужно сделать чтоб была норма");
            var (noCancel, weight, growth) = InputNumbersFromUser();
            if (noCancel)
            {
                double bodyWeightIndex = CalcBodyWeightIndex(weight, growth); //вычисление индекса массы тела
                WriteLine($"Вычисленный индекс массы тела равен {bodyWeightIndex:F1}");
                WriteLine("Рекомендации по нормализации массы тела:");
                WriteLine(GetRecomendationOfIndex(bodyWeightIndex)); //получение рекомендации на основе индекса
                WriteLine("Для продолжения нажмите любую кнопку ...");
                ReadKey();
            }
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("\nПункт Б. Расчет, на сколько килограмм пополнеть или похудеть чтоб привести туловище в норму");
            (noCancel, weight, growth) = InputNumbersFromUser();
            if (noCancel)
            {
                double bodyWeightIndex = CalcBodyWeightIndex(weight, growth); //вычисление индекса массы тела
                WriteLine($"Вычисленный индекс массы тела равен {bodyWeightIndex:F1}");
                WriteLine("Рекомандации насчет корректировки массы тела:");
                WriteLine(GetCountRecomendationOfIndex(bodyWeightIndex,growth, weight));
            }
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Расчет индекса массы тела
        /// </summary>
        /// <param name="weight">вес</param>
        /// <param name="growth">рост</param>
        /// <returns>индекс массы тела</returns>
        private static double CalcBodyWeightIndex(double weight, double growth)
        {
            return weight / (growth * growth / 10000);
        }
        /// <summary>
        /// Ввод входных значений с консоли
        /// </summary>
        /// <returns>Введенные пользователем значения и признак что числа введены</returns>
        private static (bool, int, double) InputNumbersFromUser()
        {
            bool noCancel = MyHelper.GetNumberFromConsole(out int weight, "Пожалуйств введите массу тела в килограммах (int) q-отмена", 10, 300);
            if (noCancel)
            {
                noCancel = MyHelper.GetNumberFromConsole(out double growth, "Пожалуйста введите рост человека в сантиметрах (double) q-отмена", 50.0, 200.0);
                return (noCancel, weight, growth);
            }
            return (noCancel, default, default);
        }
        /// <summary>
        /// Получение рекомендации по корректировке веса тела
        /// </summary>
        /// <param name="BWI">индекс массы тела</param>
        /// <returns>Рекомендация</returns>
        private static string GetRecomendationOfIndex(double BWI)
        {
            return BWI switch
            {
                double d when d < 16.0 => "Выраженный дефицит массы тела. Немедленно набрать очень много веса!",
                double d when d < 18.9 => "Недостаточная (дефицит) масса тела. Очень срочно набрать вес!",
                double d when d < 24.99 => "Норма. Срочно набрать вес!",
                double d when d < 30.0 => "Избыточная масса тела (предожирение). Немного набрать вес.",
                double d when d < 35.0 => "Ожирение (на самом деле это нормальный вес!). Все в порядке!",
                double d when d < 40.0 => "Ожирение резкое. Немножечко сбросить вес!",
                _ => "Очень резкое ожирение. Срочно сбросить вес!",
            };
        }
        /// <summary>
        /// Получение рекомендации по корректировке веса тела в числах
        /// </summary>
        /// <param name="BWI"></param>
        /// <param name="growth"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        private static string GetCountRecomendationOfIndex(double BWI, double growth, double weight)
        {
            double standardWeightMin = 30 * (growth * growth / 10000); //стандартный вес по росту минимум
            double standardWeightMax = 35 * (growth * growth / 10000); //стандартный вес по росту максимум
            return BWI switch
            {
                double d when d < 30 => $"Человеку для того чтобы имено нормальный ИМТ (Легкое ожирение) нужно поправится на {standardWeightMin - weight} килограмм.",
                double d when d > 35 => $"Человеку для того чтобы имено нормальный ИМТ (Легкое ожирение) нужно похудеть на {weight - standardWeightMax} килограмм.",
                _ => "Нормальный вес, корректировка не требуется.",
            };
        }
    }
}
