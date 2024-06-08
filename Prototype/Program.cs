using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle()
            {
                Radius = 5,
                X = 1,
                Y = 2,
                Border = new Border()
                {
                    Color = "Red",
                    Size = "2px"
                }
            };

            Rectangle r1 = new Rectangle()
            {
                X = 5,
                Y = 5,
                Border = new Border()
                {
                    Color = "Green",
                    Size = "5px"
                }
            };


            // Shallow Clone
            Console.WriteLine("Shallow Clone");
            Circle c2 = (Circle)c1.Clone();

            bool referenceEquals1 = ReferenceEquals(c1, c2);
            Console.WriteLine($"referenceEquals1: {referenceEquals1}");

            bool borderReferenceEquals1 = ReferenceEquals(c1.Border, c2.Border);
            Console.WriteLine($"borderReferenceEquals1: {borderReferenceEquals1}");

            // Deep Clone
            Console.WriteLine("Deep Clone");
            Rectangle r2 = (Rectangle)r1.Clone();

            bool referenceEquals2 = ReferenceEquals(r1, r2);
            Console.WriteLine($"referenceEquals2: {referenceEquals2}");

            bool borderReferenceEquals2 = ReferenceEquals(r1.Border, r2.Border);
            Console.WriteLine($"borderReferenceEquals2: {borderReferenceEquals2}");
            Console.ReadLine();
        }
    }
}
