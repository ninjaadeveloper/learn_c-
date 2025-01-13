using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Employee myemployee = new Employee();

              Console.WriteLine(myemployee.empname); //Shehran

              Console.WriteLine("----------------------");
              //myemployee.EmployeeName = "Jazib";

              Console.WriteLine(myemployee.empname); //Jazib*/

            Student mystudent = new Student();

            mystudent[0] = 500;
            mystudent[1] = 600;
            mystudent[2] = 300;


            mystudent[3] = 250; // cause an error


            Console.WriteLine(mystudent[0]);

            Console.ReadKey();
        }
    }
}
