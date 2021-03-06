using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1Doubler
{
    /// <summary>
    /// Игра удвоитель
    /// </summary>
    public class Doubler
    {
        private int playerNumber; //текущее число
        private int countCommand; //количество действий
        private bool itIsGame; //сейчас идет режим игры
        private int winnerNumber; //число для победы в режиме игры
        private Stack<int> stackPlayerNumber; //записи последних чисел игрока в режиме игры

        public Doubler()
        {
            stackPlayerNumber = new Stack<int>();
        }
        /// <summary>
        /// Начало новой игры
        /// </summary>
        public void RestartGame()
        {
            Random rnd = new Random();
            itIsGame = true;
            winnerNumber = rnd.Next(1, 10);
            ClearThisData();
        }
        /// <summary>
        /// Прибавка 1
        /// </summary>
        /// <returns>выигрыш в игре</returns>
        public bool Plus()
        {
            stackPlayerNumber.Push(playerNumber);
            playerNumber++;
            countCommand++;
            if (itIsGame && playerNumber == winnerNumber)
            {
                itIsGame = false;
                ClearThisData();
                return true;
            }
            return false;
        }
        /// <summary>
        /// Умножить на 2
        /// </summary>
        /// <returns>выигрыш в игре</returns>
        public bool MultiplyTwo()
        {
            stackPlayerNumber.Push(playerNumber);
            playerNumber *= 2;
            countCommand++;
            if (itIsGame && playerNumber == winnerNumber)
            {
                itIsGame = false;
                ClearThisData();
                return true;
            }
            return false;
        }
        /// <summary>
        /// Сброс всех действий
        /// </summary>
        public void Reset()
        {
            stackPlayerNumber.Push(playerNumber);
            playerNumber = 0;
            countCommand = 0;
            stackPlayerNumber.Clear();
        }
        /// <summary>
        /// Отмена последнего действия
        /// </summary>
        public void Undo()
        {
            if (countCommand == 0) 
                return;
            playerNumber = stackPlayerNumber.Pop();
            countCommand--;
        }
        /// <summary>
        /// Получение всех данных на окно
        /// </summary>
        /// <returns></returns>
        public (string number, string command, string winner) GetAllForForm()
        {
            string number = playerNumber.ToString();
            string command = countCommand.ToString();
            string winner = (itIsGame) ? $"Режим игры. Для победы в игре получить число {winnerNumber}" : string.Empty;
            return (number, command, winner);
        }
        //очистка данных в классе
        private void ClearThisData()
        {
            playerNumber = 0;
            countCommand = 0;
            stackPlayerNumber.Clear();
        }
    }
}
