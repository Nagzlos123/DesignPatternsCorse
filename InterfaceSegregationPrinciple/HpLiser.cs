using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class HpLiser : IPrinter, IFaxContent, IScan
    {
        public void Fax(string content)
        {
            Console.WriteLine("Hp print fax");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("Hp print color");
        }

        public void PrintGray(string content)
        {
            Console.WriteLine("Hp print gray");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Hp print scan");
        }
    }
}
