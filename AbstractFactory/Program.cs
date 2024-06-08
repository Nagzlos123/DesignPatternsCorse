using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            var uiApplicaction = new Application(new WindowsFactory()); // there we choose system Mac or Windows

            uiApplicaction.RenderUI();

            Console.ReadLine();
        }
    }
}
