using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Engine
    {
        public double Volume { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }

        public void message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
