using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp4LoginPassword
{
    class Program
    {
        /// <summary>
        /// Задача 4
        /// Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
        /// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root,
        /// Password: GeekBrains). Используя метод проверки логина и пароля, написать программу:
        /// пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        /// С помощью цикла do while ограничить ввод пароля тремя попытками.
        /// Рассахатский
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MyHelper.MyHeader(text:"Задача 4. Реализовать метод проверки логина и пароля.");
            ///////////////////////////////////////////////////////////////////////////////////


            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }
}
