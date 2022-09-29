using System;

namespace Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            Keyboard butt = new Keyboard("k","e","y");
            //Console.WriteLine(butt);

            Display disp = new Display("TN", "16:9", "1366 * 768 (HD)");
            //Console.WriteLine(disp);

            Camera camr = new Camera("f","CCD","available");
            //Console.WriteLine(disp);

            Laptop lap = new Laptop(butt, disp, camr);
            Console.WriteLine(lap);
        }
    }
}
