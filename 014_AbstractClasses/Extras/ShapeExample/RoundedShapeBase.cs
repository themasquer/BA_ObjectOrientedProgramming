using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_AbstractClasses.Extras.ShapeExample
{
    abstract class RoundedShapeBase
    {
        public double Radius { get; set; }
        public bool IsPIthree { get; set; } = true;

        public abstract double CalculateArea();
        public abstract double CalculateCircumference();
    }
}
