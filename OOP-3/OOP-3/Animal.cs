using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Animal
    {
        public virtual void sound() {
            Console.WriteLine("The animals sounds are different");
        }
    }

    class Wolf : Animal  {
        public override void sound()
        {
            Console.WriteLine("The sound of wolf : Ooo Ooo");
        }
    }

    class Cat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("The sound of Cat : Meaon Meaon");
        }
    }

    class Goat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("The sound of Goat : Meen Meen");
        }
    }

}
