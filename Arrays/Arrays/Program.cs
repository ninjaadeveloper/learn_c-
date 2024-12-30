using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] student_names = { "Shehran", "Hamza", "Jazib", "Suleman" };

            Console.WriteLine(student_names[0]);
            */
            /*
            int[] mynames = new int[2];

            mynames[0] = 25;
            mynames[1] = 50;
            //mynames[2] = 70;

            Console.WriteLine(mynames[1]);
            */
            /*
                        int[] salary = { 25000, 35000, 15000 };

                        Console.WriteLine(salary[1]);
            */


            string[,] students =
             {//main array
              
                {"Ali","Shehran" }, //0
                //0 ,    //1
                { "Huzaifa", "Hammmad" }, //1
                //0 ,          //1
                { "Suleman", "Hamza" } //2
                //0 ,           //1
            };

            Console.WriteLine(students[2,0]);

            Console.ReadKey();
}
}
}
