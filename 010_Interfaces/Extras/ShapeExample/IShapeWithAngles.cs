using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Extras.ShapeExample
{
    interface IShapeWithAngles
    {
        double Width { get; set; }
        double Height { get; set; }

        double CalculateArea();
        double CalculateCircumference();
    }
}
