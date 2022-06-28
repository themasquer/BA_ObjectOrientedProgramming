using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_ValueAndReferenceTypes
{
    class Program
    {
        // int, bool, double, char gibi primitive tipler değer tipleridir
        // string, array, class, intrerface, abstract, vb. referans tiplerdir

        static void Main(string[] args)
        {
            #region Value Types
            int number1 = 10; // atama değer üzerinden gerçekleşir. number1 10 olur
            int number2 = 20; // number2 20 olur
            number2 = number1; // number2 10 olur
            number1 = 30; // number1 30 olur
            Console.WriteLine("No 2: " + number2 + ", No 1: " + number1); // "No 2: 10, No 1: 30" sonucu çıkacaktır
            #endregion

            #region Reference Types
            string[] cities1 = { "Ankara", "Adana", "Afyon" }; // atama referans üzerinden gerçekleşir. örneğin cities1 adresi 101 olsun
            // bellekte değer olarak array yani { "Ankara", "Adana", "Afyon" } tutulur, bu array'a referans olarak da bir adres yani cities1 değişkeni tutulur
            string[] cities2 = { "Bursa", "Bolu", "Balıkesir" }; // örneğin cities2 adresi 102 olsun
            cities2 = cities1; // atama referans üzerinden gerçekleşecektir yani 102 olan cities2 adresi 101 olacaktır.
                               // cities2'nin 102 olan adresi artık { "Bursa", "Bolu", "Balıkesir" } array'ini refere etmeyecektir.
                               // Garbage Collector adresi tutulmayan nesneleri otomatik olarak bellekten temizleyecektir.
                               // { "Ankara", "Adana", "Afyon" } array'ine artık hem cities1 hem cities2 point etmekte
            cities1[0] = "İstanbul";
            Console.WriteLine("Cities 1'in 0 index'indeki elemanı: " + cities1[0] + ", Cities 2'nin 0 index'indeki elemanı: " + cities2[0]); // sonuçta ikisi de İstanbul olacaktır

            City city1 = new City() { Name = "Ankara" };
            City city2 = new City() { Name = "İstanbul" };
            Console.WriteLine("City 1: " + city1.Name + ", City 2: " + city2.Name);
            city2 = city1; // böyle yaptığımızda new City() { Name = "İstanbul" } bellekte boşa çıkacaktır.
                           // dolayısıyla City city2 = new City() { Name = "İstanbul" }; satırını boş yere çalıştırmış olduk
                           // bu da boş yere performans harcaması anlamına gelir çünkü bir objeyi new'lemek performance cost olarak en pahalı işlerden biridir
                           // city1'i new'lemek yerine sadece City city1; yazabilirdik ve daha sonra referans atama işlemini gerçekleştirebilirdik
            city1.Name = "İzmir";
            Console.WriteLine("City 1: " + city1.Name + ", City 2: " + city2.Name);
            #endregion

            #region Reference Types in Methods 1
            // şehri value type olarak kullanalım:
            string sehir1 = "Ankara";
            Console.WriteLine("Şehir 1: " + sehir1);
            SehriGuncelle(sehir1);
            Console.WriteLine("Şehir 1: " + sehir1);

            // şehri reference type olarak kullanalım:
            City sehir2 = new City()
            {
                Name = "Muğla"
            };
            Console.WriteLine("Şehir 2: " + sehir2.Name);
            SehriGuncelle(sehir2);
            Console.WriteLine("Şehir 2: " + sehir2.Name);
            #endregion

            #region Reference Types in Methods 2
            int sayi1 = 5;
            int sayi2 = 10;
            int carpim = 0;
            int toplam = ToplaVeCarp(sayi1, sayi2, ref carpim);
            Console.WriteLine($"Toplam: {toplam}, Çarpım: {carpim}");

            double rakam1 = 6.6;
            double rakam2 = 2.2;
            double bolum;
            double fark = CikarVeBol(rakam1, rakam2, out bolum);
            Console.WriteLine($"Fark: {fark}, Bölüm: {bolum}");
            #endregion

            Console.ReadLine();
        }

        #region Reference Types in Methods 1
        static void SehriGuncelle(string sehir)
        {
            sehir = "İstanbul";
        }
        static void SehriGuncelle(City sehir)
        {
            sehir.Name = "Antalya";
        }
        #endregion

        #region Reference Types in Methods 2
        static int ToplaVeCarp(int sayi1, int sayi2, ref int carpim)
        {
            carpim = sayi1 * sayi2;
            return sayi1 + sayi2;
        }

        static double CikarVeBol(double sayi1, double sayi2, out double bolum)
        {
            bolum = sayi1 / sayi2;
            return sayi1 - sayi2;
        }
        #endregion
    }

    #region Reference Types
    class City
    {
        public string Name { get; set; }
    }
    #endregion
}
