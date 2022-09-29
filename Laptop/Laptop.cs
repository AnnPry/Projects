using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    class Laptop
    {
        public Keyboard LapKeyboard { get; set; }
        public Display LapDisplay { get; set; }
        public Camera LapCamera { get; set; }

        public Laptop(Keyboard keyboard, Display display, Camera camera)
        {
            LapKeyboard = keyboard;
            LapDisplay = display;
            LapCamera = camera;
        }
        public override string ToString()
        {
            return $"Laptop components: ({LapKeyboard})({LapDisplay})({LapCamera})";
        }
    }
}
