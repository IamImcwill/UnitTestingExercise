using System;
using System.ComponentModel;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
           Calculator instance = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                int actual = instance.Add(num1, num2, num3);
            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator instance = new Calculator();
            //Act
            int actual = instance.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]//Add test data <-------
        [InlineData(2, 5, 10)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator instance = new Calculator();
            //Act
           int actual = instance.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 2)]//Add test data <-------
        [InlineData(20, 5, 4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();
            //Act
            int actual = instance.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
