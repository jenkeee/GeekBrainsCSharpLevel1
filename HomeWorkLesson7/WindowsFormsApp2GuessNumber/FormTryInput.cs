using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2GuessNumber
{
    public partial class FormTryInput : Form
    {
        public int TryNumber { get; set; }
        public FormTryInput()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Проверка числа и возвращение результата на вызывающую форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTry_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out int number))
            {
                TryNumber = number;
                DialogResult = DialogResult.OK;
                return;
            }
            MessageBox.Show("Не удалось разобрать число в текстовом поле.");
            SystemSounds.Beep.Play();
        }
    }
}
