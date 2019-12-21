namespace WindowsFormsApp1Doubler
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlayerNumber = new System.Windows.Forms.Label();
            this.labelCommandCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMulTwo = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.labelWinner = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.начатьНовуюИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.LightGreen;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(0, 24);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(480, 55);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Текущее число:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество команд:";
            // 
            // labelPlayerNumber
            // 
            this.labelPlayerNumber.BackColor = System.Drawing.Color.Lime;
            this.labelPlayerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerNumber.Location = new System.Drawing.Point(29, 120);
            this.labelPlayerNumber.Name = "labelPlayerNumber";
            this.labelPlayerNumber.Size = new System.Drawing.Size(150, 33);
            this.labelPlayerNumber.TabIndex = 3;
            this.labelPlayerNumber.Text = "0";
            this.labelPlayerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCommandCount
            // 
            this.labelCommandCount.BackColor = System.Drawing.Color.Cyan;
            this.labelCommandCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCommandCount.Location = new System.Drawing.Point(29, 189);
            this.labelCommandCount.Name = "labelCommandCount";
            this.labelCommandCount.Size = new System.Drawing.Size(150, 33);
            this.labelCommandCount.TabIndex = 4;
            this.labelCommandCount.Text = "0";
            this.labelCommandCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1Doubler.Properties.Resources.КУр2;
            this.pictureBox1.Location = new System.Drawing.Point(27, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 162);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(281, 95);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(157, 70);
            this.buttonPlus.TabIndex = 6;
            this.buttonPlus.Text = "+1";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMulTwo
            // 
            this.buttonMulTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMulTwo.Location = new System.Drawing.Point(281, 178);
            this.buttonMulTwo.Name = "buttonMulTwo";
            this.buttonMulTwo.Size = new System.Drawing.Size(157, 70);
            this.buttonMulTwo.TabIndex = 7;
            this.buttonMulTwo.Text = "x2";
            this.buttonMulTwo.UseVisualStyleBackColor = true;
            this.buttonMulTwo.Click += new System.EventHandler(this.buttonMulTwo_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(281, 261);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(157, 70);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUndo.Location = new System.Drawing.Point(281, 344);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(157, 70);
            this.buttonUndo.TabIndex = 9;
            this.buttonUndo.Text = "Отмена";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // labelWinner
            // 
            this.labelWinner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWinner.Location = new System.Drawing.Point(0, 443);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(480, 26);
            this.labelWinner.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьНовуюИгруToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // начатьНовуюИгруToolStripMenuItem
            // 
            this.начатьНовуюИгруToolStripMenuItem.Name = "начатьНовуюИгруToolStripMenuItem";
            this.начатьНовуюИгруToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.начатьНовуюИгруToolStripMenuItem.Text = "Начать новую игру";
            this.начатьНовуюИгруToolStripMenuItem.Click += new System.EventHandler(this.начатьНовуюИгруToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 469);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonMulTwo);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCommandCount);
            this.Controls.Add(this.labelPlayerNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geekbrains. C# Уровень 1.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPlayerNumber;
        private System.Windows.Forms.Label labelCommandCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMulTwo;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem начатьНовуюИгруToolStripMenuItem;
    }
}

