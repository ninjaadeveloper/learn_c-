using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*foreach (var myValues in GetValues()) {
                 Console.WriteLine(myValues);
             }
            */

            foreach (var myNames in getNames()) {

                Console.WriteLine(myNames);
            }


            Console.ReadKey();
        }

        public static IEnumerable<int> GetValues(){

            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;

        }

        public static IEnumerable<string> getNames() {

            yield return "Shehran";
            yield return "Suleman";
            yield return "Zaki";
            yield return "Mudassir";
            yield return "Jazib";
            yield return "Aliyan";
            yield return "Touqeer";
        }

    }
}
