using AoC.Day2;

namespace AoC17.Test
{
    public class Day2Tests
    {
        [Theory]
        [InlineData("i2t1.txt", 18)]
        [InlineData("i2.txt", 51833)]
        public void PartOne(string fileName, int expected)
        {
            CheckSumCalculation checkSumCalculation = new CheckSumCalculation();
            var result = checkSumCalculation.PartOne(fileName);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("i2t2.txt", 9)]
        [InlineData("i2.txt", 288)]
        public void PartTwo(string fileName, int expected)
        {
            CheckSumCalculation checkSumCalculation = new CheckSumCalculation();
            var result = checkSumCalculation.PartTwo(fileName);
            Assert.Equal(expected, result);
        }
    }
}
