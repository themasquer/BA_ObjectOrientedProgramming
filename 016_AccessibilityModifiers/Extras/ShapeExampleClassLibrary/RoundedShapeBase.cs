using System;

namespace _016_AccessibilityModifiers.Extras.ShapeExampleClassLibrary
{
    public abstract class RoundedShapeBase
    {
        //public double Radius { get; set; }
        /* Özellikleri normalde bu şekilde tanımlayıp kullanacaktık,
           ancak bu örnekte amaç Accessibility Modifier'ları kullanmak olduğu için
           özelliklerin esasında yaptığı get ve set işlemlerini method olarak yazıyoruz.
        */

        private double _radius;

        protected void SetRadius(double value)
        {
            _radius = value;
        }

        protected double GetRadius()
        {
            return _radius;
        }

        protected double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        protected double CalculateCircumference()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
