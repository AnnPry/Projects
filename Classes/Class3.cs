using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Class3
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get; set; }
        public Class3(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
            Result = number1 * number2;
        }
    }
}
