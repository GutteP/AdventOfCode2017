namespace Days

module Day1 =

    open Xunit
    open CaptchaSolver
    open Reader

    [<Theory>]
    [<InlineData("Day 1/i1.txt", 1203, 1146)>]
    let ``Day1`` (fileName, p1, p2) =
        Assert.Equal(p1, part1 (readFile fileName))
        Assert.Equal(p2, part2 (readFile fileName))

module Day2 = 
    open Xunit
    open ChecksumCalculator
    open Reader


    [<Theory>]
    [<InlineData("Day 2/i2t1.txt", 18)>]
    [<InlineData("Day 2/i2.txt", 51833)>]
    let ``Day2_part1`` (fileName, p1) =
        Assert.Equal(p1, part1 (readFile fileName))

    [<Theory>]
    [<InlineData("Day 2/i2t2.txt", 9)>]
    [<InlineData("Day 2/i2.txt", 288)>]
    let ``Day2_part2`` (fileName, p2) =
        Assert.Equal(p2, part2 (readFile fileName))

    [<Theory>]
    [<InlineData("Day 2/i2t2.txt", 9)>]
    [<InlineData("Day 2/i2.txt", 288)>]
    let ``Day2_part2Alt`` (fileName, p2) =
        Assert.Equal(p2, part2Alt (readFile fileName))