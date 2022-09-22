using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Car
    {
        public int Year { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public Engine CarEngine { get; set; }
        public Wheels CarWheels { get; set; }
        public Glass CarGlass { get; set; }

        public Car(int year, string brand, string model, Engine engine, Wheels wheels, Glass glass)
        {
            Year = year;
            Brand = brand;
            Model = model;
            CarEngine = engine;
            CarWheels = wheels;
            CarGlass = glass;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} {Year} ({CarEngine}) ({CarWheels}) ({CarGlass})";
        }
    }
}
