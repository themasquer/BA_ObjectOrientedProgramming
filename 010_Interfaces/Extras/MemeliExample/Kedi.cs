using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Extras.MemeliExample
{
    class Kedi : IMemeli
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public CinsiyetEnum Cinsiyet { get; set; }

        public void Kos()
        {
            Console.WriteLine("{0} ({1}, {2}) kedi koşar.", Ad, Yas, Cinsiyet);
        }

        public void Uyu()
        {
            Console.WriteLine("{0} ({1}, {2}) kedi uyur.", Ad, Yas, Cinsiyet);
        }

        public void Ye()
        {
            Console.WriteLine("{0} ({1}, {2}) kedi yer.", Ad, Yas, Cinsiyet);
        }
    }
}
