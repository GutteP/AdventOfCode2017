using AoC.Common;

namespace AoC.Day4;

public class PassphraseValidator : IDay
{
    public int PartOne(string fileName)
    {
        var input = InputReader.ReadLines(fileName).ToList();
        int sum = 0;
        foreach (string line in input)
        {
            string[] words = line.Split(' ');
            if (ContainsDuplicate(words)) sum++;
        }
        return sum;
    }

    public int PartTwo(string fileName)
    {
        var input = InputReader.ReadLines(fileName).ToList();
        int sum = 0;
        foreach (string line in input)
        {
            string[] words = line.Split(' ');
            if (ContainsDuplicate(words) && ContainsAnagram(words)) sum++;
        }
        return sum;
    }

    private bool ContainsAnagram(string[] words)
    {
        string[] charSortedWords = words.Select(x => string.Concat(x.OrderBy(o => o))).ToArray();
        foreach (string word in charSortedWords)
        {
            if (charSortedWords.Where(w => w == word).Count() > 1)
            {
                return false;
            }
        }
        return true;
    }

    private bool ContainsDuplicate(string[] words)
    {
        foreach (string word in words)
        {
            if (words.Where(w => w == word).Count() > 1)
            {
                return false;
            }
        }
        return true;
    }


}