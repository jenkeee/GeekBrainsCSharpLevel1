using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp4ReadFile
{
    class Program
    {
        /// <summary>
        /// Задача 4.
        /// **Считайте файл различными способами. Смотрите “Пример записи файла различными способами”.
        /// Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для
        /// StreamReader и массив int для BinaryReader.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 4. Чтение файла различными способами.");
            ///////////////////////////////////////////////////////////////////////////////////
            long size = 1024;
            ReadWrite.WriteFileStream(@"..\..\TextFile1.txt", size);
            ReadWrite.WriteBinary(@"..\..\TextFile2.txt", size);            
            ReadWrite.WriteStreamWriter(@"..\..\TextFile3.txt", size);
            ReadWrite.WriteBufferedStream(@"..\..\TextFile4.txt", size);
            MyHelper.MyPause("Данные в файлы записаны. Для продолжения нажмите кнопку ...");
            

            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }
}
