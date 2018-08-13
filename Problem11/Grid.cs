using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem11
{
    public class Grid
    {
        private int _size;
        public List<int> Table { get; set; }

        public Grid(string inputString)
        {
            Table = new List<int>();
            var splittedString = inputString.Split();
            foreach (var value in splittedString)
                Table.Add(int.Parse(value));

            _size = (int)Math.Sqrt(Table.Count);
        }

        public int GetGreatestProduct()
        {
            var max = 0;
            for (var row = 0; row < _size - 3; row++)
            {
                var list = new List<int>
                {
                    UpDown(row),
                    LeftRightDiagonal(row),
                    RightLeftDiagonal(row)
                };

                if (list.Max() > max)
                    max = list.Max();
            }
            return max;
        }

        private int UpDown(int row)
        {
            var sequence = new Sequence(row)
            {
                ColumnInit = 0,
                LoopCondition = column => column < _size,
                ValueToCheckDifference = i => 0
            };
            return CheckSequence(sequence);
        }

        private int LeftRightDiagonal(int row)
        {
            var sequence = new Sequence(row)
            {
                ColumnInit = 0,
                LoopCondition = column => column < _size - 3,
                ValueToCheckDifference = i => i
            };
            return CheckSequence(sequence);
        }

        private int RightLeftDiagonal(int row)
        {
            var sequence = new Sequence(row)
            {
                ColumnInit = 3,
                LoopCondition = column => column < _size,
                ValueToCheckDifference = i => -i
            };
            return CheckSequence(sequence);
        }

        private int CheckSequence(Sequence sequence)
        {
            var max = 0;
            for (var column = sequence.ColumnInit; sequence.LoopCondition(column); column++)
            {
                var valueToCheck = 1;
                for (var i = 0; i < 4; i++)
                    valueToCheck *= Table[(sequence.Row * _size) + (i * _size) + column + sequence.ValueToCheckDifference(i)];

                if (valueToCheck > max)
                    max = valueToCheck;
            }
            return max;
        }
    }
}
