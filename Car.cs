using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Car
    {
        public float speed;
        public string color;
        public string model;

        public void print()
        {
            Console.WriteLine(speed);
            Console.WriteLine(color);
            Console.WriteLine(model);
        }
        
    }
}

