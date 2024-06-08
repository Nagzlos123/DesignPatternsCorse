using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            context.EjectCard();

            context.InsertCard();

            context.InsertPin(2222);

            context.InsertCard();
            context.InsertPin(7777);

            context.WithdrawCash(2000);

            context.InsertCard();

            Console.ReadLine();
        }
    }
}
