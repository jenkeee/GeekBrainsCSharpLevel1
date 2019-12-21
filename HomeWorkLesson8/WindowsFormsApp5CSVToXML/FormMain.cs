using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5CSVToXML
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Задача 5.
        /// **Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 8. C# Уровень 1. Программирование “по-взрослому.\n" +
                               "Задача 5. Программа-преобразователь из CSV в XML-файл.";
        }
    }
}
