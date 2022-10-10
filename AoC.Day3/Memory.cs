using AoC.Common;

namespace AoC.Day3;

public class Memory : IDay
{
    public int PartOne(string input)
    {
        var memory = BuildMemory(int.Parse(input));
        return Math.Abs(memory.Last().X) + Math.Abs(memory.Last().Y);

    }

    public int PartTwo(string input)
    {
        int value = BuildSumMemory(int.Parse(input)).Last().Value;
        return value;
    }

    private List<Space> BuildMemory(int size)
    {
        List<Space> memory = new();
        Dir dir = Dir.R;
        memory.Add(new Space(0, 0, 1));
        for (int i = 2; i <= size; i++)
        {
            switch (dir)
            {
                case Dir.R:
                    memory.Add(memory.Last().Right());
                    break;
                case Dir.U:
                    memory.Add(memory.Last().Up());
                    break;
                case Dir.L:
                    memory.Add(memory.Last().Left());
                    break;
                case Dir.D:
                    memory.Add(memory.Last().Down());
                    break;
                default:
                    break;
            }
            dir = GetNewDir(memory.Last(), dir);
        }
        return memory;
    }

    private List<Space> BuildSumMemory(int size)
    {
        List<Space> memory = new();
        Dir dir = Dir.R;
        memory.Add(new Space(0, 0, 1));
        while (true)
        {
            switch (dir)
            {
                case Dir.R:
                    memory.Add(SetSumOnSpace(memory, memory.Last().Right()));
                    break;
                case Dir.U:
                    memory.Add(SetSumOnSpace(memory, memory.Last().Up()));
                    break;
                case Dir.L:
                    memory.Add(SetSumOnSpace(memory, memory.Last().Left()));
                    break;
                case Dir.D:
                    memory.Add(SetSumOnSpace(memory, memory.Last().Down()));
                    break;
                default:
                    break;
            }
            if (memory.Last().Value > size) break;
            dir = GetNewDir(memory.Last(), dir);
        }
        return memory;
    }

    private Space SetSumOnSpace(List<Space> memory, Space space)
    {
        int sum = 0;
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                if (i == 0 && j == 0) continue;
                Space s = memory.Where(x => x.X == space.X + i && x.Y == space.Y + j).FirstOrDefault();
                if (s != default) sum += s.Value;
            }
        }
        space.Value = sum;
        return space;
    }

    private Dir GetNewDir(Space space, Dir dir)
    {
        switch (dir)
        {
            case Dir.R:
                if (space.X > Math.Abs(space.Y)) return Dir.U;
                return dir;
            case Dir.U:
                if (space.X == space.Y) return Dir.L;
                return dir;
            case Dir.L:
                if (space.X + space.Y == 0) return Dir.D;
                return dir;
            case Dir.D:
                if (space.X - space.Y == 0) return Dir.R;
                return dir;
            default:
                throw new NotImplementedException();
        }
    }

    private record Space(int X, int Y, int Value)
    {
        public int Value { get; set; } = Value;
        public Space Right()
        {
            return new Space(X + 1, Y, Value + 1);
        }
        public Space Up()
        {
            return new Space(X, Y + 1, Value + 1);
        }
        public Space Left()
        {
            return new Space(X - 1, Y, Value + 1);
        }
        public Space Down()
        {
            return new Space(X, Y - 1, Value + 1);
        }
    }
    private enum Dir
    {
        R = 0,
        U = 1,
        L = 2,
        D = 3
    }
}