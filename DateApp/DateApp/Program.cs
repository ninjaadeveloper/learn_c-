using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to lab 212");

            DateTime DateandTime = DateTime.Now;
            Console.WriteLine("this is short date {0:d}", DateandTime);

            Console.WriteLine("this is long date {0:D}", DateandTime);

            Console.WriteLine("this is full date and short time    {0:f}", DateandTime);

            Console.WriteLine("this is full date and full time    {0:F}", DateandTime);

            Console.WriteLine("this is general date and time      {0:g}", DateandTime);

            Console .ReadKey();
        }
    }
}
