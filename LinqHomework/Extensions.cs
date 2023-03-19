using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomework
{
    static class Extensions
    {
        public static void Display<T>(this IEnumerable<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }           
        }
    }
}
