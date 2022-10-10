using AoC.Day1;

namespace AoC17.Test;

public class Day1Tests
{
    [Theory]
    [InlineData("i1t1.txt", 3)]
    [InlineData("i1t2.txt", 4)]
    [InlineData("i1t3.txt", 0)]
    [InlineData("i1t4.txt", 9)]
    [InlineData("i1.txt", 1203)]
    public void PartOne(string fileName, int expected)
    {
        DayOne dayOne = new();
        int result = dayOne.PartOne(fileName);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("i1t5.txt", 4)]
    [InlineData("i1.txt", 1146)]
    public void PartTwo(string fileName, int expected)
    {
        DayOne dayOne = new();
        int result = dayOne.PartTwo(fileName);
        Assert.Equal(expected, result);
    }
}