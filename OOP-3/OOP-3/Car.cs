using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Car
    {
        public string company; 
        public string model;

        public void getRace() {
            Console.WriteLine("Car is fast as you can");
        }

        public void getRace(string carName)
        {
            Console.WriteLine("{0} is fast as you can", carName);
        }

    }
}
