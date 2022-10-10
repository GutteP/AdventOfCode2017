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
            bool valid = true;
            foreach (string word in words)
            {
                if (ContainsDuplicate(words, word))
                {
                    valid = false;
                    break;
                }
            }
            if (valid) sum++;
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
            string[] charSortedWords = words.Select(x => string.Concat(x.OrderBy(o => o))).ToArray();
            bool valid = true;
            foreach (string word in words)
            {
                if (ContainsDuplicate(words, word) || ContainsAnagram(charSortedWords, word))
                {
                    valid = false;
                    break;
                }
            }
            if (valid) sum++;
        }
        return sum;
    }

    private bool ContainsAnagram(string[] charSortedWords, string word)
    {
        string sortedWord = string.Concat(word.OrderBy(x => x));
        return charSortedWords.Where(w => w == sortedWord).Count() > 1;
    }

    private bool ContainsDuplicate(string[] words, string word)
    {
        return words.Where(w => w == word).Count() > 1;
    }


}