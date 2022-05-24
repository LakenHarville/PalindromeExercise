using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("tenet", true)]
        [InlineData("madam", true)]
        [InlineData("deified", true)]
        [InlineData("KaYAk", true)]
        [InlineData("show", false)]
        [InlineData("basic", false)]
        [InlineData("tower", false)]
        [InlineData("none", false)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var tester = new WordSmith();
            //act
            var actual = tester.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
