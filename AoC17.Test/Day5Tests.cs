using AoC.Day5;

namespace AoC17.Test;

public class Day5Tests
{
    [Theory]
    [InlineData("i5t1.txt", 5)]
    [InlineData("i5.txt", 372671)]
    public void PartOne_Tests(string input, int expected)
    {
        JumpRunner sut = new JumpRunner();
        Assert.Equal(expected, sut.PartOne(input));
    }

    [Theory]
    [InlineData("i5t1.txt", 10)]
    [InlineData("i5.txt", 25608480)]
    public void PartTwo_Tests(string input, int expected)
    {
        JumpRunner sut = new JumpRunner();
        Assert.Equal(expected, sut.PartTwo(input));
    }
}
