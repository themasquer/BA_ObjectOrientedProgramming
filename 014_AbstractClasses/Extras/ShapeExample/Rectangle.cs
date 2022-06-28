using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_AbstractClasses.Extras.ShapeExample
{
    class Rectangle : ShapeWithAnglesBase
    {
        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculateCircumference()
        {
            return 2 * (Width + Height);
        }
    }
}
