using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecordTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Student std1 = new Student()
            //{
            //    stdName = "Hamza",
            //    stdEmail = "hamza@gmail.com"
            //};

            //Console.WriteLine(std1.stdName);
            //Console.WriteLine("--------------");
            //Console.WriteLine(std1.stdEmail);


            //Student std2 = new Student()
            //{
            //    stdName = "Hamza",
            //    stdEmail = "hamza@gmail.com"
            //};

            //Console.WriteLine(std2.stdName);
            //Console.WriteLine("--------------");
            //Console.WriteLine(std2.stdEmail);


            //Console.WriteLine(std1 == std2);

            int[] marks = new int[2];

            //try
            //{
            //    marks[0] = 85;
            //    marks[1] = 99;
            //    marks[2] = 100;
            //    marks[3] = 35;
            //}
            //catch(Exception e) {
            //    Console.WriteLine("Error ye ha {0}",e.Message);
            //}


            /*Console.WriteLine("Enter your number 1");
              int num1 = int.Parse(Console.ReadLine());

              Console.WriteLine("Enter your number 2");
              int num2 = int.Parse(Console.ReadLine());

              try
              {
                  Console.WriteLine(num1 % num2);
              }
              catch (Exception ex) {
                  Console.WriteLine(ex.Message);
              }finally{
                Console.WriteLine("har haal meen chaly ga")
            }
            */

            for (int i = 5; i > 0; i++) {
                    Console.WriteLine(i);
            }

  Console.ReadKey();



}
}
}
