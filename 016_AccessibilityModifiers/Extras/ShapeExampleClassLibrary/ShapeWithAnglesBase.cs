namespace _016_AccessibilityModifiers.Extras.ShapeExampleClassLibrary
{
    public abstract class ShapeWithAnglesBase
    {
        //public double Width { get; set; }
        //public double Height { get; set; }
        /*  Özellikleri normalde bu şekilde tanımlayıp kullanacaktık,
            ancak bu örnekte amaç Accessibility Modifier'ları kullanmak olduğu için
            özelliklerin esasında yaptığı get ve set işlemlerini method olarak yazıyoruz.
        */

        /*  Least privilege: Program geliştirirken minimum ihtiyaçlarımıza göre geliştirmeliyiz.
            Örneğin bir değişkeni en önce private olarak tanımlamalıyım, eğer ihtiyacımı karşılamıyorsa 
            protected olarak değiştirmeliyim. Eğer bu da ihtiyacımı karşılamıyorsa 
            en son public (veya internal) olarak tanımlamalıyım.
        */
        /* İhtiyaç öncelik sıralaması: private -> protected -> internal -> public */
        /* internal pek fazla kullanılmaz, bunun yerine genelde public kullanıyoruz. */

        protected double _height;
        protected double _width;

        public void SetHeight(double value)
        {
            _height = value;
        }

        public double GetHeight()
        {
            return _height;
        }

        public void SetWidth(double value)
        {
            _width = value;
        }

        public double GetWidth()
        {
            return _width;
        }

        //public virtual double CalculateArea() // dörtgen alan hesabı (default hesap)
        //{
        //    return _width * _height;
        //}

        //public virtual double CalculateCircumference() // dörtgen çevre hesabı (default hesap)
        //{
        //    return 2 * (_width + _height);
        //}

        // Programlamada hiç bir base class ileride farklılaşabilecek bir davranışı default olarak gerçekleştirmemeli, 
        // bunun için sadece method tanımları yapılmalı!

        public abstract double CalculateArea();
        public abstract double CalculateCircumference();
    }
}
