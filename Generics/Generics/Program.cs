using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> myGenerics = new GenericClass<string>("Hamza");
            myGenerics.Display();
            Console.WriteLine("------------------------");

            GenericClass<int> myGenerics2 = new GenericClass<int>(20);
            myGenerics2.Display();

            Console.ReadKey();



        }



        public class GenericClass<T> {
            private  T data;
            public GenericClass(T Value) {
              this.data = Value;
            }
        public void Display() {
            Console.WriteLine("Value is {0}",data);
        }
        
        }
    }
}
