using System;
using System.Collections.Generic;

namespace Theater
{
    class Program
    {
        static void Main(string[] args)
        {
            var hall1 = new Hall
            {
                Number = 1

            };
            var hall2 = new Hall
            { 
                Number = 2
            };
            hall1.Rows = new List<Row> 
            {
                new Row{Number = 1}
            };
        }
    }
}
