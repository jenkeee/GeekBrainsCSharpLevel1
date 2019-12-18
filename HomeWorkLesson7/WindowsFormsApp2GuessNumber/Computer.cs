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
        public enum Status : byte
        {
            None,
            Victory,
            TryAgainUp,
            TryAgainDown,
            GameOver
        }

        private int computerNumber;
        private int countTry;


        public void QuestComputer()
        {
            Random rnd = new Random();
            computerNumber = rnd.Next(1, 100);
            countTry = 7;
        }

        public Status TryNumber(int number)
        {
            if (computerNumber == 0)
                return Status.None;
            if (number == computerNumber)
            {
                computerNumber = 0;
                return Status.Victory;
            }
            countTry--;
            if (countTry <= 0)
            {
                computerNumber = 0;
                return Status.GameOver;
            }
            if (number < computerNumber)
                return Status.TryAgainUp;
            return Status.TryAgainDown;
        }

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
