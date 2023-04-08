namespace lr19
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_start1 = new System.Windows.Forms.TextBox();
            this.txt_finish1 = new System.Windows.Forms.TextBox();
            this.txt_start2 = new System.Windows.Forms.TextBox();
            this.txt_finish2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "ОК";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_start1
            // 
            this.txt_start1.Location = new System.Drawing.Point(65, 35);
            this.txt_start1.Name = "txt_start1";
            this.txt_start1.Size = new System.Drawing.Size(302, 20);
            this.txt_start1.TabIndex = 2;
            // 
            // txt_finish1
            // 
            this.txt_finish1.Location = new System.Drawing.Point(65, 79);
            this.txt_finish1.Name = "txt_finish1";
            this.txt_finish1.Size = new System.Drawing.Size(302, 20);
            this.txt_finish1.TabIndex = 3;
            // 
            // txt_start2
            // 
            this.txt_start2.Location = new System.Drawing.Point(65, 179);
            this.txt_start2.Name = "txt_start2";
            this.txt_start2.Size = new System.Drawing.Size(302, 20);
            this.txt_start2.TabIndex = 4;
            // 
            // txt_finish2
            // 
            this.txt_finish2.Location = new System.Drawing.Point(65, 226);
            this.txt_finish2.Name = "txt_finish2";
            this.txt_finish2.Size = new System.Drawing.Size(302, 20);
            this.txt_finish2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введіть послідовність символів з якої хочете прибрати сві числа.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Результат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введіть послідовність символів в якій хочете замінити \'\'карб\'\' на \'\'грн\'\'.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_finish2);
            this.Controls.Add(this.txt_start2);
            this.Controls.Add(this.txt_finish1);
            this.Controls.Add(this.txt_start1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_start1;
        private System.Windows.Forms.TextBox txt_finish1;
        private System.Windows.Forms.TextBox txt_start2;
        private System.Windows.Forms.TextBox txt_finish2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

