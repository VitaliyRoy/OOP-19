using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string RemoveDigits(string input)
        {
            // Створюємо рядок, у який будемо додавати символи без цифр
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                // Якщо символ не є цифрою, додаємо його до результату
                if (!Char.IsDigit(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        public string ReplaceSubstring(string input)
        {
            // Замінюємо всі входження 'карб' на 'грн'
            string result = input.Replace("карб", "грн");

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = txt_start1.Text;

            string result1 = RemoveDigits(input1);

            txt_finish1.Text = result1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input2 = txt_start2.Text;

            string result2 = ReplaceSubstring(input2);

            txt_finish2.Text = result2;
        }

    }
}
