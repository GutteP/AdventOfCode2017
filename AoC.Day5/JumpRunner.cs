using AoC.Common;

namespace AoC.Day5;

public class JumpRunner : IDay
{
    public int PartOne(string fileName)
    {
        List<int> jumps = InputReader.ReadLines(fileName).Select(x => int.Parse(x)).ToList();
        return Run(jumps);

    }

    public int PartTwo(string fileName)
    {
        List<int> jumps = InputReader.ReadLines(fileName).Select(x => int.Parse(x)).ToList();
        return Run(jumps, true);
    }

    private int Run(List<int> jumps, bool decreaseHighNumbers = false)
    {
        int i = 0;
        int steps = 0;
        while (i >= 0 && i < jumps.Count)
        {
            int j = i;
            i = i + jumps[i];
            if (decreaseHighNumbers && jumps[j] >= 3) jumps[j]--;
            else jumps[j]++;
            steps++;
        }
        return steps;
    }

}