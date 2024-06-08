using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();

            var circle = shapeFactory.CreateShape(ShapeTypes.Circle);
            circle.Render();

            var triangle = shapeFactory.CreateShape(ShapeTypes.Triangle);
            triangle.Render();

            Console.ReadLine();
        }
    }
}
