namespace WindowsFormsApp7WeatherForecast
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelForecast1 = new System.Windows.Forms.Label();
            this.labelForecast2 = new System.Windows.Forms.Label();
            this.labelForecast3 = new System.Windows.Forms.Label();
            this.labelForecast4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.LightGreen;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(530, 74);
            this.labelHeader.TabIndex = 7;
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Город Кузнецк";
            // 
            // labelForecast1
            // 
            this.labelForecast1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelForecast1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForecast1.Location = new System.Drawing.Point(12, 110);
            this.labelForecast1.Name = "labelForecast1";
            this.labelForecast1.Size = new System.Drawing.Size(235, 205);
            this.labelForecast1.TabIndex = 9;
            // 
            // labelForecast2
            // 
            this.labelForecast2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelForecast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForecast2.Location = new System.Drawing.Point(253, 110);
            this.labelForecast2.Name = "labelForecast2";
            this.labelForecast2.Size = new System.Drawing.Size(235, 205);
            this.labelForecast2.TabIndex = 10;
            // 
            // labelForecast3
            // 
            this.labelForecast3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelForecast3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForecast3.Location = new System.Drawing.Point(12, 325);
            this.labelForecast3.Name = "labelForecast3";
            this.labelForecast3.Size = new System.Drawing.Size(235, 205);
            this.labelForecast3.TabIndex = 11;
            // 
            // labelForecast4
            // 
            this.labelForecast4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelForecast4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForecast4.Location = new System.Drawing.Point(253, 326);
            this.labelForecast4.Name = "labelForecast4";
            this.labelForecast4.Size = new System.Drawing.Size(235, 205);
            this.labelForecast4.TabIndex = 12;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 559);
            this.Controls.Add(this.labelForecast4);
            this.Controls.Add(this.labelForecast3);
            this.Controls.Add(this.labelForecast2);
            this.Controls.Add(this.labelForecast1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 590);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geekbrains. C# Уровень 1.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelForecast1;
        private System.Windows.Forms.Label labelForecast2;
        private System.Windows.Forms.Label labelForecast3;
        private System.Windows.Forms.Label labelForecast4;
    }
}

