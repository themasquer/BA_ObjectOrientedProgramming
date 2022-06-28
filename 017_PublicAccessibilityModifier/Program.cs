using _016_AccessibilityModifiers; // *
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _017_PublicAccessibilityModifier.Extras.ShapeExampleProgram;

namespace _017_PublicAccessibilityModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(); // * yukarıya ve projeye referans ekleyerek erişebiliyoruz.
            vehicle.id1_public = 1;
            vehicle.Id1_public = 1;
            vehicle.Drive();
            Console.WriteLine(vehicle.Id1_public);

            #region Shape Example Program (with Class Library)
            ShapeExampleApp shapeExampleApp = new ShapeExampleApp();
            shapeExampleApp.Run();
            #endregion

            Console.ReadLine();
        }
    }
}
