using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1Doubler
{
    public partial class FormMain : Form
    {
        private Doubler doubler;
        /// <summary>
        /// Задача 1.
        /// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
        /// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число
        /// должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
        /// в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте
        /// обобщенный класс Stack.
        /// Вся логика игры должна быть реализована в классе с удвоителем.
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 7. C# Уровень 1. Введение в Windows Forms.\nЗадача 1. Программа удвоитель.";
            doubler = new Doubler();
        }
		/// <summary>
        /// Перерисовка данных в окне
        /// </summary>
        private void Repaint()
        {
            var (number, command, winner) = doubler.GetAllForForm();
            labelPlayerNumber.Text = number;
            labelCommandCount.Text = command;
            labelWinner.Text = winner;
        }
        /// <summary>
        /// Увеличение на 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            bool win = doubler.Plus();
            Repaint();
            if (win) MessageBox.Show("Вы победили в этой игре!", "Поздравления", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Умножение на 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMulTwo_Click(object sender, EventArgs e)
        {
            bool win = doubler.MultiplyTwo();
            Repaint();
            if (win) MessageBox.Show("Вы победили в этой игре!", "Поздравления", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Сброс действий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            Repaint();
        }
        /// <summary>
        /// Отмена последнего действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            doubler.Undo();
            Repaint();
        }
        /// <summary>
        /// Начало новой игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void начатьНовуюИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler.RestartGame();
            Repaint();
        }
    }
}
