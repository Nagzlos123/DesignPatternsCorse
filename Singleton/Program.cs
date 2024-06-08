using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            var conf1 = Configuration.GetInstence();
            var conf2 = Configuration.GetInstence();

            if(ReferenceEquals(conf1, conf2))
            {
                Console.WriteLine("Configuration is singleton");
            }

            Console.ReadLine();
        }
    }
}
