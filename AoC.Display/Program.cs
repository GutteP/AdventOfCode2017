using AoC.Common;
using AoC.Day1;
using AoC.Day2;

List<Type> days = new List<Type> { typeof(DayOne), typeof(CheckSumCalculation) };

foreach (Type typeofDay in days)
{
    IDay day = (IDay)Activator.CreateInstance(typeofDay);
    Console.WriteLine($"-------- Day {day.Number}! --------");
    Console.WriteLine("--- Part 1 ---");
    Console.WriteLine(day.About);
    Console.WriteLine(day.PartOneDescription);
    Console.WriteLine(day.PartOne($"i{day.Number}.txt"));
    Console.WriteLine();
    Console.WriteLine("--- Part 2 ---");
    Console.WriteLine(day.PartTwoDescription);
    Console.WriteLine(day.PartTwo($"i{day.Number}.txt"));
    Console.WriteLine();
}

Console.ReadLine();

