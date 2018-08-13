using System;

namespace Problem11
{
    public class Sequence
    {
        public int Row { get; set; }
        public int ColumnInit { get; set; }
        public Func<int, bool> LoopCondition { get; set; }
        public Func<int, int> ValueToCheckDifference { get; set; }
    }
}
