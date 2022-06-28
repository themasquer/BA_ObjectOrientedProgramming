using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes.DiziClassExample
{
    class Dizi
    {
        string[] _siraliDizi = null;
        public string[] SiraliDizi
        {
            get
            {
                return _siraliDizi;
            }
            set
            {
                _siraliDizi = value;
                Boyut = _siraliDizi.Length;
            }
        }
        public int Boyut { get; set; }

        public string DiziTipiniBelirle()
        {
            bool sayiMi = true;
            int sayi;
            for (int i = 0; i < Boyut && sayiMi; i++)
            {
                if (!Int32.TryParse(SiraliDizi[i], out sayi))
                    sayiMi = false;
            }
            return sayiMi ? "int" : "string";
        }

        public string DiziElemanlariniTopla()
        {
            string diziTipi = DiziTipiniBelirle();
            string sonuc = null;
            int toplam = 0;
            foreach (var eleman in SiraliDizi)
            {
                if (diziTipi == "string")
                {
                    sonuc += eleman;
                }
                else //if (diziTipi == "int")
                {
                    toplam += Convert.ToInt32(eleman);
                }
            }
            if (diziTipi == "int")
                sonuc = toplam.ToString();
            return sonuc;
        }

        public string DiziElemanlarininOrtalamasi() // eğer diziTipi int ise ortalama değeri, string ise dizinin ortasındaki değer döner
        {
            string diziTipi = DiziTipiniBelirle();
            if (diziTipi == "string")
            {
                int ortaIndex = (Boyut - 1) / 2; // double int'e dönüştürülürken hep aşağıya doğru yuvarlanır. (son index - ilk index (0) / 2)
                return SiraliDizi[ortaIndex];
            }
            else //if (diziTipi == "int")
            {
                double toplam = Convert.ToDouble(DiziElemanlariniTopla());
                return (toplam / Boyut).ToString();
            }
        }

        public void DiziElemanlariniGoster()
        {
            foreach (var eleman in SiraliDizi)
            {
                Console.WriteLine(eleman);
            }
        }
    }
}
