using AoC.Day6;

namespace AoC17.Test;

public class Day6Tests
{
    [Theory]
    [InlineData("i6t1.txt", 5)]
    [InlineData("i6.txt", 3156)]
    public void PartOne_Tests(string input, int expected)
    {
        MemoryReallocator sut = new MemoryReallocator();
        Assert.Equal(expected, sut.PartOne(input));
    }

    [Theory]
    [InlineData("i6t1.txt", 4)]
    [InlineData("i6.txt", 1610)]
    public void PartTwo_Tests(string input, int expected)
    {
        MemoryReallocator sut = new MemoryReallocator();
        Assert.Equal(expected, sut.PartTwo(input));
    }
}
