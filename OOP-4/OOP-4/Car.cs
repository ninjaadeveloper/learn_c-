using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    interface Car
    {
        //public string color;
        //public string model;

        void color();
        void model();


    }

    interface Truck {
        //public int fourWheel;

        void fourWheeler();
    }

    class BYD : Car , Truck {
        public void color() {
            Console.WriteLine("The color is blue");
        }

        public void model()
        {
            Console.WriteLine("The model is seal");
        }

        public void fourWheeler()
        {


            Console.WriteLine("The seal is 4 wheeler");
        }

    }
}
