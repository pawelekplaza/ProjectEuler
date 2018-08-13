namespace Problem14
{
    public class Collatz
    {
        public ulong Number { get; set; }

        public uint GetNumberOfTerms()
        {
            var value = Number;
            uint terms = 1;
            while (value > 1)
            {
                value = NewValue(value);
                terms++;
            }
            return terms;
        }

        private ulong NewValue(ulong value)
        {
            if (value % 2 == 0)
                return value / 2;
            else
                return value * 3 + 1;
        }
    }
}
