using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_AbstractClasses.Extras.ShapeExample
{
    class Circle : RoundedShapeBase
    {
        public override double CalculateArea()
        {
            return IsPIthree ? 3 * Math.Pow(Radius, 2) : Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculateCircumference()
        {
            return IsPIthree ? 2 * 3 * Radius : 2 * Math.PI * Radius;
        }
    }
}
