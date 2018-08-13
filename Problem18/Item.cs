using System.Collections.Generic;

namespace Problem18
{
    public class Item
    {
        public static Dictionary<Item, int> Cache = new Dictionary<Item, int>();

        public int Value { get; set; }
        public List<Item> Children { get; set; }

        public int MaxSum
        {
            get
            {
                if (Cache.ContainsKey(this))
                    return Cache[this];

                if (Children == null)
                {
                    Cache[this] = Value;
                    return Value;
                }


                var max1 = Children[0].MaxSum;
                var max2 = Children[1].MaxSum;

                Cache[this] = Value + (max1 > max2 ? max1 : max2);
                return Cache[this];
            }
        }

        public Item() { }

        public Item(string value)
        {
            Value = int.Parse(value);
        }

        public override string ToString()
        {
            return $"{ Value } (sum: { MaxSum })";
        }
    }
}
