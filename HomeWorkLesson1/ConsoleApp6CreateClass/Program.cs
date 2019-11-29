using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp6CreateClass
{
    class Program
    {
        /// <summary>
        /// Задача 6.
        /// *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, MyPause).
        /// Рассахатский
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MyToolsClass.MyHeader(text: "Задача 6. Создать класс с методами, которые могут пригодиться в вашей учебе.");
            ///////////////////////////////////////////////////////////////
            MyToolsClass.MyPrint("Демонстрация работы класса", 24, 10);
            MyToolsClass.MyPrint("Для продолжения нажмите любую кнопку...", 24, 12);
            MyToolsClass.MyPause();
            ///////////////////////////////////////////////////////////////
            MyToolsClass.MyFooter();
        }
    }
}
