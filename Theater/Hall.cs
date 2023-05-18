﻿using System;
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
        public Hall(int number, string name, int rows, int places, int performances)
        {
            Number = number;
            Name = name;
            Rows = new List<Row>();         
            for (int i = 0; i < rows; i++)
            {
                Rows.Add(new Row(places, i + 1));
            }

            
            Performances = new List<Performance>();                
            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" };
            for (int i = 0; i < performances; i++)
            {
                Random rnd = new Random();
                string randomLetters = letters[rnd.Next(0, letters.Length)];
                Performances.Add(new Performance(randomLetters));
            }

        }

        public override string ToString()
        {

            string qwe = $"{Name} ({Number}), rows: {Rows.Count}, total places: {Rows.Sum(x => x.Places.Count)}, total performances: {Performances.Count}{Environment.NewLine}";
            foreach (var row in Rows)
            {
                foreach (var place in row.Places)
                {
                    qwe += $"[{row.Number}.{place.Number}]";
                    
                }
                qwe += Environment.NewLine;
            }         
            return qwe;

            //return $"{Name} ({Number}), rows: {Rows.Count}, total places: {Rows.Sum(x => x.Places.Count)}{Environment.NewLine}{string.Join(Environment.NewLine, Rows.Select(x => string.Join(" ", x.Places.Select(p => $"[{x.Number}.{p.Number}]"))))}";
        }
    }
}
