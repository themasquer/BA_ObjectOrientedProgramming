namespace _016_AccessibilityModifiers.Extras.ShapeExampleClassLibrary
{
    public class Rectangle : ShapeWithAnglesBase
    {
        public override double CalculateArea() // base'de tanımlanmış olan dörtgen alan hesap methodunu burada implemente ediyoruz
        {
            return _width * _height;
        }

        public override double CalculateCircumference() // base'de tanımlanmış olan dörtgen çevre hesap methodunu burada implemente ediyoruz
        {
            return 2 * (_width + _height);
        }
    }
}
