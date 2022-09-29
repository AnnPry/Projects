using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    class Camera
    {
        public string Lens { get; set; }
        public string Matrix { get; set; }
        public string OpticalFilter { get; set; }
        public Camera(string lens, string matrix, string filter)
        {
            Lens = lens;
            Matrix = matrix;
            OpticalFilter = filter;
        }
        public override string ToString()
        {
            return $"Lens:{Lens}, Matrix: {Matrix}, Optical filter: {OpticalFilter}";
        }
    }
}
