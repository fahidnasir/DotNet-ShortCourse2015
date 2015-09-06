using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission03.Task1
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public string HolderName { get; set; }
        public string Type { get; set; }
        public int Balance { get; set; }

        public abstract void Deposit(int amount);
        public abstract void Withdraw(int amount);

        public override string ToString()
        {
            string result = string.Format("Account No: {0}\nAccount Type: {1}\nAccount Holder Name: {2}\nCurrent Balance: {3}", AccountNumber, Type, HolderName, Balance);
            return result;
        }
    }
}
