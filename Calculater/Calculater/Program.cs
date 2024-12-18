using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ----- Calculater ----- ");

            Console.Write("Enter your number 1 :");
            int number1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter your number 2 :");
            int number2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("The Result is : ");
            Console.Write(number1 + number2);
            Console.ReadKey();
        }
    }
}
