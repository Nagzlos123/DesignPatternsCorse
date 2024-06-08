using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsIntro
{
    class Person
    {
        public string FirstName { get; set; }

        public Person(string name)
        {
            FirstName = name;
        }

        public void SayHi()
        {
            Console.WriteLine($"Hello my name is {FirstName}");
        }
    }
}
