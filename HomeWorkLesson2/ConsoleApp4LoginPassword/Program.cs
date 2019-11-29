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
        static void Main()
        {
            MyHelper.MyHeader(text:"Задача 4. Реализовать метод проверки логина и пароля.");
            ///////////////////////////////////////////////////////////////////////////////////
            bool successValidation = SuccessValidation(); //авторизация пользователя
            if (successValidation)
            {
                WriteLine("Вы успешно прошли авторизацию!");
            }
            else
            {
                WriteLine("Вы не прошли авторизацию, у вас закончились попытки!");
            }
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <returns>Успешность авторизации</returns>
        private static bool SuccessValidation()
        {
            int tryCount = 3; //пользователю дается три попытки
            do
            {
                Write("Введите логин:>");
                string login = ReadLine();
                Write("Введите пароль:>");
                string password = ReadLine();
                if (ValidationUser(login, password)) //проверка логин - root пароль - GeegBrains
                {
                    break;
                }
                tryCount--; //уменьшение количества попыток, при ноле - прерывание цикла
                WriteLine($"Логин/пароль неправильные, вы не прошли авторизацию, осталось попыток: {tryCount}");
                Beep(500, 500);
            } while (tryCount > 0);
            bool successValidation = tryCount > 0; //признак успешного прохождения авторизации
            return successValidation;
        }
        /// <summary>
        /// Проверка логина пароля на соответствие трубуемому
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="needLogin">требуемый логин</param>
        /// <param name="needPassword">требуемый пароль</param>
        /// <returns></returns>
        static bool ValidationUser(string login, string password, string needLogin = "root", string needPassword = "GeekBrains")
        {
            return (login == needLogin && password == needPassword);
        }
    }
}
