using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class RobberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Robber duck is quacking");
        }

        public override void Swim()
        {
            Console.WriteLine("Robber duck is swimming");
        }
    }
}
