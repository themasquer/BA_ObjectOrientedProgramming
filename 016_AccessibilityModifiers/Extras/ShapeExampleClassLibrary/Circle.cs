namespace _016_AccessibilityModifiers.Extras.ShapeExampleClassLibrary
{
    public class Circle : RoundedShapeBase
    {
        public void SetCircleRadius(double value)
        {
            base.SetRadius(value);
        }

        public double GetCircleRadius()
        {
            return base.GetRadius();
        }

        public double CalculateCircleArea()
        {
            return base.CalculateArea();
        }

        public double CalculateCircleCircumference()
        {
            return base.CalculateCircumference();
        }
    }
}
