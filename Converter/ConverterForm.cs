using System;
using System.Text;
using System.Windows.Forms;

namespace Converter
{
    public partial class ConverterForm : Form
    {
        StringBuilder sbstr = new StringBuilder();

        public ConverterForm()
        {
            InitializeComponent();
        }

        private void TextBox_Decimal_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Decimal.Text != "")
            {
                //Проверка
                //textBox_Binary.Text = Convert.ToString(number, 2);
                //textBox_Ternary.Text = ToTrenary(Convert.ToInt32(textBox_Decimal.Text));
                //textBox_Octal.Text = Convert.ToString(number, 8);
                //textBox_Hexadecimal.Text = Convert.ToString(number, 16);
                textBox_Binary.Text = ToBinary(Convert.ToInt32(textBox_Decimal.Text));
                textBox_Ternary.Text = ToTernary(Convert.ToInt32(textBox_Decimal.Text));
                textBox_Octal.Text = ToOctal(Convert.ToInt32(textBox_Decimal.Text));
            }
        }

        /// <summary>
        /// Перевод из 10-ой системы счисления в 2-ю
        /// </summary>
        /// <remarks>Примечание:</remarks>
        /// <param name="value">10-ое число</param>
        /// <returns>Двоичное представление числа как строку</returns>
        public string ToBinary(int value)
        {
            sbstr.Clear();//Очитска подстроки

            while (value > 0)//Цикл перевода
            {
                sbstr.Insert(0, value % 2);//2 индекс перевода/делитель
                value /= 2;
            }

            return sbstr.ToString();//Вывод
        }

        /// <summary>
        /// Перевод из 10-ой системы счисления в 3-ю
        /// </summary>
        /// <remarks>Примечание:</remarks>
        /// <param name="value">10-ое число</param>
        /// <returns>Троичиное представление числа как строку</returns>
        public string ToTernary(int value)
        {
            sbstr.Clear();//Очитска подстроки

            while (value > 0)//Цикл перевода
            {
                sbstr.Insert(0, value % 3);//3 индекс перевода/делитель
                value /= 3;
            }

            return sbstr.ToString();//Вывод
        }

        /// <summary>
        /// Перевод из 10-ой системы счисления в 8-ю
        /// </summary>
        /// <remarks>Примечание:</remarks>
        /// <param name="value">10-ое число</param>
        /// <returns>Восмеричное представление числа как строку</returns>
        public string ToOctal(int value)
        {
            sbstr.Clear();//Очитска подстроки

            while (value > 0)//Цикл перевода
            {
                sbstr.Insert(0, value % 8);//8 индекс перевода/делитель
                value /= 8;
            }

            return sbstr.ToString();//Вывод
        }
    }
}
