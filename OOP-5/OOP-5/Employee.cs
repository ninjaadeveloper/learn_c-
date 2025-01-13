using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    internal class Employee
    {
       private string _empname = "Shehran";   //field

       public string empname {
            //set {
            //    this.empname = value;
            //}

            get { //read only
                return _empname;
            }
        }
    }
}
