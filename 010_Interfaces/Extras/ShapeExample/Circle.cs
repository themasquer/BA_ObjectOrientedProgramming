using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Extras.ShapeExample
{
    class Circle : IRoundedShape
    {
        public double Radius { get; set; }
        public bool IsPIthree { get; set; } = true;

        public double CalculateArea()
        {
            return IsPIthree ? 3 * Radius * Radius : Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculateCircumference()
        {
            return IsPIthree ? 2 * 3 * Radius : 2 * Math.PI * Radius;
        }
    }
}
