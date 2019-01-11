using System;
using Xunit;
using Day02;

namespace Day02TDD
{
    public class UnitTest1
    {
        // Vinicio - A fact is *always* true
        [Fact]
        public void CanReturnOne()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equal("1",Program.FizzBuzz(1));
        }

        [Fact]
        public void CanReturnTwo()
        {
            Assert.Equal("2",Program.FizzBuzz(2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void CanReturnFizz(int number)
        {
            Assert.Equal("Fizz",Program.FizzBuzz(number));
        }

        [Fact]
        public void CanReturnBuzz()
        {
            Assert.Equal("Buzz",Program.FizzBuzz(5));
        }

        [Fact]
        public void CanReturnFizzBuzz()
        {
            Assert.Equal("FizzBuzz",Program.FizzBuzz(15));
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("Fizz",3)]
        [InlineData("Buzz",5)]
        [InlineData("FizzBuzz",15)]
        public void FizzBuzzTests(string expected, int actual)
        {
            Assert.Equal(expected, Program.FizzBuzz(actual));
        }
    }
}
