using System;
using _016_AccessibilityModifiers.Extras.ShapeExampleClassLibrary;

namespace _017_PublicAccessibilityModifier.Extras.ShapeExampleProgram
{
    class ShapeExampleApp
    {
        public void Run()
        {
            Circle circle = new Circle();
            circle.SetCircleRadius(5);
            double radius = circle.GetCircleRadius();
            double area = circle.CalculateCircleArea();
            double circumference = circle.CalculateCircleCircumference();
            Console.WriteLine("Shape: Circle\nRadius: " + radius + "\nArea: " + area + "\nCircumference: " + circumference);

            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(4);
            rectangle.SetHeight(3);
            double width = rectangle.GetWidth();
            double height = rectangle.GetHeight();
            area = rectangle.CalculateArea();
            circumference = rectangle.CalculateCircumference();
            Console.WriteLine("Shape: Rectangle\nWidth: " + width + "\nHeight: " + height + "\nArea: " + area + "\nCircumference: " + circumference);

            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.SetWidth(8);
            rightTriangle.SetHeight(6);
            width = rightTriangle.GetWidth();
            height = rightTriangle.GetHeight();
            area = rightTriangle.CalculateArea();
            circumference = rightTriangle.CalculateCircumference();
            Console.WriteLine("Shape: Right Triangle\nWidth: " + width + "\nHeight: " + height + "\nArea: " + area + "\nCircumference: " + circumference);
        }
    }
}
