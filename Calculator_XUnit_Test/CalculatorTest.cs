using Labb_7_Calculator;

namespace Calculator_XUnit_Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Addition_Test_Fact()
        {
            //Arrange
            Calculator cal = new Calculator();
            decimal num1 = 10;
            decimal num2 = 10;
            decimal expected = 20;

            //Act
            var result = cal.Addition(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }



        [Theory]
        [InlineData(10, 10, 20)]
        [InlineData(25.5, 20, 45.5)]
        [InlineData(15, 0.7, 15.7)]
        [InlineData(9, 10, 19)]
        [InlineData(100, 10, 110)]

        public void Addition_Test(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            var result = cal.Addition(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(10, 10, 0)]
        [InlineData(25.5, 20, 5.5)]
        [InlineData(15, 0.7, 14.3)]
        [InlineData(9, 10, -1)]
        [InlineData(100, 10, 90)]

        public void Subtraction_Test(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            var result = cal.Subtraction(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 10, 1)]
        [InlineData(25.5, 20, 1.28)]
        [InlineData(15, 0.7, 21.43)]
        [InlineData(9, 10, 0.9)]
        [InlineData(100, 10, 10)]

        public void Division_Test(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            var result = cal.Division(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 10, 100)]
        [InlineData(25.5, 20, 510)]
        [InlineData(15, 0.7, 10.5)]
        [InlineData(9, 10, 90)]
        [InlineData(100, 10, 1000)]

        public void Multiplication_Test(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            var result = cal.Multiplication(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}