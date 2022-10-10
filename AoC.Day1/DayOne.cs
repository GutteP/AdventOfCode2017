using AoC.Common;

namespace AoC.Day1
{
    public class DayOne : IDay
    {
        public int PartOne(string fileName)
        {
            var input = InputReader.ReadAllText(fileName);
            return Calculate(input, 1);
        }

        public int PartTwo(string fileName)
        {
            var input = InputReader.ReadAllText(fileName);
            return Calculate(input, input.Length / 2);
        }

        private int Calculate(string input, int steps)
        {
            int sum = 0;
            for (int a = 0; a < input.Length; a++)
            {
                int b = a + steps;
                while (b >= input.Length)
                {
                    b = b - input.Length;
                }
                if (int.Parse(input[a].ToString()) == int.Parse(input[b].ToString())) sum += int.Parse(input[a].ToString());
            }
            return sum;
        }
    }
}