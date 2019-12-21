using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3GameEditor
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Задача 3.
        /// а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база
        /// данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
        /// б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические»
        /// улучшения на свое усмотрение.
        /// в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
        /// г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 8. C# Уровень 1. Программирование “по-взрослому.\n" +
                               "Задача 3. Приложение редактор вопросов игры верю - не верю.";
        }
    }
}
