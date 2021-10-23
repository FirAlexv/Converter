using System;
using Xunit;
using Converter;

namespace TestProjectConverter
{
    

    public class UnitTestConverter
    {
        [Fact]
        public void TestToBinary()
        {
            // Arrange
            int value = 9;
            string expected = "1001";

            // Act
            ConverterForm converterForm = new();
            string actual = converterForm.ToBinary(value);

            // Assert
            Assert.Equal(expected,actual);
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
