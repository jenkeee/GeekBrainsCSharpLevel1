using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2GuessNumber
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Задача 2.
        /// Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100,
        /// а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше
        /// загаданное число введенного.  
        /// a) Для ввода данных от человека используется элемент TextBox;
        /// б) **Реализовать отдельную форму c TextBox для ввода числа.
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 7. C# Уровень 1. Введение в Windows Forms.\nЗадача 2. Игра \"Угадай число\".";

        }
    }
}
