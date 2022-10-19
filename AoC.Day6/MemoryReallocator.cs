using AoC.Common;

namespace AoC.Day6;

public class MemoryReallocator : IDay
{
    private BlockMemory _blockMemory;
    private List<string> _configs;
    public int PartOne(string fileName)
    {
        var input = InputReader.ReadLines(fileName).ToList();
        List<int> memory = input[0].Split("\t").Select(x => int.Parse(x)).ToList();
        _blockMemory = new(memory);
        _configs = new();
        _configs.Add(_blockMemory.CurrentConfiguration());
        int cycles = 0;
        while (true)
        {
            cycles++;
            int most = _blockMemory.MostBlocks();
            string conf = _blockMemory.Redistribute(most);
            if (_configs.Contains(conf))
            {
                _configs.Add(conf);
                break;
            }
            else _configs.Add(conf);
        }

        return cycles;
    }

    public int PartTwo(string fileName)
    {
        PartOne(fileName);
        string expectedConfig = _configs.Last();
        int cycles = 0;
        while (true)
        {
            cycles++;
            int most = _blockMemory.MostBlocks();
            string conf = _blockMemory.Redistribute(most);
            if (conf == expectedConfig) break;
        }

        return cycles;
    }


}

public class BlockMemory
{
    private readonly List<int> _memory;

    public BlockMemory(List<int> memory)
    {
        _memory = memory;
    }

    public int MostBlocks()
    {
        int index = 0;
        int most = -1;
        for (int i = 0; i < _memory.Count; i++)
        {
            if (_memory[i] > most)
            {
                most = _memory[i];
                index = i;
            }
        }
        return index;
    }

    public string Redistribute(int index)
    {
        int v = _memory[index];
        _memory[index] = 0;
        int i = index + 1;
        while (v > 0)
        {
            try
            {
                _memory[i]++;
                v--;
            }
            catch (Exception)
            {
                i = i - _memory.Count;
                _memory[i]++;
                v--;
            }
            finally
            {
                i++;
            }
        }

        return CurrentConfiguration();
    }

    public string CurrentConfiguration()
    {
        return string.Join(",", _memory.ToArray());
    }
}