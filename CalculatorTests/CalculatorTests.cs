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
        [InlineData(0, "", 0)]
        [InlineData(38412312, "-", -38412312)]
        public void TestWritingFirsVariable(double number, string labelText, double expectedResult)
        {
            //Arrage
            Label label = new Label() { Text = labelText };
            //Act
            result = _calc.Put_A(number, label);
            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void TestMultiplication()
        {
            double variable_1 = 0;
            string labelText = null;
            double expectedResult = 0;
            Label label = new Label() { Text = labelText };

            result = _calc.Multiplication(variable_1,label);

            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void TestDivision()
        {
            double variable_1 = 3;
            string labelText = null;
            double expectedResult = 0;

            Label label = new Label() { Text = labelText };
            
            result = _calc.Division(variable_1, label);

            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void TestSubstraction()
        {
            double variable_1 = 0;
            string labelText = null;
            double expectedResult = 0;

            Label label = new Label() { Text = labelText };

            result = _calc.Subtraction(variable_1, label);

            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void TestSum()
        {
            double variable_1 = 0;
            string labelText = null;
            double expectedResult = 0;

            Label label = new Label() { Text = labelText };

            result = _calc.Sum(variable_1, label);

            Assert.Equal(expectedResult, result);
        }
    }
}
