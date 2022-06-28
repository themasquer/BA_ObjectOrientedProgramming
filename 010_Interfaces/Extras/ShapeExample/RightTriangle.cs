using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Extras.ShapeExample
{
    class RightTriangle : IShapeWithAngles
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height / 2;
        }

        public double CalculateCircumference()
        {
            double hypotenuse = Math.Sqrt((Width * Width) + Math.Pow(Height, 2));
            return hypotenuse + Width + Height;
        }
    }
}
