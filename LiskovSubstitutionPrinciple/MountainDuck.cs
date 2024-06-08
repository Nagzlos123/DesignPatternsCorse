using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class MountainDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Mountain duck is quacking");
        }

        public override void Swim()
        {
            Console.WriteLine("Mountain duck is swimming");
        }
    }
}
