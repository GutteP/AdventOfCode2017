using AoC.Common;

namespace AoC17.Test;

public class InputReaderTests
{
    [Fact]
    public void ReadAllText()
    {
        var input = InputReader.ReadAllText("commonTestFile1.txt");
        Assert.Equal("HejHej - test", input);
    }
    [Fact]
    public void ReadLines()
    {
        List<string> input = InputReader.ReadLines("commonTestFile2.txt").ToList();
        Assert.Equal("Rows:", input[0]);
        Assert.Equal("One", input[1]);
        Assert.Equal("Two", input[2]);
        Assert.Equal(3, input.Count);
    }
}
