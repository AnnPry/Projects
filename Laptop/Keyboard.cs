using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    class Keyboard
    {
        public string[] Buttons = new string[3];
        public string K;
        public string E;
        public string Y;
        public Keyboard(string k, string e, string y)
        {
            K = k;
            E = e;
            Y = y;
            Buttons[0] = k;
            Buttons[1] = e;
            Buttons[2] = y;
        }
        public override string ToString()
        {
            return $"Keyboard buttons: {K}, {E}, {Y}";
        }
    }
}
