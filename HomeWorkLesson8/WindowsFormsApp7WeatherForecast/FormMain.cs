using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7WeatherForecast
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Задача 7
        /// Программа прогноза погоды
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 8. C# Уровень 1. Программирование \"по-взрослому\"\n" +
                               "Задача 7. Программа прогноза погоды.";
        }
    }
}
