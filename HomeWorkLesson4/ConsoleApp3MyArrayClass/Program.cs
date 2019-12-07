using System.Collections.Generic;
using static System.Console;
using ClassLibrary1MyArrayClass;

namespace ConsoleApp3MyArrayClass
{
    class Program
    {
        /// <summary>
        /// Задача 3
        /// а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив
        /// определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        /// Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий
        /// новый массив с измененными знаками у всех элементов массива (старый массив, остается без
        /// изменений), метод Multi, умножающий каждый элемент массива на определённое число, свойство
        /// MaxCount, возвращающее количество максимальных элементов. 
        /// б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
        /// е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 3. Класс для работы с одномерным массивом.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт А. Добавленные члены в класс для работы с одномерным массивом.");
            MyHelper.GetNumberFromConsole(out int size, "Размер массива (int)", cancelEnable: false);
            MyHelper.GetNumberFromConsole(out int step, "Шаг заполнения массива (int)", cancelEnable: false);
            CoolArray coolArray = new CoolArray(size, step);
            WriteLine("Сгенерированный массив:");
            for (int i = 0; i < coolArray.Length; i++)
            {
                Write($"{coolArray[i]} ");
            }
            WriteLine();
            int sum = coolArray.Sum;
            WriteLine($"Сумма элементов массива = {sum}");
            int[] arrInverse = coolArray.Inverse();
            WriteLine("Измененный массив с измененными знаками у всех элементов:");
            for (int i = 0; i < arrInverse.Length; i++)
            {
                Write($"{arrInverse[i]} ");
            }
            WriteLine();
            CoolArray.Multi(arrInverse, 2);
            WriteLine("Этот же массив со значениями, перемноженными на число 2:");
            for (int i = 0; i < arrInverse.Length; i++)
            {
                Write($"{arrInverse[i]} ");
            }
            WriteLine();
            int maxCount = coolArray.MaxCount;
            WriteLine($"Количество максимальных элементов: {maxCount}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт Б. Библиотека с классом для работы с массивом.");
            CoolLibArray coolLibArray = new CoolLibArray(30);
            WriteLine("Сгенерированный массив с помощью библиотеки:");
            for (int i = 0; i < coolLibArray.Length; i++)
            {
                Write($"{coolLibArray[i]} ");
            }
            WriteLine();
            WriteLine($"Сумма элементов массива = {coolLibArray.Sum}");
            WriteLine($"Количество максимальных элементов: {coolLibArray.MaxCount}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт В. Подсчитать частоту вхождения каждого элемента в массив.");
            CoolArray coolDictArray = new CoolArray(30);
            WriteLine("Сгенерированный массив с помощью библиотеки:");
            for (int i = 0; i < coolDictArray.Length; i++)
            {
                Write($"{coolLibArray[i]} ");
            }
            WriteLine();
            WriteLine("Частота вхождения каждого элемента в этом массиве:");
            Dictionary<int, int> dict = getDictionary(coolDictArray);
            foreach (var item in dict)
            {
                Write($"{item.Key}-{item.Value} ");
            }
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Получение словаря с чатотой вхождения каждого элемента
        /// </summary>
        /// <param name="array">массив</param>
        /// <returns>словарь</returns>
        static Dictionary<int, int> getDictionary(CoolArray array)
        {
            Dictionary<int, int> returnMe = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (returnMe.ContainsKey(array[i]))
                {
                    returnMe[array[i]]++;
                }
                else
                {
                    returnMe.Add(array[i], 1);
                }
            }
            return returnMe;
        }
    }
}
