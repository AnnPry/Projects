using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Wheels
    {
        public string TiresType { get; set; }
        public double Diameter { get; set; }
        public float Height { get; set; }
        public Wheels(string tires, double diameter, float height)
        {
            TiresType = tires;
            Diameter = diameter;
            Height = height;
        }
        public override string ToString()
        {
            return $"TiresType: {TiresType}, Diameter: R{Diameter}, Height: {Height}";
        }
    }
}
