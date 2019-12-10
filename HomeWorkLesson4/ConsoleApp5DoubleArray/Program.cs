using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2DoubleArray;
using static System.Console;

namespace ConsoleApp5DoubleArray
{
    class Program
    {
        /// <summary>
        /// Задача 5
        /// *а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий
        /// массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех
        /// элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее
        /// максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры,
        /// используя модификатор ref или out).
        /// **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
        /// **в) Обработать возможные исключительные ситуации при работе с файлами.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 5. Библиотека с классом для работы с двумерным массивом. ");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт А. Реализовать библиотеку с классами для работы с массивом.");
            if (MyHelper.GetNumberFromConsole(out int colCount, "Введите число колонок у массива (int) (q-отмена)"))
            {
                if (MyHelper.GetNumberFromConsole(out int rowCount, "Введите число строк у массива (int) (q-отмена)"))
                {
                    DoubleArray doubleArray = new DoubleArray(colCount, rowCount);
                    WriteLine("Массив заполненный случайными числами:");
                    WriteLine(doubleArray);
                    WriteLine($"Сумма всех элементов массива = {doubleArray.Sum()}");
                    WriteLine("Сумма всех элементов массива больше заданного:");
                    if (MyHelper.GetNumberFromConsole(out int minValue, "Введите заданное число (int) (q-отмена)"))
                    {
                        WriteLine($"Сумма всех элементов массива больше заданного = {doubleArray.Sum(minValue)}");
                        WriteLine($"Минимальный элемент массива равен {doubleArray.Min}");
                        int max = doubleArray.Max;
                        WriteLine($"Максимальный элемент массива равен {max}");
                        var (_, numCol, numRow) = doubleArray.GetIndexForValue(max);
                        WriteLine($"Он находится в колонке {numCol + 1} и строке {numRow + 1}");
                        MyHelper.MyPause();
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт Б. Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.");
            DoubleArray loadDoubleArray = new DoubleArray(@"..\..\DoubleArrayFile.txt");
            WriteLine("\nСконструированный массив по файлу:");
            WriteLine(loadDoubleArray);
            WriteLine("-> Новый массив");
            DoubleArray newDoubleArray = new DoubleArray(10, 5);
            WriteLine("-> Запись нового массива в файл");
            newDoubleArray.SaveToFile(@"..\..\NewDoubleArrayFile.txt");
            WriteLine("-> Чтение нового массива из файла");
            newDoubleArray.LoadFromFile(@"..\..\NewDoubleArrayFile.txt");
            WriteLine("\nНовый массив прочитанный из файла:");
            WriteLine(newDoubleArray);
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт В. Обработать возможные исключительные ситуации при работе с файлами.");
            MyHelper.MyPause("\nЧтение несуществующего файла ->");
            try
            {
                DoubleArray nonDoubleArray = new DoubleArray("НетТакогоФайла.txt");
            }
            catch (Exception e)
            {
                WriteLine("Исключение: " + e.Message);
            }
            MyHelper.MyPause("\nПопытка записи в уже открытый файл ->");
            DoubleArray hackDoubleArray = new DoubleArray(3,3);
            try
            {
                hackDoubleArray.SaveToFile("ConsoleApp5DoubleArray.exe");
            }
            catch (Exception e)
            {
                WriteLine("Исключение: " + e.Message);
            }
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }
}
