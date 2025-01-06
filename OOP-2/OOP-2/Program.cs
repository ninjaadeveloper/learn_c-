using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{

    class Animal
    {
        public string animalname; //property 1
        public string animalsound; //property 2
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            // -- Basic Class and object with properties and methods --

            /*Animal myAnimal = new Animal(); //create a object
             myAnimal.animalname = "Cat";  //assign value into property
             Console.WriteLine(myAnimal.animalname);

             Console.WriteLine("----------------------");

             Animal myAnimal2 = new Animal();
             myAnimal2.animalname = "Goat";
             myAnimal2.animalsound = "Meen Meen";

             Console.WriteLine("Animal name is {0} and sounds like {1}", myAnimal2.animalname,myAnimal2.animalsound);
            */

            // -- Inheritance --

            /*Toyota ToyotaFortuner = new Toyota();
                ToyotaFortuner.companyName = "Toyota Paksitan";
                ToyotaFortuner.type = "4 wheeler";
                ToyotaFortuner.model = "Sigma";

                Console.WriteLine("Company name is {0}, vehicle type is {1} and model is {2}", ToyotaFortuner.companyName, ToyotaFortuner.type, ToyotaFortuner.model);

                ToyotaFortuner.intro();
                ToyotaFortuner.intro1();
            */

            // -- Constructor / Destructor --

            //ClassA myClass = new ClassA();
            //ClassA myClass = new ClassA();

            // Method Overloading

            classB newClass = new classB();
            //newClass.students();
            //newClass.students("Zaki");
            newClass.students(4,1);

            Console.ReadKey();
        }
    }

    class Vehicle { //base class / parent class
        public string companyName;
        public string type;

        public void intro() {
            Console.WriteLine("I'm from parent class");
        }

    }

    class Toyota : Vehicle { //dervied class / child class

        public string model;

        public void intro1()
        {
            Console.WriteLine("I'm from child class");
        }

    }

    class ClassA {

        public ClassA() { //create a constructor
            Console.WriteLine("I'm form class A and calling from Constructor");
        }

        public ClassA(string myname) //differnet siganture 
        { //create a constructor
            Console.WriteLine("I'm {0}", myname);
        }

        ~ClassA() {
            Console.WriteLine("Thank you");
        }
    }

    class classB {

        public void students() {
            Console.WriteLine("Students are v.good");
        }

        public void students(string stdName)
        {
            Console.WriteLine("{0} is a v.good student.",stdName);
        }

        public void students(int count1, int count2)
        {
            int result = count1 + count2;
            Console.WriteLine("Student count is {0}", result);
        }

    }

}
