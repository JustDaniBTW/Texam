// добавляем 2 combobox (1 для валюты которая у нас есть, 2 для конвертации, под ними 2 textbox по такому же принципу, и кнопка для выполнения)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bilet20
{
    
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            // Задаем начальные значения для комбо боксов
            comboBox1.SelectedIndex = 0; // Выбранная валюта по умолчанию - RUB
            comboBox2.SelectedIndex = 1; // Валюта для конвертации по умолчанию - EUR
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем выбранные валюты из комбо боксов
            string currencyFrom = comboBox1.SelectedItem.ToString();
            string currencyTo = comboBox2.SelectedItem.ToString();

            // Получаем введенную сумму
            if (!decimal.TryParse(textBox1.Text, out decimal amount))
            {
                MessageBox.Show("Введите корректную сумму.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Выполняем конвертацию
            decimal result = ConvertCurrency(currencyFrom, currencyTo, amount);

            // Отображаем результат во втором текстбоксе
            textBox2.Text = result.ToString("0.00");
        }

        private decimal ConvertCurrency(string currencyFrom, string currencyTo, decimal amount)
        {
            // Здесь вы можете добавить реальную логику конвертации валют
            // Например, использовать реальные курсы обмена или API сервиса конвертации валют

            // Для примера, давайте воспользуемся фиктивными курсами
            decimal rate = GetExchangeRate(currencyFrom, currencyTo);
            decimal result = amount * rate;

            return result;
        }

        // Функция для получения курса обмена валют
        private decimal GetExchangeRate(string currencyFrom, string currencyTo)
        {
            if (currencyFrom == "RUB" && currencyTo == "EUR")
                return 0.013m;
            else if (currencyFrom == "RUB" && currencyTo == "USD")
                return 0.015m;
            else if (currencyFrom == "RUB" && currencyTo == "GBP")
                return 0.011m;
            else if (currencyFrom == "EUR" && currencyTo == "RUB")
                return 75.50m;
            else if (currencyFrom == "EUR" && currencyTo == "USD")
                return 1.21m;
            else if (currencyFrom == "EUR" && currencyTo == "GBP")
                return 0.88m;
            else if (currencyFrom == "USD" && currencyTo == "RUB")
                return 66.67m;
            else if (currencyFrom == "USD" && currencyTo == "EUR")
                return 0.83m;
            else if (currencyFrom == "USD" && currencyTo == "GBP")
                return 0.73m;
            else if (currencyFrom == "GBP" && currencyTo == "RUB")
                return 90.91m;
            else if (currencyFrom == "GBP" && currencyTo == "EUR")
                return 1.13m;
            else if (currencyFrom == "GBP" && currencyTo == "USD")
                return 1.37m;
            else
            {
                // Если для выбранных валют нет курса, можно вернуть значение по умолчанию или обработать исключение
                throw new ArgumentException("Курс обмена не найден для выбранных валют.");
            }
        }
    }
    }

        


