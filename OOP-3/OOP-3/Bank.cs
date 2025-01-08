using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    abstract class Bank
    {
        private int accountBalance;

        public abstract void checkBalance();
    }

    class Transaction : Bank {
        public override void checkBalance() {
            Console.WriteLine("The current balace is 15,0000");
        }
    }

    class Cheque : Bank {
        public override void checkBalance() {
            Console.WriteLine("The current balace is 1,0000");
        }
    }
}
