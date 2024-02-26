using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class CalculatorTests0
    {
        [Theory]
        [InlineData(0, 1, 1, 2)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, -1, -1, -3)]
        [InlineData(-2, 1, 1, 0)]
        public void Add_Test(int num1, int num2, int num3, int expected)
        {
            var c = new Calculator();

            var actual = c.Add(num1, num2, num3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 0)]
        [InlineData(-2, 1, -3)]
        public void Subtract_Test(int num1, int num2, int expected)
        {
            var c = new Calculator();

            var actual = c.Subtract(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(3, 3, 9)]
        [InlineData(5, 5, 25)]
        public void Multiply_Test(int num1, int num2, int expected)
        {
            var c = new Calculator();

            var actual = c.Multiply(num1, num2);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(0, 0, 0)]
        [InlineData(3, 3, 1)]
        [InlineData(40, 8, 5)]
        public void Divide_Test(int num1, int num2, int expected)
        {
            var c = new Calculator();

            var actual = c.Divide(num1, num2);

            Assert.Equal(expected, actual);
        }
    }
}
