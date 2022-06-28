using System;

namespace _016_AccessibilityModifiers.Extras.ShapeExampleClassLibrary
{
    public class RightTriangle : ShapeWithAnglesBase
    {
        private double _hypotenuse; // bu alana sadece bu class içerisinde ihtiyacımız olduğundan private tanımlıyoruz

        public override double CalculateArea() // base'de tanımlanmış olan üçgen alan hesap methodunu burada implemente ediyoruz
        {
            return _width * _height / 2;
        }

        public override double CalculateCircumference() // base'de tanımlanmış olan üçgen çevre hesap methodunu burada implemente ediyoruz
        {
            _hypotenuse = Math.Sqrt(Math.Pow(_width, 2) + Math.Pow(_height, 2));
            return _hypotenuse + _width + _height;
        }
    }
}
