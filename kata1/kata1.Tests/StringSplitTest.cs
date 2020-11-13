using System;
using System.Collections.Generic;
using System.Text;
using kata1;
using Xunit;

namespace kata1.Tests
{
    public class StringSplitTest
    {
        [Theory]
        [InlineData("abcd", new string[] { "ab", "cd" })]
        [InlineData("abcde", new string[] { "ab", "cd","e_" })]
        public void StringSplit(string x, string[] expected)
        {
            //Arrange
            //string[] expected = new string[] { "ab", "cd" };

            //Act
            string[] actual = Program.StringSplit(x);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
