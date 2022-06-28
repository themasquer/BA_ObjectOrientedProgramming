using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes.ArabalarProgramlariExample
{
    // Problem: Kod çok uzun ve karışık.
    class ArabalarProgramiV1
    {
        public void Calistir()
        {
            string marka;
            string model;
            byte kapiSayisi;
            short beygirGucu;
            bool binekMi; // binek araba ise true, ticari ise false
            short maksimumHiz;
            byte cekis; // 1: önden çekişli, 2: arkadan itişli, 3: dört çeker
            double sifirdanYuzeHizlanma;
            double agirlik;
            double motorHacmi;
            Console.WriteLine("*** Araba Programı V1 ***");
            Console.WriteLine("*** Araba Giriş ***");
            Console.Write("Marka: ");
            marka = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Kapı sayısı: ");
            string tmpKapiSayisi = Console.ReadLine();
            kapiSayisi = Convert.ToByte(tmpKapiSayisi);
            Console.Write("Beygir gücü: ");
            beygirGucu = Convert.ToInt16(Console.ReadLine());
            Console.Write("Binek araba mı? (1: Evet, 2: Hayır): ");
            string tmpBinekMi = Console.ReadLine();
            binekMi = tmpBinekMi.Equals("1") ? true : false;
            Console.Write("Maksimum hız: ");
            maksimumHiz = Convert.ToInt16(Console.ReadLine());
            Console.Write("Çekiş tipi: (Ö: Önden çekiş, A: Arkadan itiş, D: Dört çeker): ");
            string tmpCekis = Console.ReadLine();
            if (tmpCekis.ToUpper() == "Ö")
                cekis = 1;
            else if (tmpCekis.ToUpper() == "A")
                cekis = 2;
            else if (tmpCekis.ToUpper() == "D")
                cekis = 3;
            else
                cekis = 0;
            Console.Write("0 - 100 hızlanma (Saniye): ");
            sifirdanYuzeHizlanma = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ağırlık (Kilogram): ");
            agirlik = Convert.ToDouble(Console.ReadLine());
            Console.Write("Motor hacmi (Santimetreküp): ");
            motorHacmi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*** Giriş Yapılan Araba ***");
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Kapı sayısı: " + kapiSayisi);
            Console.WriteLine("Beygir gücü: " + beygirGucu);
            string turu = "Ticari";
            if (binekMi)
                turu = "Binek";
            Console.WriteLine("Türü: " + turu);
            Console.WriteLine("Maksimum hız: " + maksimumHiz);
            string cekisTipi;
            switch (cekis)
            {
                case 1: 
                    cekisTipi = "Önden çekişli";
                    break;
                case 2:
                    cekisTipi = "Arkadan itişli";
                    break;
                case 3:
                    cekisTipi = "Dört çeker";
                    break;
                default:
                    cekisTipi = "";
                    break;
            }
            Console.WriteLine("Çekiş tipi: " + cekisTipi);
            Console.WriteLine("0 - 100 hızlanma (Saniye): " + sifirdanYuzeHizlanma);
            Console.WriteLine("Ağırlık (Kilogram): " + agirlik);
            Console.WriteLine("Motor hacmi (Santimetreküp): " + motorHacmi);
        }
    }
}
