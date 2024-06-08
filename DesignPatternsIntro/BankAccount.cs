using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsIntro
{
    public class BankAccount
    {
        protected float balance;

        public string Name { get; set; }

        public void MakeDeposit(float amount)
        {
            if(amount < 0)
            {
                throw new Exception("Amount must be positive numper");
            }

            balance += amount;
        }

        public virtual void MakeWithdrawal(float amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must be positive numper");
            }

            balance -= amount;
        }

        public float GetBalance()
        {
            return balance;
        }
    }
}
