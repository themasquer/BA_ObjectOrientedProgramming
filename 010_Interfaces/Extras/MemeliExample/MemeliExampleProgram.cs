using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Extras.MemeliExample
{
    class MemeliExampleProgram
    {
        public void Run()
        {
            Insan insanSomut = new Insan()
            {
                Ad = "Çağıl",
                Cinsiyet = CinsiyetEnum.Erkek,
                Yas = 40
            };
            insanSomut.Kos();
            insanSomut.Ye();
            insanSomut.Uyu();

            IMemeli insanSoyut = new Insan();
            insanSoyut.Ad = "Ali";
            insanSoyut.Yas = 25;
            insanSoyut.Cinsiyet = CinsiyetEnum.Erkek;
            insanSoyut.Kos();
            insanSoyut.Ye();
            insanSoyut.Uyu();

            IMemeli[] aileSoyut = new IMemeli[3];
            aileSoyut[0] = new Insan();
            aileSoyut[0].Ad = "Çağıl";
            aileSoyut[0].Yas = 40;
            aileSoyut[0].Cinsiyet = CinsiyetEnum.Erkek;
            aileSoyut[1] = new Kopek()
            {
                Ad = "Leo",
                Cinsiyet = CinsiyetEnum.Erkek,
                Yas = 7
            };
            aileSoyut[2] = new Kedi()
            {
                Ad = "Angel",
                Cinsiyet = CinsiyetEnum.Dişi,
                Yas = 15
            };
            foreach (IMemeli uyeSoyut in aileSoyut)
            {
                uyeSoyut.Uyu();
            }

            Insan zeynepSomut = new Insan() // insanSomut tipi: Insan
            {
                Ad = "Zeynep",
                Yas = 30,
                Cinsiyet = CinsiyetEnum.Dişi
            };
            zeynepSomut.Konus();

            IMemeli zeynepSoyut = new Insan()
            {
                Ad = "Zeynep",
                Yas = 30,
                Cinsiyet = CinsiyetEnum.Dişi
            };
            //zeynepSoyut.Konus(); IMemeli içinde Konus() method tanımı olmadığından çağrılamaz!
            ((Insan)zeynepSoyut).Konus(); // casting
            (zeynepSoyut as Insan).Konus(); // casting

            //Console.ReadLine();
        }
    }
}
