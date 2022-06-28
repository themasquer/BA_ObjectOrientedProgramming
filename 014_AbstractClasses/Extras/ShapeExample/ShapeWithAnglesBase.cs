using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_AbstractClasses.Extras.ShapeExample
{
    abstract class ShapeWithAnglesBase
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculateCircumference();
    }
}
