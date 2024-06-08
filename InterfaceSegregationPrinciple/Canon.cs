using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Canon : IPrinter, IFaxContent
    {
        public void Fax(string content)
        {
            Console.WriteLine("Canon print fax");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("Canon print color");
        }

        public void PrintGray(string content)
        {
            Console.WriteLine("Canon print gray");
        }
    }
}
