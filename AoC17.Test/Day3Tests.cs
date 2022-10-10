using AoC.Day3;

namespace AoC17.Test;

public class Day3Tests
{
    [Theory]
    [InlineData("1", 0)]
    [InlineData("12", 3)]
    [InlineData("1024", 31)]
    [InlineData("361527", 326)]
    public void SpiralMemory_Tests(string input, int expected)
    {
        Memory sut = new();
        Assert.Equal(expected, sut.PartOne(input));
    }

    [Theory]
    [InlineData("1", 2)]
    [InlineData("12", 23)]
    [InlineData("361527", 363010)]
    public void SumMemory_Tests(string input, int expected)
    {
        Memory sut = new();
        Assert.Equal(expected, sut.PartTwo(input));
    }
}
