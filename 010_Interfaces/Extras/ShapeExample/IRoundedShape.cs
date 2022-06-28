using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Extras.ShapeExample
{
    interface IRoundedShape
    {
        double Radius { get; set; }
        bool IsPIthree { get; set; }

        double CalculateArea();
        double CalculateCircumference();
    }
}
