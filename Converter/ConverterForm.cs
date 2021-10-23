using System;
using System.Text;
using System.Windows.Forms;

namespace Converter
{
    public partial class ConverterForm : Form
    {
        private int number = 0;

        public ConverterForm()
        {
            InitializeComponent();
        }

        private void TextBox_Decimal_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Decimal.Text != "")
            {
                //Проверка
                //number = Convert.ToInt32(textBox_Decimal.Text);
                //textBox_Binary.Text = Convert.ToString(number, 2);
                //textBox_Hexadecimal.Text = Convert.ToString(number, 16);
                //textBox_Octal.Text = Convert.ToString(number, 8);

                textBox_Ternary.Text = ToTrenary(number);
            }
        }

        public String ToTrenary(int value)
        {
            StringBuilder Sb = new StringBuilder();

            while (value > 0)
            {
                Sb.Insert(0, value % 3);
                value /= 3;
            }

            return Sb.ToString();
        }
    }
}
