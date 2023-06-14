using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    class Place
    {
        public int Number { get; set; }        
        public Row Row { get; set; }
        public Place(int number, Row row)
        {
            Number = number;
            Row = row;
        }
    }
}
