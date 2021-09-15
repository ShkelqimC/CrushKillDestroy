using System;
using CrushKillDestroy;
using Xunit;

namespace CrushKillDestroyLibraryTests
{
    public class UnitTest1
    {
        [Fact]
        public void CombinedLenghtOfWords_Test_TwoStrings_ShouldReturn10()
        {
            //arrange
            string[] strings = new[] {"HellO", "World"};
            int expected = 10;
            //act
            int actual = CKDLibrary.CountLengthOfWords(strings);

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
