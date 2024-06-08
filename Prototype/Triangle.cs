using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Triangle : Shape
    {
        public override Shape Clone()
        {
            Triangle cloneBase = (Triangle)this.MemberwiseClone();

            cloneBase.Border = new Border()
            {
                Color = Border.Color,
                Size = Border.Size
            };

            return cloneBase;
        }

        public override void Render()
        {
            Console.WriteLine("Rendering triangle");
        }
    }
}
