using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    class Performance
    {
        public string Name { get; set; }
        public Hall Hall { get; set; }
        public List<Ticket> Tickets { get; set; }
        
        public Performance(string name)
        {
            Name = name;
            Tickets = new List<Ticket>();
        }
    }
}
