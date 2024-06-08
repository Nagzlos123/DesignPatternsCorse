using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Rectangle : Shape
    {
        public override Shape Clone()
        {
            // Shallow Clone
            //return (Rectangle)this.MemberwiseClone(); 

            // Deep Clone
            Rectangle cloneBase = (Rectangle)this.MemberwiseClone();

            cloneBase.Border = new Border()
            {
                Color = Border.Color,
                Size = Border.Size
            };

            return cloneBase;
        }

        public override void Render()
        {
            Console.WriteLine("Rendering rectangle");
        }
    }
}
