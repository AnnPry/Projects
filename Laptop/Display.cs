using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    class Display
    {
        public string Matrix { get; set; }
        public string ScreenFormat { get; set; }
        public string DisplayResolution{ get; set; }
        public Display(string matrix, string screen, string resolution)
        {
            Matrix = matrix;
            ScreenFormat = screen;
            DisplayResolution = resolution;
        }
        public override string ToString()
        {
            return $"Matrix: {Matrix}, Screen format: {ScreenFormat}, Display resolution: {DisplayResolution}";
        }
    }
}
