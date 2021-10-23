using System;
using Xunit;
using Converter;

namespace TestProjectConverter
{
    public class UnitTest
    {

        [Fact]
        public void TestToBinary()
        {
            // Arrange
            int value = 9;
            string expected = "1001";

            // Act
            ConverterForm converterForm = new();
            //Я попробовал решить ее но решение, которое было в интернете для меня, не подошло
            string actual = converterForm.ToBinary(value);//Ошибка CS0012  Тип "Form" определен в сборке, на которую нет ссылки. Следует добавить ссылку на сборку "System.Windows.Forms, Version=4.0.0.0


            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestToTernary()
        {
            // Arrange
            int value = 11;
            string expected = "102";

            // Act
            ConverterForm converterForm = new();
            string actual = converterForm.ToTernary(value);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestToOctal()
        {
            // Arrange
            int value = 11;
            string expected = "13";

            // Act
            ConverterForm converterForm = new();
            string actual = converterForm.ToOctal(value);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
