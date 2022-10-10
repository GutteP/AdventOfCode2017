using AoC.Day3;
using BenchmarkDotNet.Attributes;

namespace AoC17.Benchmarks
{
    [MemoryDiagnoser(true)]
    public class Day3Benchmarks
    {
        private Memory _memory;

        [GlobalSetup]
        public void Setup()
        {
            _memory = new Memory();
        }

        [Benchmark]
        public void OriginalSolution()
        {
            _memory.PartTwo("361527");
        }
    }
}
