using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    class Price
    {
        public decimal TicketPrice { get; set; }
        public Row Row { get; set; }
        public Place Place { get; set; }
        public Performance Performance { get; set; }
    }
}
