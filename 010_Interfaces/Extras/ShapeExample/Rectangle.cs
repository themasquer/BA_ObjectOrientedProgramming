using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Extras.ShapeExample
{
    class Rectangle : IShapeWithAngles
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculateCircumference()
        {
            return 2 * (Width + Height);
        }
    }
}
