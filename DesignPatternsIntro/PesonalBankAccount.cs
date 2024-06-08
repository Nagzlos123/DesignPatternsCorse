using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsIntro
{
    public class PesonalBankAccount : BankAccount
    {
        public void RequstPersonalLoan()
        {
            Console.WriteLine("Regusting loan ... ");
        }

        public override void MakeWithdrawal(float amount)
        {
            Console.WriteLine("Personal bank account withdrawal");

            if (amount < 0)
            {
                throw new Exception("Amount must be positive numper");
            }

            if (balance - amount < 0 )
            {
                throw new Exception("Personal bank account can't go in debt");
            }

            balance -= amount;
        }
    }
}
