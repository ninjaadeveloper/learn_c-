using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    internal class User
    {
        private String _userName = "Mudasir"; //feild
        private int _age = 20; //feild

        public String UserName { //property
            get
            {
                return _userName;
            }
            set 
            {
                this._userName = value;
            }
        }


        public int Age {
            get {
                return _age;
            }

        }

    }
}
