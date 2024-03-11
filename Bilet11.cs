//МОДУЛЬ
//=============================================================================================================\\
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet11
{
    public partial class PassG : Form
    {
        public PassG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = 10; // Длина пароля
            string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"; // Допустимые символы для пароля
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            // Генерация случайных символов для пароля
            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(validChars.Length);
                sb.Append(validChars[index]);
            }

            // Установка сгенерированного пароля в текстовом поле
            textBox1.Text = sb.ToString();
        }
    }
}
// Просто кнопка и textbox

