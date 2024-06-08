using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsIntro
{
    class CompanyBankAccount : BankAccount
    {
        public void TakeLoan(float amount)
        {

        }


        public override void MakeWithdrawal(float amount)
        {
            Console.WriteLine("Make withdrawal for company bank account");

            if (amount < 0)
            {
                throw new Exception("Amount must be positive numper");
            }

            balance -= amount;
        }
    }
}
