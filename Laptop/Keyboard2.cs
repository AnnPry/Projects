using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    class Keyboard2
    {
        public List<string> Buttons2 { get; set; }       
        public Keyboard2(params string[] keys2)
        {
            Buttons2 = new List<string>();
            Buttons2.AddRange(keys2);           
        }      
        public void AddListElement(string butt)
        {
            Buttons2.Add(butt);
        }
        public void AddListElements(params string[] butts)
        {
            Buttons2.AddRange(butts);
        }
        public bool RemoveListElement(string butt)
        {
            return Buttons2.Remove(butt);
        }
        public override string ToString()
        {
            return $"Keyboard buttons: {string.Join(", ", Buttons2)}";
        }
    }
}
