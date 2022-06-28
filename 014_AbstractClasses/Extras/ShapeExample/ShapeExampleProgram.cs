using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_AbstractClasses.Extras.ShapeExample
{
    class ShapeExampleProgram
    {
        public void Run()
        {
            Circle circle = new Circle()
            {
                Radius = 5
            };
            Console.WriteLine("Daire Alan: " + circle.CalculateArea() + ", Daire Çevre: " + circle.CalculateCircumference());
            circle = new Circle()
            {
                Radius = 5,
                IsPIthree = false
            };
            Console.WriteLine("Daire Alan: " + circle.CalculateArea() + ", Daire Çevre: " + circle.CalculateCircumference());

            Rectangle rectangle = new Rectangle()
            {
                Width = 10,
                Height = 5
            };
            Console.WriteLine("Dikdörtgen Alan: " + rectangle.CalculateArea() + ", Dikdörtgen Çevre: " + rectangle.CalculateCircumference());
            rectangle = new Rectangle()
            {
                Width = 10,
                Height = 10
            };
            Console.WriteLine("Kare Alan: " + rectangle.CalculateArea() + ", Kare Çevre: " + rectangle.CalculateCircumference());

            RightTriangle rightTriangle = new RightTriangle()
            {
                Width = 3,
                Height = 4
            };
            Console.WriteLine("Üçgen Alan: " + rightTriangle.CalculateArea() + ", Üçgen Çevre: " + rightTriangle.CalculateCircumference());
        }
    }
}
