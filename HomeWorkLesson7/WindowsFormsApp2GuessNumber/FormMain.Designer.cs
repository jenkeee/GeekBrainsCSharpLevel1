namespace WindowsFormsApp2GuessNumber
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonQuestComputer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonTryWindow = new System.Windows.Forms.Button();
            this.labelDialog = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.LightGreen;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(611, 55);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Задача 2. Игра \"Угадай число\".";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonQuestComputer
            // 
            this.buttonQuestComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQuestComputer.Location = new System.Drawing.Point(4, 58);
            this.buttonQuestComputer.Name = "buttonQuestComputer";
            this.buttonQuestComputer.Size = new System.Drawing.Size(209, 82);
            this.buttonQuestComputer.TabIndex = 2;
            this.buttonQuestComputer.Text = "Компьютер, загадай число от 1 до 100";
            this.buttonQuestComputer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNumber);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(4, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Угадывание числа";
            // 
            // buttonTry
            // 
            this.buttonTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTry.Location = new System.Drawing.Point(6, 64);
            this.buttonTry.Name = "buttonTry";
            this.buttonTry.Size = new System.Drawing.Size(197, 88);
            this.buttonTry.TabIndex = 2;
            this.buttonTry.Text = "Попытка отгадать число";
            this.buttonTry.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите число от 1 до 100:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber.Location = new System.Drawing.Point(6, 32);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(197, 26);
            this.textBoxNumber.TabIndex = 0;
            // 
            // buttonTryWindow
            // 
            this.buttonTryWindow.Enabled = false;
            this.buttonTryWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTryWindow.Location = new System.Drawing.Point(4, 310);
            this.buttonTryWindow.Name = "buttonTryWindow";
            this.buttonTryWindow.Size = new System.Drawing.Size(209, 88);
            this.buttonTryWindow.TabIndex = 3;
            this.buttonTryWindow.Text = "Попытка отгадать в отдельном окне";
            this.buttonTryWindow.UseVisualStyleBackColor = true;
            // 
            // labelDialog
            // 
            this.labelDialog.BackColor = System.Drawing.Color.Aquamarine;
            this.labelDialog.Location = new System.Drawing.Point(221, 63);
            this.labelDialog.Name = "labelDialog";
            this.labelDialog.Size = new System.Drawing.Size(378, 54);
            this.labelDialog.TabIndex = 4;
            this.labelDialog.Text = "Число еще не загадано";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2GuessNumber.Properties.Resources.Гусь;
            this.pictureBox1.Location = new System.Drawing.Point(219, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 318);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDialog);
            this.Controls.Add(this.buttonTryWindow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonQuestComputer);
            this.Controls.Add(this.labelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geekbrains. C# Уровень 1.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonQuestComputer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonTryWindow;
        private System.Windows.Forms.Label labelDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

