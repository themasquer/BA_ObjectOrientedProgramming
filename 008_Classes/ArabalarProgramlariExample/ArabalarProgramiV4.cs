using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes.ArabalarProgramlariExample
{
    // Problem: ArabalarProgramiV3'teki içeriği buraya kopyalamak zorundayız. Id'ye göre sorgulama tek sefer çalışıyor.

    #region Classes
    class Araba
    {
        #region Properties
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public byte KapiSayisi { get; set; }
        public short BeygirGucu { get; set; }
        public ArabaTurleriEnum ArabaTuru { get; set; }
        public short MaksimumHiz { get; set; }
        public byte Cekis { get; set; }
        public double SifirdanYuzeHizlanma { get; set; }
        public double Agirlik { get; set; }
        public double MotorHacmi { get; set; }
        #endregion
    }

    class ProgramAyarlari
    {
        public string ProgramBasligi { get; set; } = "*** Araba Programı V4 ***";
    }
    #endregion

    #region Enums
    enum ArabaTurleriEnum
    {
        Binek = 1,
        Ticari = 2
    }
    #endregion

    class ArabalarProgramiV4
    {
        ProgramAyarlari programAyarlari = new ProgramAyarlari();
        Araba[] arabalar;

        public void Calistir()
        {
            ProgramBasligiGoster();
            ArabaGirisi();
            ArabaGosterimi();
            IdyeGoreArabaGoster();
        }

        //void ProgramBasligiGoster()
        //{
        //    Console.WriteLine(programBasligi);
        //}

        void ProgramBasligiGoster()
        {
            Console.WriteLine(programAyarlari.ProgramBasligi);
        }

        //void ArabaGirisi()
        //{
        //    Console.WriteLine("*** Araba Giriş ***");
        //    Console.WriteLine("Giriş yapılacak araba sayısı: ");
        //    int arabaSayisi;
        //    int Id;
        //    string araba;
        //    bool girisSayiMi = Int32.TryParse(Console.ReadLine(), out arabaSayisi); // parametre olarak verilen string'i integer'a dönüştürmeye çalışır.
        //    // eğer dönüştürebilirse sonucu out ile belirtilen değişkene atar ve method sonucu true döner.
        //    // dönüştüremezse method sonucu false döner.
        //    if (girisSayiMi && arabaSayisi > 0)
        //    {
        //        Id = 0;
        //        arabalar = new string[arabaSayisi];
        //        while (Id < arabalar.Length)
        //        {
        //            Id++;
        //            araba = ArabaBilgileriniKullanicidanAl(Id);
        //            arabalar[Id - 1] = araba;
        //        }
        //    }
        //}

        void ArabaGirisi()
        {
            Console.WriteLine("*** Araba Giriş ***");
            Console.WriteLine("Giriş yapılacak araba sayısı: ");
            int arabaSayisi;
            int Id;
            Araba araba;
            bool girisSayiMi = Int32.TryParse(Console.ReadLine(), out arabaSayisi); // parametre olarak verilen string'i integer'a dönüştürmeye çalışır.
                                                                                      // eğer dönüştürebilirse sonucu out ile belirtilen değişkene atar ve method sonucu true döner.
                                                                                      // dönüştüremezse method sonucu false döner.
            if (girisSayiMi && arabaSayisi > 0)
            {
                Id = 0;
                arabalar = new Araba[arabaSayisi];
                while (Id < arabalar.Length)
                {
                    Id++;
                    araba = ArabaBilgileriniKullanicidanAl(Id);
                    arabalar[Id - 1] = araba;
                }
            }
        }

        //string ArabaBilgileriniKullanicidanAl(int id)
        //{
        //    Console.Write("Marka: ");
        //    marka = Console.ReadLine();
        //    Console.Write("Model: ");
        //    model = Console.ReadLine();
        //    Console.Write("Kapı sayısı: ");
        //    string tmpKapiSayisi = Console.ReadLine();
        //    kapiSayisi = Convert.ToByte(tmpKapiSayisi);
        //    Console.Write("Beygir gücü: ");
        //    beygirGucu = Convert.ToInt16(Console.ReadLine());
        //    TurGirisi();
        //    Console.Write("Maksimum hız: ");
        //    maksimumHiz = Convert.ToInt16(Console.ReadLine());
        //    Console.Write("Çekiş tipi: (Ö: Önden çekiş, A: Arkadan itiş, D: Dört çeker): ");
        //    string tmpCekis = Console.ReadLine();
        //    cekis = CekisTipiKontrolu(tmpCekis);
        //    Console.Write("0 - 100 hızlanma (Saniye): ");
        //    sifirdanYuzeHizlanma = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Ağırlık (Kilogram): ");
        //    agirlik = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Motor hacmi (Santimetreküp): ");
        //    motorHacmi = Convert.ToDouble(Console.ReadLine());
        //    return "Id: " + id + ", Marka: " + marka + ", Model: " + model + ", Kapı sayısı: " + kapiSayisi + ", Beygir gücü: " + beygirGucu + ", " + TurGosterimi() + ", Maksimum hız: "
        //           + maksimumHiz + ", Çekiş tipi: " + CekisTipiKontrolu(cekis) + ", 0 - 100 hızlanma: " + sifirdanYuzeHizlanma + ", Ağırlık: " + agirlik +
        //           ", Motor hacmi: " + motorHacmi;
        //}

        Araba ArabaBilgileriniKullanicidanAl(int id)
        {
            Araba araba = new Araba();
            araba.Id = id;
            Console.Write("Marka: ");
            string marka = Console.ReadLine();
            araba.Marka = marka;
            Console.Write("Model: ");
            string model = Console.ReadLine();
            araba.Model = model;
            Console.Write("Kapı sayısı: ");
            string tmpKapiSayisi = Console.ReadLine();
            byte kapiSayisi = Convert.ToByte(tmpKapiSayisi);
            araba.KapiSayisi = kapiSayisi;
            Console.Write("Beygir gücü: ");
            short beygirGucu = Convert.ToInt16(Console.ReadLine());
            araba.BeygirGucu = beygirGucu;
            TurGirisi(araba);
            Console.Write("Maksimum hız: ");
            short maksimumHiz = Convert.ToInt16(Console.ReadLine());
            araba.MaksimumHiz = maksimumHiz;
            Console.Write("Çekiş tipi: (Ö: Önden çekiş, A: Arkadan itiş, D: Dört çeker): ");
            string tmpCekis = Console.ReadLine();
            byte cekis = CekisTipiKontrolu(tmpCekis);
            araba.Cekis = cekis;
            Console.Write("0 - 100 hızlanma (Saniye): ");
            double sifirdanYuzeHizlanma = Convert.ToDouble(Console.ReadLine());
            araba.SifirdanYuzeHizlanma = sifirdanYuzeHizlanma;
            Console.Write("Ağırlık (Kilogram): ");
            double agirlik = Convert.ToDouble(Console.ReadLine());
            araba.Agirlik = agirlik;
            Console.Write("Motor hacmi (Santimetreküp): ");
            double motorHacmi = Convert.ToDouble(Console.ReadLine());
            araba.MotorHacmi = motorHacmi;
            return araba;
        }

        //void TurGirisi()
        //{
        //    Console.Write("Binek araba mı? (1: Evet, 2: Hayır): ");
        //    int tmpArabaTuru = Convert.ToInt32(Console.ReadLine());
        //    arabaTuru = (ArabaTuruEnum)tmpArabaTuru;
        //}

        //Araba TurGirisi(Araba araba)
        //{
        //    Console.Write("Binek araba mı? (1: Evet, 2: Hayır): ");
        //    int tmpArabaTuru = Convert.ToInt32(Console.ReadLine());
        //    araba.ArabaTuru = (ArabaTuruEnum)tmpArabaTuru;
        //    return araba;
        //}

        void TurGirisi(Araba araba)
        {
            Console.Write("Binek araba mı? (1: Evet, 2: Hayır): ");
            int tmpArabaTuru = Convert.ToInt32(Console.ReadLine());
            araba.ArabaTuru = (ArabaTurleriEnum)tmpArabaTuru;
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

        //void ArabaGosterimi()
        //{
        //    Console.WriteLine("*** Giriş Yapılan Arabalar ***");
        //    foreach (var araba in arabalar)
        //    {
        //        Console.WriteLine(araba);
        //    }
        //}

        void ArabaGosterimi()
        {
            Console.WriteLine("*** Giriş Yapılan Arabalar ***");
            foreach (var araba in arabalar)
            {
                TekBirArabaGosterimi(araba);
            }
        }

        void TekBirArabaGosterimi(Araba araba)
        {
            if (araba == null)
            {
                Console.WriteLine("Araba bulunamadı!");
            }
            else
            {
                Console.WriteLine("Id: " + araba.Id + ", Marka: " + araba.Marka + ", Model: " + araba.Model +
                                  ", Kapı sayısı: " + araba.KapiSayisi + ", Beygir gücü: " + araba.BeygirGucu +
                                  ", " + TurGosterimi(araba) + ", Maksimum hız: " + araba.MaksimumHiz +
                                  ", Çekiş tipi: " + CekisTipiKontrolu(araba.Cekis) +
                                  ", 0 - 100 hızlanma: " + araba.SifirdanYuzeHizlanma + ", Ağırlık: " + araba.Agirlik +
                                  ", Motor hacmi: " + araba.MotorHacmi);
            }
        }

        string TurGosterimi(Araba araba)
        {
            return "Türü: " + araba.ArabaTuru.ToString();
        }

        //void IdyeGoreArabaGoster()
        //{
        //    Console.WriteLine("*** Araba Sorgulama ***");
        //    Console.Write("Araba Id: ");
        //    string id = Console.ReadLine();
        //    string araba = IdyeGoreArabaGetir(id);
        //    Console.WriteLine(araba);
        //}

        void IdyeGoreArabaGoster()
        {
            Console.WriteLine("*** Araba Sorgulama ***");
            Console.Write("Araba Id: ");
            string id = Console.ReadLine();
            Araba araba = IdyeGoreArabaGetir(id);
            TekBirArabaGosterimi(araba);
        }

        //string IdyeGoreArabaGetir(string id)
        //{
        //    string sonuc = "Araba bulunamadı!";
        //    bool bulundu = false;
        //    for (int i = 0; i < arabalar.Length && !bulundu; i++)
        //    {
        //        if (arabalar[i].Contains("Id: " + id))
        //        {
        //            sonuc = arabalar[i];
        //            bulundu = true;
        //        }
        //    }
        //    return sonuc;
        //}

        Araba IdyeGoreArabaGetir(string id)
        {
            Araba arabaSonucu = null;
            int arabaId = Convert.ToInt32(id);
            bool bulundu = false;
            for (int i = 0; i < arabalar.Length && !bulundu; i++)
            {
                if (arabalar[i].Id == arabaId)
                {
                    arabaSonucu = arabalar[i];
                    bulundu = true;
                }
            }
            return arabaSonucu;
        }
    }
}
