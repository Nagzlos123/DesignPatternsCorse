using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTextApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void Render (List<Shape> shapes)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Render();
            }
        }
    }
}
