using System;
using System.Globalization;

namespace _008_Classes.BilgisayarProgramiExample
{
    class BilgisayarProgrami
    {
        public void Calistir()
        {
            CultureInfo culture = new CultureInfo("tr");
            string dateFormat = "dd.MM.yyyy";
            Bilgisayar bilgisayar = new Bilgisayar()
            {
                Id = 1,
                Marka = "ASUS",
                Model = "ROG",
                Tipi = BilgisayarTipi.Dizüstü,
                GHz = 3.33,
                Hafiza = 32,
                EkranBoyutu = 27,
                SuSogutmaliMi = true,
                UretimTarihi = new DateTime(2020, 5, 19)
            };
            Console.WriteLine("*** Bilgisayar Bilgileri ***");
            Console.WriteLine("Id: " + bilgisayar.Id);
            Console.WriteLine("Marka: " + bilgisayar.Marka);
            Console.WriteLine("Model: " + bilgisayar.Model);
            Console.WriteLine("Tipi: " + bilgisayar.Tipi + " (" + (int)bilgisayar.Tipi + ")");
            Console.WriteLine("GHz: " + bilgisayar.GHz.ToString(culture));
            Console.WriteLine("Hafıza: " + bilgisayar.Hafiza + " Gb");
            Console.WriteLine("Ekran: " + bilgisayar.EkranBoyutu.ToString(culture) + " İnç");
            Console.WriteLine("Su Soğutuma: " + (bilgisayar.SuSogutmaliMi ? "Var" : "Yok"));
            Console.WriteLine("Üretim Tarihi: " + bilgisayar.UretimTarihi.ToString(dateFormat));

            //Console.ReadLine();
        }
    }
}
