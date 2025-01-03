using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    //create a class
    class Bird
    {
        public string Color; // property 1
        public string flying; // property 2

        public string Intro() { //create a method
             return "I'm from bird class";
        }

        public string Details(string birdName) {
            return birdName + " is a beautifull bird";
        }
    }

    class student {
        public void StudentDetails(string fname, string lname) {

            Console.WriteLine("Student first name is {0}, and last name is {1}",fname , lname); 

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //create a object for class
            Bird Dove = new Bird(); //object 1

            //Dove.Intro() invoke / call the method
            //Console.WriteLine(Dove.Intro());

            Console.WriteLine(Dove.Details("Dove")); 

            Bird Parrot = new Bird(); //object 1

            Console.WriteLine(Parrot.Details("Mithu"));

            //----Student Calss ----

            student std1 = new student(); // create object

            //passed by position
            //std1.StudentDetails("Jazib", "Salman");

            //passed by name
            std1.StudentDetails(lname: "Salman", fname: "jazib");

            //Passing named argument after positional argument
            std1.StudentDetails(fname: "jazib", "Salman");






            Console.ReadKey();
        }
    }

   
}
