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
                var row = new Row(i + 1);
                Rows.Add(row);
                row.AddPlaces(places);
            }

            
            Performances = new List<Performance>();

            

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
            foreach (var performance in Performances)
            {
                qwe += $"Performance: {performance.Name}";
                qwe += Environment.NewLine;
            }
            return qwe;

            //return $"{Name} ({Number}), rows: {Rows.Count}, total places: {Rows.Sum(x => x.Places.Count)}{Environment.NewLine}{string.Join(Environment.NewLine, Rows.Select(x => string.Join(" ", x.Places.Select(p => $"[{x.Number}.{p.Number}]"))))}";
        }
        public void AddPerformance(Performance performance)
        {
            
            Performances.Add(performance);
            performance.Hall = this;
        }
    }
}
