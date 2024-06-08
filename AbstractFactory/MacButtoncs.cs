using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacButtoncs : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Handle Mac click event");
        }

        public void Render()
        {
            Console.WriteLine("Render Mac button");
        }
    }
}
