using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2GuessNumber
{
    /// <summary>
    /// Компьютер
    /// </summary>
    class Computer
    {
        private const int COUNT_TRY = 7;
        /// <summary>
        /// статус игры
        /// </summary>
        public enum Status : byte
        {
            None, //никакой
            Victory, //победа
            TryAgainUp, //компьютер загадал число больше
            TryAgainDown, //компьютер загадал число меньше
            GameOver //конец игры
        }
        //число загаданное компьтером
        private int computerNumber;
        //число попыток отгадать число
        private int countTry;
        /// <summary>
        /// Загадай число комьютер
        /// </summary>
        public void QuestComputer()
        {
            Random rnd = new Random();
            computerNumber = rnd.Next(1, 100);
            countTry = COUNT_TRY; //число попыток
        }
        /// <summary>
        /// Проба отгадать число
        /// </summary>
        /// <param name="number">число</param>
        /// <returns>результат</returns>
        public Status TryNumber(int number)
        {
            if (computerNumber == 0)
                return Status.None;
            if (number == computerNumber) //игрок отгадал число
            {
                computerNumber = 0;
                return Status.Victory;
            }
            countTry--;
            if (countTry <= 0) //кончились попытки
            {
                computerNumber = 0;
                return Status.GameOver;
            }
            if (number < computerNumber) //компьютер загадал число больше
                return Status.TryAgainUp;
            return Status.TryAgainDown;
        }
        /// <summary>
        /// Сообщения для отображения на форме
        /// </summary>
        /// <returns></returns>
        public (string dialog, string count, bool enabled) GetStringsMessages()
        {
            string dialog = String.Empty;
            if (computerNumber == 0)
            {
                dialog = "Компьютер число еще не загадал";
                return (dialog, String.Empty, false);
            }
            dialog = "Компьютер загадал число, попробуйте его отгадать!";
            string count = $"Осталось {countTry} попыток";
            return (dialog, count, true);
        }
        /// <summary>
        /// Сообщение ползоваетелю в соответтствии со статусом
        /// </summary>
        /// <param name="status">статус</param>
        /// <returns>сообщение</returns>
        public static string GetMessageFromStatus(Computer.Status status)
        {
            string message = status switch
            {
                Computer.Status.Victory => "Вы угадали число загаданное компьютером. Поздравления!",
                Computer.Status.TryAgainUp => "Загаданное число больше чем вы ввели.",
                Computer.Status.TryAgainDown => "Загаданное число меньше чем вы ввели.",
                Computer.Status.GameOver => "Вы проиграли. Кончились попытки",
                _ => String.Empty,
            };
            return message;
        }
    }
}
