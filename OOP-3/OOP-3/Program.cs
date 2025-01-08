using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------- Simple Objects ---------
            /* 
                        Car newcar = new Car();
                        newcar.getRace(); // first method
                        Console.WriteLine("-------------");
                        newcar.getRace("Swift"); //second method
            */

            //--------- Method Overriding ---------
            /*
            Animal myAnimal = new Animal(); //animal class object
            myAnimal.sound();
            Console.WriteLine("-------------");
            Wolf mywolf = new Wolf(); //wolf class object
            mywolf.sound();
            Console.WriteLine("-------------");
            Cat mycat = new Cat(); //cat class object
            mycat.sound();
            Console.WriteLine("-------------");
            Goat mygoat = new Goat(); //goat class object
            mygoat.sound();
            */

            //--------- Abstact ---------
            /*
            Transaction newtransaction = new Transaction();
            newtransaction.checkBalance();

            Cheque mycheque = new Cheque();
            mycheque.checkBalance();
            */
            //--------- Interface ---------
            /*
            A newa = new A();
            newa.welcome();
            Console.WriteLine("-------------");
            newa.bye();
            
            */

            //--------- Sealed ---------

            thend newtheend = new thend();
            Console.WriteLine(newtheend.name);

            Console.ReadKey();

        }
    }
}
