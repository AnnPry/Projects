using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    class KeyboardDictionary
    {
        public Dictionary<string, List<string>> ButtonGroups { get; set; }

        public KeyboardDictionary(params string[] intialButtons)
        {
            ButtonGroups = new Dictionary<string, List<string>>
            {
                {"Special", new List<string>(intialButtons)},
                {"Number", new List<string>(intialButtons)},
                {"Symbol", new List<string>(intialButtons)},
            };
        }

        public void AddElement(string butt)
        {          
            if(butt.Length > 1)
            {
                ButtonGroups["Special"].Add(butt);
            }
            else if(butt.Length == 1 && int.TryParse(butt, out int i) == false)
            {
                ButtonGroups["Symbol"].Add(butt);
            }
            else
            {
                ButtonGroups["Number"].Add(butt);
            }

            // if butt > 1 letter => Special (Esc, Enter, Ctrl, etc.)
            // if butt = 1 letter & is number => Number
            // else Symbol
        }
        public void AddElements(params string[] butts)
        {
            for (int i = 0; i < butts.Length; i++)
            {
                if (butts[i].Length > 1)
                {
                    ButtonGroups["Special"].Add(butts[i]);
                }
                else if (butts[i].Length == 1 && int.TryParse(butts[i], out int j) == false)
                {
                    ButtonGroups["Symbol"].Add(butts[i]);
                }
                else
                {
                    ButtonGroups["Number"].Add(butts[i]);
                }
            }
        }
        public bool RemoveElement(string butt)
        {
            if (butt.Length > 1)
            {
                return ButtonGroups["Special"].Remove(butt);
            }
            else if (butt.Length == 1 && int.TryParse(butt, out int i) == false)
            {
                return ButtonGroups["Symbol"].Remove(butt);
            } 
            else
            {
                return ButtonGroups["Number"].Remove(butt);
            }
            //return false;                      
        }
        public override string ToString()
        {
            List<string> buttons = new List<string>();
            foreach(var group in ButtonGroups)
            {
                buttons.AddRange(group.Value);
            }
            return $"{string.Join(", ", buttons)}";
        }
    }
}
