using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    class Hall
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public List<Performance> Performances { get; set; }
        public List<Row> Rows { get; set; }
        public Hall(int number, string name, int rows, int places)
        {
            Number = number;
            Name = name;
            Rows = new List<Row>();
            for (int i = 0; i < rows; i++)
            {
                Rows.Add(new Row(places, i + 1));
            }
            
        }

        public override string ToString()
        {
            int[,] array = new int[Rows.Count, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write($"[{i + 1}.{k + 1}]");
                }
                Console.WriteLine();
            }
            return $"{Name} ({Number}), rows: {Rows.Count}, total places: {Rows.Sum(x => x.Places.Count)}{Environment.NewLine}";

            //return $"{Name} ({Number}), rows: {Rows.Count}, total places: {Rows.Sum(x => x.Places.Count)}{Environment.NewLine}{string.Join(Environment.NewLine, Rows.Select(x => string.Join(" ", x.Places.Select(p => $"[{x.Number}.{p.Number}]"))))}";
        }
    }
}
