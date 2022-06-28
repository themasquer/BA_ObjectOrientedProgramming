using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_AbstractClasses.Extras.ShapeExample
{
    class RightTriangle : ShapeWithAnglesBase
    {
        private double _hypotenuse;

        public override double CalculateArea()
        {
            return Width * Height / 2;
        }

        public override double CalculateCircumference()
        {
            _hypotenuse = Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
            return _hypotenuse + Width + Height;
        }
    }
}
