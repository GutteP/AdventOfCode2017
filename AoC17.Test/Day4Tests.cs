using AoC.Day4;

namespace AoC17.Test
{
    public class Day4Tests
    {
        [Theory]
        [InlineData("i4t1.txt", 1)]
        [InlineData("i4t2.txt", 4)]
        [InlineData("i4.txt", 386)]

        public void PartOne_Tests(string inputFile, int value)
        {
            PassphraseValidator passphraseValidator = new PassphraseValidator();
            Assert.Equal(value, passphraseValidator.PartOne(inputFile));
        }

        [Theory]
        [InlineData("i4t1.txt", 1)]
        [InlineData("i4t2.txt", 1)]
        [InlineData("i4.txt", 208)]

        public void PartTwo_Tests(string inputFile, int value)
        {
            PassphraseValidator passphraseValidator = new PassphraseValidator();
            Assert.Equal(value, passphraseValidator.PartTwo(inputFile));
        }

    }
}
