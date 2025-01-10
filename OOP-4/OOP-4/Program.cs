using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User newuser = new User();
            Console.WriteLine(newuser.UserName);

            Console.WriteLine("-------------");

            newuser.UserName = "Hamza";
            Console.WriteLine(newuser.UserName);

            Console.WriteLine("-------------");
            //newuser.Age = 15; //set
            Console.WriteLine(newuser.Age); //get

            Console.WriteLine("-------------");

            BYD newbyd = new BYD();

            //newbyd.

            Console.ReadKey();
        }
    }
}
