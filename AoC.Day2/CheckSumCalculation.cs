using AoC.Common;

namespace AoC.Day2
{
    public class CheckSumCalculation : IDay
    {
        public int PartOne(string fileName)
        {
            var input = InputReader.ReadLines(fileName).ToList();
            int sum = 0;
            foreach (string row in input)
            {
                int max = int.MinValue;
                int min = int.MaxValue;
                foreach (string value in InputReader.SplitAndClean(row, "\t", " "))
                {
                    int parsed = int.Parse(value);
                    if (parsed > max) max = parsed;
                    if (parsed < min) min = parsed;
                }
                sum += max - min;
            }
            return sum;
        }

        public int PartTwo(string fileName)
        {
            var input = InputReader.ReadLines(fileName).ToList();
            int sum = 0;
            foreach (string row in input)
            {
                int tempSum = -1;
                var values = InputReader.SplitAndClean(row, "\t", " ").Select(x => double.Parse(x)).ToList();
                for (int i = 0; i < values.Count; i++)
                {
                    for (int j = i + 1; j < values.Count; j++)
                    {
                        if ((values[i] / values[j]) % 1 == 0)
                        {
                            tempSum = (int)(values[i] / values[j]);
                            break;
                        }
                        else if ((values[j] / values[i]) % 1 == 0)
                        {
                            tempSum = (int)(values[j] / values[i]);
                            break;
                        }
                    }
                }
                sum += tempSum;
            }
            return sum;
        }
    }
}