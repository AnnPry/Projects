using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Engine
    {
        public string Version { get; set; }
        public long Code { get; set; }
        public float Capacity { get; set; }

        public Engine(string version, long code, float capacity)
        {
            Version = version;
            Code = code;
            Capacity = capacity;
        }

        public override string ToString()
        {
            return $"Version: {Version}, Code: {Code}, Capacity: {Capacity}L";
        }
    }
}
