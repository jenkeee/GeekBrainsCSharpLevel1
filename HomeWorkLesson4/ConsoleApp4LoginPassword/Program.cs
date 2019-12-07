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
        /// Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
        /// Создайте структуру Account, содержащую Login и Password.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 4. Логины и пароли из файла. ");
            ///////////////////////////////////////////////////////////////////////////////////
            Accounts accounts = new Accounts( @"..\..\TextFileLoginPassword.txt"); //получение логин паролей из файла
            var (authYes, login) = AuthLoginFromConsole(accounts);
            if (authYes) //вход по логину и паролю ползователя
            {
                WriteLine($"Здравствуйте, {login}! Вы успешно вошли в всистему! Логин пароль правильные.");
                Beep(3000,100);
            }
            else
            {
                WriteLine("Прощайте! Вам не удалось войти в систему. Кончились попытки ввода логина и пароля.");
                Beep(300,2000);
            }
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }

        /// <summary>
        /// Вход с консоли с проверкой логина пароля
        /// </summary>
        /// <param name="accounts">аккаунты имеющиеся</param>
        /// <returns>признак входа и логин</returns>
        private static (bool, string) AuthLoginFromConsole(Accounts accounts)
        {
            int countTry = 3;
            string login = default;
            while (countTry > 0)
            {
                Write("Введите свой логин:> ");
                login = ReadLine();
                if (accounts.IsValidLogin(login))
                {
                    break;
                }
                WriteLine($"Такой логин отсутствует в списке. У вас осталось {countTry} попыток.");
                Beep(500,500);
                countTry--;
            }
            while (countTry > 0)
            {
                Write("Введите пароль:> ");
                string password = ReadLine();
                if (accounts.IsValidLoginPassword(login, password))
                {
                    return (true, login);
                }
                WriteLine($"Неправильный пароль! У вас осталось {countTry} попыток.");
                Beep(500,500);
                countTry--;
            }
            return (false, default);
        }

    }
}
