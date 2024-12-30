using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            for (int a = 1; a <= 10; a++) 
            {
                Console.WriteLine("Hello World :" + a);
            }

            */

            /* int i = 1;
             while (i <= 10) {
                 Console.WriteLine("Hello World from while loop : " + i);
                 i++;
             }
             */
            /*
            do
            {
                Console.WriteLine("Hello World from do-while loop : " + i);
                i++;
            } while (i > 10);
            */
            /*
            Console.WriteLine("Enter your table number: ");
            int table  = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(table + " x " + i + " = " + table * i);
            }
            */

            for (int a = 1; a <= 10; a++)
            {
                
                if (a == 5) {
                    //break;
                    //continue;
                    goto Mylabel;
                }

                Console.WriteLine("Hello World :" + a);
            }


            Mylabel:
            Console.WriteLine("This is the outside form loop");



            Console.ReadKey();

}
}
}
