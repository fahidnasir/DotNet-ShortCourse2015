using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission03.Task1
{
    public class SavingAccount : Account
    {
        public SavingAccount()
        {
            this.Type = "Saving";
        }
        public SavingAccount(string account, string holder, int am):this()
        {
            this.AccountNumber = account;
            this.HolderName = holder;
            this.Balance = am;
        }

        public override void Deposit(int amount)
        {
            Balance = Balance + amount;
        }

        public override void Withdraw(int amount)
        {
            if (Balance > amount && (Balance - amount) > 2000)
            {
                Balance = Balance - amount;
            }
        }
    }
}
