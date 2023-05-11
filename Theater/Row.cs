using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    class Row
    {
        public int Number { get; set; }
        public Hall Hall { get; set; }

        public List<Place> Places { get; set; }
        public Row(int places, int number)
        {
            Number = number;
            Places = new List<Place>();
            for (int i = 0; i < places; i++)
            {
                Places.Add(new Place(i+1));
            }
            
        }
    }
}
