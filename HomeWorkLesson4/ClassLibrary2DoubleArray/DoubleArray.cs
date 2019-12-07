using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2DoubleArray
{
    /// <summary>
    /// Класс работы с двумерным массивом
    /// </summary>
    public class DoubleArray
    {
        private int[,] doubleArr;
        /// <summary>
        /// Конструктор с заполнением массива случайными числами
        /// </summary>
        /// <param name="sizeX">число колонок</param>
        /// <param name="sizeY">число строк</param>
        public DoubleArray(int sizeX, int sizeY)
        {
            Random rnd = new Random();
            doubleArr = new int[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    doubleArr[i, j] = rnd.Next(1, 1001);
                }
            }
        }


    }
}
