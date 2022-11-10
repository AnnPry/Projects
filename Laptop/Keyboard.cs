using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    class Keyboard
    {
        public string[] Buttons { get; set; }
        public Keyboard(params string[] keys)
        {
            Buttons = keys;
        }        
        public void AddElement(string elem)
        {
            var newButtons = new string[Buttons.Length + 1];

            for (int i = 0; i < Buttons.Length; i++)
            {
                newButtons[i] = Buttons[i];
            }

            newButtons[Buttons.Length] = elem;

            Buttons = newButtons;

            //string[] result = new string[Buttons.Length + 1];
            //for (int i = 0; i < Buttons.Length; i++)
            //{
            //    result[i] = Buttons[i];
            //}
            //result[Buttons.Length] = elem;            
        }
        public void AddElements(params string[] elems)
        {
            var newButtons = new string[Buttons.Length + elems.Length];

            for (int i = 0; i < Buttons.Length; i++)
            {
                newButtons[i] = Buttons[i];
            }

            for (int i = 0; i < elems.Length; i++)
            {
                newButtons[i + Buttons.Length] = elems[i];
            }

            Buttons = newButtons;
        }
        public bool RemoveElement(string elem)
        {
            int valueIndex = -1;
            for (int i = 0; i < Buttons.Length; i++)
            {
                if (Buttons[i] == elem)
                {
                    valueIndex = i;
                    break;
                }
            }

            if(valueIndex == -1)
            {
                return false;
            }

            var newButtons = new string[Buttons.Length - 1];

            for (int i = 0; i < valueIndex; i++)
            {
                newButtons[i] = Buttons[i];
            }

            for (int i = valueIndex; i < Buttons.Length; i++)
            {
                Buttons[i - 1] = Buttons[i];
            }
            
            return true;
            //if (valueIndex != -1)
            //{
            //    string[] result = new string[Buttons.Length - 1];
            //    for (int i = 0; i < valueIndex; i++)
            //    {
            //        result[i] = Buttons[i];
            //    }
            //    for (int i = valueIndex + 1; i < Buttons.Length; i++)
            //    {
            //        result[i - 1] = Buttons[i];
            //    }
            //}

        }
        public override string ToString()
        {
            return $"{string.Join(", ", Buttons)}";
        }
    }
}
