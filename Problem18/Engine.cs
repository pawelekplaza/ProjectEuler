using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem18
{
    public class Engine
    {
        private List<Item> _treeHead;
        public Engine()
        {
            _treeHead = new List<Item> { new Item(File.ReadLines("source.txt").First().Split().First()) };
            var source = new List<string[]>();
            using (var file = new FileStream("source.txt", FileMode.Open, FileAccess.Read))
            using (var reader = new StreamReader(file))
            {
                var currentItem = _treeHead;
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var splitted = line.Split();

                    currentItem = SetChildren(currentItem, splitted);
                }
            }
        }

        public int GetSum() => _treeHead.First().MaxSum;

        private List<Item> SetChildren(List<Item> currentItems, string[] splitted)
        {
            var list = new List<Item>();
            list = splitted.Select(v => new Item(v)).ToList();
            for (int i = 0; i < currentItems.Count; i++)
                currentItems[i].Children = new List<Item> { list[i], list[i + 1] };
            return list;
        }
    }
}