using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class CityDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("City duck is quacking");
        }

        public override void Swim()
        {
            Console.WriteLine("City duck is swimming");
        }
    }
}
