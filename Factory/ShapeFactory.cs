using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ShapeFactory
    {
        public Shape CreateShape(ShapeTypes shapeType)
        {
            switch (shapeType)
            {
                case ShapeTypes.Circle:
                    return new Circle();
                case ShapeTypes.Rectangle:
                    return new Rectangle();
                case ShapeTypes.Triangle:
                    return new Triangle();
                default:
                    throw new Exception($"Shape type {shapeType} is not handled");
            }
        }
    }
}
