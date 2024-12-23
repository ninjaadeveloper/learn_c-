using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello from 11B students.");

            if (2 > 5)
             {
                 Console.WriteLine("2 is greater than 5");
             }


            /*if (10 > 15)
                {
                    Console.WriteLine("10 is greater than 15");
                }
                else {
                    Console.WriteLine("10 is less than 15");
                }*/


            /*Console.WriteLine("Please enter your username :");
               string username = Console.ReadLine();

               Console.WriteLine("Please enter your password :");
               int password = Int16.Parse(Console.ReadLine());


               if (username == "admin" && password == 1234)
               {
                   Console.WriteLine("Login hugya");
               }
               else {
                   Console.WriteLine("Login nahii hua");
               }
               */
            /*
                        int percentage = 10;


                        if (percentage >= 90)
                        {
                            Console.WriteLine("A+");
                        }
                        else if (percentage >= 80)
                        {
                            Console.WriteLine("A");
                        }
                        else if (percentage >= 70)
                        {
                            Console.WriteLine("B");
                        }
                        else if (percentage >= 60)
                        {
                            Console.WriteLine("C");
                        }
                        else if (percentage >= 50)
                        {
                            Console.WriteLine("D");
                        }
                        else if (percentage >= 40)
                        {
                            Console.WriteLine("E");
                        }
                        else if (percentage >= 30)
                        {
                            Console.WriteLine("Fail");
                        }
                        else {
                            Console.WriteLine("undefined grade");
                        }

                        int totalStudents = 20;
                        int presentStudents = 9;

                        if (totalStudents >= 18)
                        {

                            if (presentStudents >= 15)
                            {
                                Console.WriteLine("Lab 213");
                            }
                            else
                            {
                                Console.WriteLine("Lab 210");
                            }

                        }
                        else {
                            Console.WriteLine("Lab 207");
                        }
            */


            string fav_dish = "Tandoori Karahi";

            switch (fav_dish) {
                case "Chicken Karahi":
                    Console.WriteLine("Chicken Karahi is my fav dish");
                    break;
                case "Tandoori Karahi":
                    Console.WriteLine("Tandoori Karahi is my fav dish");
                    break;
                case "Biryani":
                    Console.WriteLine("Biryani is my fav dish");
                    break;
                default:
                    Console.WriteLine("Everything is my fav_dish");
                    break;
            }

            Console.ReadKey();
        }
    }
}
