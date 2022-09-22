using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Glass
    {
        public string GlassCoating { get; set; }
        public int Density { get; set; }
        public Glass(string coating, int density)
        {
            GlassCoating = coating;
            Density = density;
        }
        public override string ToString()
        {
            return $"GlassCoating: {GlassCoating}, Density: {Density}kg/m2";
        }
    }
}
