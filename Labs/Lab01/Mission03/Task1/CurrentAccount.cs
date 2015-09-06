using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission03.Task1
{
    public class CurrentAccount : Account
    {
        public CurrentAccount()
        {
            base.Type = "Current";
        }

        public override void Deposit(int amount)
        {
            Balance = Balance + amount;
        }

        public override void Withdraw(int amount)
        {
            if (Balance > amount && (Balance - amount) > 1000)
            {
                Balance = Balance - amount;
            }
        }
    }
}
