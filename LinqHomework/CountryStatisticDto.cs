using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomework
{
    class CountryStatisticDto
    {
        public string Country { get; set; }
        public int Members { get; set; }
        public List<User> Employees { get; set; }
        public override string ToString()
        {
            var result = $"{Country} {Members}";
            foreach (var item in Employees)
            {
                result += $"{Environment.NewLine}{item.ToString()}";
            }
            return result;
        }
    }
}
