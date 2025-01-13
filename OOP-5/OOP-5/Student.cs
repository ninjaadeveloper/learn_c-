using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    internal class Student
    {
        private int[] num = new int[3]; //array

        public int this[int index]
        {
            set {

                if (index >= num.Length)
                {
                    Console.WriteLine("Your are gone wrong");
                }
                else
                {
                    num[index] = value;
                }
            }

            get {
                return num[index];
            }
        }



    }
}
