using Xunit;
using Калькулятор;
using System.Windows.Forms;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        Calc _calc = new Calc();
        public double result = 0;

        [Theory]
        [InlineData(19293912, "", 19293912)]
        [InlineData(122222, "-", -122222)]
        [InlineData(0, "-", 0)]
        public void TestPut_A(double number, string labelText, double expectedResult)
        {
            //Arrage
            Label label = new Label() { Text = labelText };
            //Act
            result = _calc.Put_A(number, label);
            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void TestMulpiplication()
        {
            double number_1 = 0;
            string labelText = null;
            double expectedResult = 0;

            Label label = new Label() { Text = labelText };

            result = _calc.Put_A(number_1, label);

            Assert.Equal(expectedResult, result);
        }
    }
}
