using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    class Ticket
    {
        public int Number { get; set; }              
        public Place Place { get; set; }
        public decimal Price { get; set; }
        public Ticket(int number, Place place, decimal price)
        {
            Number = number;
            Place = place;
            Price = price;
        }

    }
}
