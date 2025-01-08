using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Simple
    {
        public void intro() {
            Console.WriteLine("I'm form class Simple");
        }
    }

    interface Simple1 {
        void bye();
    }

    interface Simple2
    {
        void welcome();
    }

    class A : Simple1, Simple2
    {
        public void bye() {
            Console.WriteLine("This is the method from Simple1 interface");
        }

    public void welcome() {
        Console.WriteLine("This is the method from Simple2 interface");
    }
    }
}
