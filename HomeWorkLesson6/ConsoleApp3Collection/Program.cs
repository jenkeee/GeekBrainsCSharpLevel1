using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3Collection
{
    class Program
    {
        /// <summary>
        /// Задача 3
        /// Переделать программу Пример использования коллекций для решения следующих задач:
        /// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        /// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
        /// в) отсортировать список по возрасту студента;
        /// г) *отсортировать список по курсу и возрасту студента;
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 3. Использование коллекций.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания А. Подсчитать количество студентов учащихся на 5 и 6 курсах.");
            Students students = default;
            try
            {
                students = new Students(@"..\..\students.csv");
            }
            catch (Exception e)
            {
                WriteLine("Не удалось открыть файл исходных данных! Работа программы невозможна!\n" + e.Message);
                ReadKey();
                return;
            }
            WriteLine($"Всего студентов: {students.Count}");
            var (bak, mag) = students.DetailCount;
            WriteLine($"Магистров: {mag}");
            WriteLine($"Бакалавров: {bak}");
            var (five, six) = students.FiveSixCount;
            WriteLine($"Из них студентов пятых {five} и шестых {six} курсов");
            WriteLine("Список студентов:");
            for (int i = 0; i < students.Count; i++)
            {
                WriteLine(students[i]);
            }
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания Б. Подсчитать количество студентов в возрасте от 18 до 20 лет на каком курсе учатся.");
            WriteLine("Количество студентов по курсам в возрасте от 18 до 20 лет:");
            Dictionary<int, int> dict = students.GetCourseForAges(18, 20);
            foreach (var el in dict)
            {
                WriteLine($"{el.Key} курс = {el.Value} студентов");
            }
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания В. Откортировать студентов по возрасту студентов.");
            WriteLine("Отсортированный список студентов:");
            students.SortAge();
            for (int i = 0; i < students.Count; i++)
            {
                WriteLine(students[i]);
            }
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт задания Г. *отсортировать список по курсу и возрасту студента.");
            WriteLine("Отсортированный по 2-м параметрам список студентов:");
            students.SortDual();
            for (int i = 0; i < students.Count; i++)
            {
                WriteLine(students[i]);
            }
            //Students.GenNSaveStudentsToFile(@"..\..\students.csv");
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }
}
