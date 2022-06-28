using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes.ArabalarProgramlariExample
{
    class ArabalarProgramiV2
    {
        // Problem: Kodu daha kısa ve anlaşılır hale getirmek için ArabalarProgramiV1'deki içeriği buraya kopyalamak zorundayız. Sadece tek bir araba için giriş yapılabiliyor.

        #region Fields
        string programBasligi = "*** Araba Programı V2 ***";
        string marka;
        string model;
        byte kapiSayisi;
        short beygirGucu;
        //bool binekMi; // binek araba ise true, ticari ise false
        ArabaTuruEnum arabaTuru;
        short maksimumHiz;
        byte cekis; 
        double sifirdanYuzeHizlanma;
        double agirlik;
        double motorHacmi;
        #endregion

        #region Methods
        public void Calistir()
        {
            ProgramBasligiGoster();
            ArabaGirisi();
            ArabaGosterimi();
        }

        void ProgramBasligiGoster()
        {
            Console.WriteLine(programBasligi);
        }

        void ArabaGirisi()
        {
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
            TurGirisi();
            Console.Write("Maksimum hız: ");
            maksimumHiz = Convert.ToInt16(Console.ReadLine());
            Console.Write("Çekiş tipi: (Ö: Önden çekiş, A: Arkadan itiş, D: Dört çeker): ");
            string tmpCekis = Console.ReadLine();
            cekis = CekisTipiKontrolu(tmpCekis);
            Console.Write("0 - 100 hızlanma (Saniye): ");
            sifirdanYuzeHizlanma = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ağırlık (Kilogram): ");
            agirlik = Convert.ToDouble(Console.ReadLine());
            Console.Write("Motor hacmi (Santimetreküp): ");
            motorHacmi = Convert.ToDouble(Console.ReadLine());
        }

        //void TurGirisi()
        //{
        //    Console.Write("Binek araba mı? (1: Evet, 2: Hayır): ");
        //    string tmpBinekMi = Console.ReadLine();
        //    binekMi = tmpBinekMi.Equals("1") ? true : false;
        //}

        void TurGirisi()
        {
            Console.Write("Binek araba mı? (1: Evet, 2: Hayır): ");
            int tmpArabaTuru = Convert.ToInt32(Console.ReadLine());
            arabaTuru = (ArabaTuruEnum)tmpArabaTuru;
        }

        byte CekisTipiKontrolu(string cekis) // 1: önden çekişli, 2: arkadan itişli, 3: dört çeker
        {
            byte sonuc;
            if (cekis.ToUpper() == "Ö")
                sonuc = 1;
            else if (cekis.ToUpper() == "A")
                sonuc = 2;
            else if (cekis.ToUpper() == "D")
                sonuc = 3;
            else
                sonuc = 0;
            return sonuc;
        }

        string CekisTipiKontrolu(byte cekis) // 1: önden çekişli, 2: arkadan itişli, 3: dört çeker
        {
            string sonuc;
            switch (cekis)
            {
                case 1:
                    sonuc = "Önden çekişli";
                    break;
                case 2:
                    sonuc = "Arkadan itişli";
                    break;
                case 3:
                    sonuc = "Dört çeker";
                    break;
                default:
                    sonuc = "";
                    break;
            }
            return sonuc;
        }

        void ArabaGosterimi()
        {
            Console.WriteLine("*** Giriş Yapılan Araba ***");
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Kapı sayısı: " + kapiSayisi);
            Console.WriteLine("Beygir gücü: " + beygirGucu);
            TurGosterimi();
            Console.WriteLine("Maksimum hız: " + maksimumHiz);
            string cekisTipi = CekisTipiKontrolu(cekis);
            Console.WriteLine("Çekiş tipi: " + cekisTipi);
            Console.WriteLine("0 - 100 hızlanma (Saniye): " + sifirdanYuzeHizlanma);
            Console.WriteLine("Ağırlık (Kilogram): " + agirlik);
            Console.WriteLine("Motor hacmi (Santimetreküp): " + motorHacmi);
        }

        //void TurGosterimi()
        //{
        //    string turu = "Ticari";
        //    if (binekMi)
        //        turu = "Binek";
        //    Console.WriteLine("Türü: " + turu);
        //}

        void TurGosterimi()
        {
            Console.WriteLine("Türü: " + arabaTuru.ToString());
        }
        #endregion
    }

    #region Enums
    enum ArabaTuruEnum
    {
        Binek = 1,
        Ticari = 2
    }
    #endregion
}
