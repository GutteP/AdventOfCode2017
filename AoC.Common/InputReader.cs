namespace AoC.Common
{
    public static class InputReader
    {
        public static string ReadAllText(string fileName)
        {
            return File.ReadAllText(fileName);
        }
        public static IEnumerable<string> ReadLines(string fileName)
        {
            return File.ReadLines(fileName);
        }
        public static IEnumerable<string> SplitAndClean(string row, params string[] splitOn)
        {
            List<string> values = new List<string> { row };
            foreach (string splitString in splitOn)
            {
                List<string> temp = new();
                foreach (string value in values)
                {
                    temp.AddRange(value.Split(splitString).Select(x => x.Trim()));
                }
                values = temp;
            }
            return values;
        }
    }
}