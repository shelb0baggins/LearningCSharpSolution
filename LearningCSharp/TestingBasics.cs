using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class TestingBasics
    {
        [Fact]
        public void CanAddTwoNumbers() {
            //Given - Arrange
            int a = 10, b = 20;
            //When - Act
            int answer = a + b;
            //Then - Assert
            Assert.Equal(30, answer);
        }
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(10, 10, 20)]
        [InlineData(100, 25, 125)]
        public void CanAddNums(int a, int b, int expected) {
            int ans = a + b;
            Assert.Equal(expected, ans);
        }


    }
}
