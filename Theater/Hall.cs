using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    class Hall
    {
        public int Number { get; set; }
        public List<Performance> Performances { get; set; }
        public List<Row> Rows { get; set; }
    }
}
