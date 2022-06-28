using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes.ZarExample
{
    class Zar
    {
        int _sayi;

        public void ZarAt(Random random) // random objesini bir kere oluşturup aynı random objesini kullanabilmek için parametre olarak gönderiyoruz.
        {
            if (random == null)
            {
                _sayi = 0;
            }
            else
            {
                int randomSayi = random.Next(1, 7);
                _sayi = randomSayi;
            }
        }

        public int ZariSayisiniGetir()
        {
            return _sayi;
        }
    }
}
