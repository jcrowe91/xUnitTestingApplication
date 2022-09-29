using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            //Act
            double actual = Calculator.Add(x, y);
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract_SimpleValuesShouldCalculate()
        {
            //Arrange
            double expected = 4;
            double actual = Calculator.Subtract(6, 2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, 2, 100)]
        [InlineData(5, 12, 60)]
        public void Multiply_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
           double actual = Calculator.Multiply(x, y);
            Assert.Equal(expected, actual); 
        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            double expected = 0;
            double actual = Calculator.Divide(15, 0);
            Assert.Equal(expected, actual);
        }
    }
}
