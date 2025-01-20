using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDeligates
{
    public delegate int Calculater(int method1, int method2);
    internal class Program
    {
        

        //method 1
        public int Add(int num1, int num2)
        {

            return (num1 + num2);
        }

        //method 2
        public int Sub(int num1, int num2)
        {

            return (num1 - num2);
        }

        static void Main(string[] args)
        {
            int value1 = 5; //field 1
            int value2 = 10;  //field 2

            Calculater newCalculater = new Calculater(Add);
            Console.WriteLine(value1 + " + " + value2 + " = " +
            newCalculater(value1,value2));
        }
    }
}
       

       



    }
}
