using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Bilbo");

            //person.FirstName = "Bilbo";
            Console.WriteLine(person.FirstName);

            IPrinter printer = GetPrinter();

            printer.Print("Some text");


            //PesonalBankAccount bankAccount = new PesonalBankAccount();

            //bankAccount.MakeDeposit(1000);
           // bankAccount.MakeWithdrawal(50);

            //bankAccount.RequstPersonalLoan();
            

            //Console.WriteLine(bankAccount.GetBalance());

            BankAccount bankAccount2 = GetBankAccount();

            bankAccount2.MakeWithdrawal(1100);

            EmailSender emailSender = new EmailSender();

            emailSender.SendEmail("to@gmail.com", "title", "body");

            Console.ReadLine();
        }

        static IPrinter GetPrinter()
        {
            return new Hp();
        }

        static BankAccount GetBankAccount()
        {
            var bankAccount = new PesonalBankAccount();
            bankAccount.MakeDeposit(1000);
            return bankAccount;
        }
    }
}
