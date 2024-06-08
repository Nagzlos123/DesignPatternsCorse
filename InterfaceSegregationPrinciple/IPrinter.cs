using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IPrinter
    {
         void PrintGray(string content);
         void PrintColor(string content);
    }

    public interface IScan
    {
        void Scan(string content);
    }

    public interface IFaxContent
    {
        void Fax(string content);
    }
}
