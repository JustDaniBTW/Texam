//ДОБАВЛЯЕМ 2 TEXTBOX, LABEL - ВЫВОД РЕЗУЛЬТАТА, КНОПКА ДЛЯ ВЫПОЛНЕНИЯ
   namespace Fixed22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            // Получаем значения координат x и y из текстовых полей
            if (double.TryParse(textX.Text, out double x) && double.TryParse(textY.Text, out double y))
            {
                // Определяем четверть координатной плоскости
                int quadrant;
                if (x > 0 && y > 0)
                {
                    quadrant = 1;
                }
                else if (x < 0 && y > 0)
                {
                    quadrant = 2;
                }
                else if (x < 0 && y < 0)
                {
                    quadrant = 3;
                }
                else if (x > 0 && y < 0)
                {
                    quadrant = 4;
                }
                else
                {
                    quadrant = 0; // Если точка лежит на оси, то не определяем четверть
                }

                // Определяем знак косинуса в зависимости от четверти
                string cosineSign;
                if (quadrant == 0)
                {
                    cosineSign = "Точка лежит на оси";
                }
                else
                {
                    double angle = Math.Atan2(y, x) * 180 / Math.PI;
                    cosineSign = Math.Cos(angle * Math.PI / 180) > 0 ? "Положительный" : "Отрицательный";
                }

                // Выводим результат
                lblResult.Text = $"Точка находится в {quadrant} четверти.\nЗнак функции косинуса: {cosineSign}";
            }
            else
            {
                MessageBox.Show("Введите числовые значения для координат x и y.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        
 
///MStest

using System;
using System.Windows.Forms;
using Fixed22;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bilet22Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void TestButton1_Click_Quadrant1()
        {
            // Arrange
            Form1 form = new Form1();
            form.textX.Text = "3";
            form.textY.Text = "4";
            string expected = "Точка находится в 1 четверти.\nЗнак функции косинуса: Положительный";

            // Act
            form.button1_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(expected, form.lblResult.Text);
        }

        [TestMethod]
        public void TestButton1_Click_Quadrant2()
        {
            // Arrange
            Form1 form = new Form1();
            form.textX.Text = "-3";
            form.textY.Text = "4";
            string expected = "Точка находится в 2 четверти.\nЗнак функции косинуса: Отрицательный";

            // Act
            form.button1_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(expected, form.lblResult.Text);
        }

        

         }
    }

