using System;
using System.Collections.Generic;

namespace Theater
{
    class Program
    {
        static void Main(string[] args)
        {
            var hall1 = new Hall(4, "Jhuko", 4, 3);
            Console.WriteLine(hall1);
            var hall2 = new Hall(3, "Dvnre", 3, 5);
            Console.WriteLine(hall2);

            //var hall1 = new Hall
            //{
            //    Number = 1            
            //};
            //var hall2 = new Hall
            //{ 
            //    Number = 2
            //};

            //hall1.Rows = new List<Row> 
            //{
            //    new Row{Number = 1, Places = new List<Place>
            //    {
            //      new Place{Number = 1},
            //      new Place{Number = 2},
            //      new Place{Number = 3}
            //    } },
            //    new Row{Number = 2, Places = new List<Place>
            //    {
            //      new Place{Number = 4},
            //      new Place{Number = 5},
            //      new Place{Number = 6}
            //    }},
            //    new Row{Number = 3, Places = new List<Place>
            //    {
            //      new Place{Number = 7},
            //      new Place{Number = 8},
            //      new Place{Number = 9}
            //    }},                             
            //    new Row{Number = 4, Places = new List<Place>
            //    {
            //      new Place{Number = 10},
            //      new Place{Number = 11},
            //      new Place{Number = 12}
            //    }}                             
            //};

            //hall2.Rows = new List<Row>
            //{
            //    new Row{Number = 1, Places = places2},
            //    new Row{Number = 2, Places = places2},
            //    new Row{Number = 3, Places = places2}             
            //};




        }
    }
}
