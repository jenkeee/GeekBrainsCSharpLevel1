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
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            doubler = new Doubler();
        }
		//перерисовка
        private void Repaint()
        {
            var (number, command, winner) = doubler.GetAllForForm();
            labelPlayerNumber.Text = number;
            labelCommandCount.Text = command;
            labelWinner.Text = winner;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            bool win = doubler.Plus();
            Repaint();
            if (win) MessageBox.Show("Вы победили в этой игре!", "Поздравления", MessageBoxButtons.OK);
        }

        private void buttonMulTwo_Click(object sender, EventArgs e)
        {
            bool win = doubler.MultiplyTwo();
            Repaint();
            if (win) MessageBox.Show("Вы победили в этой игре!", "Поздравления", MessageBoxButtons.OK);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            Repaint();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            doubler.Undo();
            Repaint();
        }

        private void начатьНовуюИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler.RestartGame();
            Repaint();
        }
    }
}
