using System;
using System.Collections.Generic;

namespace Laptop
{
    class Program
    {
        static void Main(string[] args)
        {          
            var arr = new Keyboard("q","w","e");
            Console.WriteLine($"List: {arr}");

            arr.AddElements("a", "z", "m");
            Console.WriteLine($"Add list elements: {arr}");

            arr.AddElement("k");
            Console.WriteLine($"Add list element: {arr}");

            //list.RemoveListElement("w");
            Console.WriteLine($"Remove list element: {arr.RemoveElement("w")}");

            //Keyboard butt = new Keyboard("k", "e", "y", "q", "w");
            //Console.WriteLine(butt);

            //butt.AddElement("qwa");
            //Console.WriteLine($"Add element:{string.Join(", ", butt.Buttons)}");

            //butt.RemoveElement("y");
            //Console.WriteLine($"Remove element:{string.Join(", ", butt.Buttons)}");
         
            var list = new Keyboard2("q", "w", "e");
            Console.WriteLine($"List: {list}");

            list.AddListElements("a", "z", "m");
            Console.WriteLine($"Add list elements: {list}");

            list.AddListElement("k");
            Console.WriteLine($"Add list element: {list}");

            //list.RemoveListElement("w");
            Console.WriteLine($"Remove list element: {list.RemoveListElement("w")}");


            //Keyboard2 butt2 = new Keyboard2();        
            //Console.WriteLine(butt2);

            //butt2.Buttons2 = Keyboard2.AddListElement("qwa", butt2.Buttons2);
            //Console.WriteLine($"Add list element:{string.Join(", ", butt2.Buttons2)}");

            //butt2.Buttons2 = Keyboard2.RemoveListElement("y", butt2.Buttons2);
            //Console.WriteLine($"Remove list element:{string.Join(", ", butt2.Buttons2)}");


            //Display disp = new Display("TN", "16:9", "1366 * 768 (HD)");         

            //Camera camr = new Camera("f","CCD","available");

            //Laptop lap = new Laptop(butt, disp, camr);
            //Console.WriteLine(lap);
        }
    }
}
