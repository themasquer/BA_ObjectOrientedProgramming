using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _024_Collections
{
    class Program
    {
        // koleksiyonlar dinamik dizi nesneleridir

        static void Main(string[] args)
        {
            #region Arrays
            string[] isimler = new string[3];
            isimler[0] = "Ali";
            isimler[1] = "Veli";
            isimler[2] = "Zeynep";
            //isimler[3] = "Muhittin"; // run-time hatası verecektir çünkü dizi 3 eleman tutabilecek şekilde tanımlandı.
            // bunu gerçekletirebilmenin tek yolu diziyi new'lemektir:
            isimler = new string[4];
            isimler[0] = "Ali"; // daha önceki elemanları kaybettiğimiz için tekrar atama yapıyoruz
            isimler[1] = "Veli";
            isimler[2] = "Zeynep";
            isimler[3] = "Muhittin"; // şimdi sorunsuz çalışacaktır
            #endregion

            #region ArrayList
            // bu sorunun üstesinden gelebilmek için koleksiyonlar kullanılır
            // ArrayList'te objeler üzerinden işlemler yapılır
            ArrayList isimlerListesi = new ArrayList();
            isimlerListesi.Add("Ali");
            isimlerListesi.Add("Veli");
            isimlerListesi.Add("Zeynep");
            foreach (var isimItem in isimlerListesi)
            {
                Console.WriteLine(isimItem);
            }
            isimlerListesi.Add("Muhittin"); // hiç bir new'leme yapmadan ve daha önce eklediklerimi kaybetmeden Muhittin'i listeye ekleyebildim
            foreach (var isimItem in isimlerListesi)
            {
                Console.WriteLine(isimItem);
            }
            Console.WriteLine(isimlerListesi[3]);
            // eğer çalıştığımız veriler type safe değilse, yani verilerin tipini bilmiyorsak ArrayList kullanabiliriz. ancak type safe çalışma genelde tercih edilir
            isimlerListesi.Add(1);
            isimlerListesi.Add('A');
            isimlerListesi.Add(true);
            foreach (var isimItem in isimlerListesi)
            {
                Console.WriteLine(isimItem);
            }
            #endregion

            #region Type Safe (Generic) Collections
            List<string> sehirListesi = new List<string>()
            {
                "İstanbul"
            };
            sehirListesi.Add("Ankara");
            //sehirListesi.Add('A'); // hata verecektir
            sehirListesi.Add("İzmir");
            foreach (var sehirItem in sehirListesi)
            {
                Console.WriteLine(sehirItem);
            }
            List<Sehir> sehirler = new List<Sehir>()
            {
                new Sehir() { Id = 1, Adi = "İstanbul" }
            };
            sehirler.Add(new Sehir(2, "Ankara"));
            Sehir sehir = new Sehir();
            sehir.Id = 3;
            sehir.Adi = "İzmir";
            sehirler.Add(sehir);
            foreach (var _sehir in sehirler)
            {
                Console.WriteLine(_sehir);
            }
            foreach (var _sehir in sehirler)
            {
                Console.WriteLine("Şehir Id: " + _sehir.Id + ", Şehir Adı: " + _sehir.Adi);
            }
            #endregion

            #region Collection Methods
            int count = sehirler.Count; // listedeki eleman sayısı
            Console.WriteLine("Count: " + count);
            var yeniSehir = new Sehir()
            {
                Id = 4,
                Adi = "Van"
            };
            sehirler.Add(yeniSehir);
            foreach (var _sehir in sehirler)
            {
                Console.WriteLine("Şehir Id: " + _sehir.Id + ", Şehir Adı: " + _sehir.Adi);
            }
            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine("Şehir Id: " + sehirler[i].Id + ", Şehir Adı: " + sehirler[i].Adi);
            }
            Sehir[] yeniSehirler = new Sehir[2] { new Sehir(5, "Antalya"), new Sehir(6, "Adana") };
            sehirler.AddRange(yeniSehirler);
            foreach (var _sehir in sehirler)
            {
                Console.WriteLine("Şehir Id: " + _sehir.Id + ", Şehir Adı: " + _sehir.Adi);
            }
            IEnumerable<string> names1 = new List<string>()
            {
                "Max",
                "Charlize",
                "Robert",
                "Jasmine"
            };
            ICollection<string> names2 = new List<string>()
            {
                "Max",
                "Charlize",
                "Robert",
                "Jasmine"
            };
            List<string> names3 = new List<string>()
            {
                "Max",
                "Charlize",
                "Robert",
                "Jasmine"
            };
            names3.Sort(); // primitive veri tipleri üzerinden sıralama yapılabilir.
                           // objeler üzerinden ise sırlamanın hangi özellik veya özelliklere göre yapılacağının belirtilmesi gerekir (LINQ konusu).
            foreach (string name in names3)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(names2.Contains("Max"));
            Console.WriteLine(names2.Contains("max"));
            Console.WriteLine(names2.Contains("Michael"));
            Console.WriteLine(sehirler.Contains(new Sehir() { Id = 6, Adi = "Adana" })); // false dönecektir. değerler karşılaştırılmaz, referanslar yani adresler karşılaştırılır
            Console.WriteLine(sehirler.Contains(yeniSehir)); // true döner çünkü zaten daha önce bu item'ı listeye eklemiştik yani bu referansa sahip nesne listede mevcut
            int index = sehirler.IndexOf(yeniSehir); // aramaya baştan başlayıp ilk bulduğu yeniSehir objesinin index'ini döner
            Console.WriteLine("Index: {0}", index);
            int lastIndex = sehirler.LastIndexOf(yeniSehir); // aramaya baştan başlayıp son bulduğu yeniSehir objesinin index'ini döner
            Console.WriteLine("{0}: {1}", "Last Index: ", lastIndex);
            sehirler.Add(yeniSehir); // hep en sona ekler
            index = sehirler.IndexOf(yeniSehir);
            lastIndex = sehirler.LastIndexOf(yeniSehir);
            Console.WriteLine("New Index: {0}", index);
            Console.WriteLine("{0}: {1}", "New Last Index: ", lastIndex);
            Sehir seciniz = new Sehir() { Id = 0, Adi = "-- Seçiniz --" };
            sehirler.Insert(0, seciniz); // listenin en başına ekledik
            foreach (var s in sehirler)
            {
                Console.WriteLine("Şehir Id: " + s.Id + ", Şehir Adı: " + s.Adi);
            }
            sehirler.Remove(seciniz); // bulduğu ilk nesneyi listeden çıkarır
            foreach (var s in sehirler)
            {
                Console.WriteLine("Şehir Id: " + s.Id + ", Şehir Adı: " + s.Adi);
            }
            sehirler.Clear(); // listeyi temizler
            foreach (var _sehir in sehirler)
            {
                Console.WriteLine("Şehir Id: " + _sehir.Id + ", Şehir Adı: " + _sehir.Adi);
            }
            Console.WriteLine("Count: " + sehirler.Count);
            #endregion

            #region Dictionary
            // İngilizce - Türkçe sözlük:
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");
            Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]); // hata verir çünkü dictionary'imizde yok
            if (dictionary.ContainsKey("glass"))
                Console.WriteLine("glass bulundu");
            else
                Console.WriteLine("glass bulunamadı");
            if (dictionary.ContainsKey("table"))
                Console.WriteLine("table bulundu");
            else
                Console.WriteLine("table bulunamadı");
            if (dictionary.ContainsValue("bilgisayar"))
                Console.WriteLine("bilgisayar bulundu");
            else
                Console.WriteLine("bilgisayar bulunamadı");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine("Anahtar: " + item.Key + ", Değer: " + item.Value + ", Toplam Kayıt Sayısı: " + dictionary.Count);
            }
            Dictionary<string, Sehir> sehirDictionary = new Dictionary<string, Sehir>()
            {
                { "a", new Sehir() { Id = 1, Adi = "Ankara" } },
                { "i", new Sehir(2, "İstanbul") },
                { "v", new Sehir(3, "Van") }
            };
            Console.WriteLine(sehirDictionary["a"].Adi);
            Console.WriteLine(sehirDictionary["v"].Id);
            #endregion

            #region Collections (List) Demo
            // listenin kopyasının oluşturulması,
            // sayı elemanlarının tersten yazdırılması,
            // sayı elemanlarının toplamı, ortalaması, maksimumu, minimumu,
            // listedeki eleman sayısı,
            // bir listede herhangi bir eleman unique (tekil) mi kontrolü:
            const string exit = "0";
            Console.WriteLine("Pozitif sayı listesi girin (Çıkmak için '" + exit + "' tuşuna basın): ");
            string input;
            int number;
            List<int> numbers = new List<int>();
            do
            {
                input = Console.ReadLine();
                if (!input.Equals(exit))
                {
                    number = Convert.ToInt32(input);
                    if (number > 0) // sadece girilen pozitif sayılar listeye eklensin
                        numbers.Add(number);
                }
            } while (!input.Equals(exit));
            if (numbers.Count > 0)
            {
                Console.WriteLine("Girilen sayılar:");
                foreach (var n in numbers)
                {
                    Console.WriteLine(n);
                }
                List<int> reversedNumbers = numbers.ToList(); // bir liste ToList() methodu ile kolayca kopyalanabilir
                reversedNumbers.Reverse();
                Console.WriteLine("Girilen sayılar (tersten):");
                foreach (var n in reversedNumbers)
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("Girilen sayıların toplamı: " + numbers.Sum());
                Console.WriteLine("Girilen sayıların ortalaması: " + numbers.Average());
                Console.WriteLine("Girilen sayıların en büyüğü: " + numbers.Max());
                Console.WriteLine("Girilen sayıların en küçüğü: " + numbers.Min());
                Console.WriteLine("Girilen listenin eleman sayısı: " + numbers.Count);
                Console.Write("Aramak istediğiniz sayıyı girin: ");
                input = Console.ReadLine();
                int numberToSearch = Convert.ToInt32(input);
                if (numberToSearch > 0)
                {
                    if (numbers.Contains(numberToSearch))
                    {
                        // 1. yol:
                        int numberCount = 0;
                        foreach (int n in numbers)
                        {
                            if (n == numberToSearch)
                            {
                                numberCount++;
                                if (numberCount > 1)
                                    break;
                            }
                        }
                        if (numberCount > 1)
                            Console.WriteLine("Aradığınız sayı listede tekil değildir.");
                        else
                            Console.WriteLine("Aradığınız sayı listede tekildir.");

                        // 2. yol:
                        int indexOfNumberToSearch = numbers.IndexOf(numberToSearch);
                        int lastIndexOfNumberToSearch = numbers.LastIndexOf(numberToSearch);
                        if (indexOfNumberToSearch == lastIndexOfNumberToSearch)
                            Console.WriteLine("Aradığınız sayı listede tekildir.");
                        else
                            Console.WriteLine("Aradığınız sayı listede tekil değildir.");
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz sayı listede bulunmamaktadır.");
                    }
                }
                else
                {
                    Console.WriteLine("Pozitif bir sayı girilmelidir.");
                }
            }
            else
            {
                Console.WriteLine("Hiç sayı girmediniz.");
            }
            #endregion

            #region Collections (Dictionary) Demo
            // herhangi bir string içerisindeki Tükçe karakterleri İngilizce karakterlere dönüştürme:
            string turkceCumle = "Çağıl bugün işe geldi.";
            string ingilizceCumle;

            // 1. yol:
            ingilizceCumle = turkceCumle.Replace("Ö", "O")
                .Replace("Ç", "C")
                .Replace("Ş", "S")
                .Replace("İ", "I")
                .Replace("Ğ", "G")
                .Replace("Ü", "U")
                .Replace("ö", "o")
                .Replace("ç", "c")
                .Replace("ş", "s")
                .Replace("ı", "i")
                .Replace("ğ", "g")
                .Replace("ü", "u");
            Console.WriteLine("Türkçe cümle: " + turkceCumle);
            Console.WriteLine("İngilizce cümle: " + ingilizceCumle);

            // 2. yol (Neşe'nin çözümü):
            Dictionary<string, string> harfDictionary = new Dictionary<string, string>()
            {
                { "Ö", "O" },
                { "Ç", "C" },
                { "Ş", "S" },
                { "Ğ", "G" },
                { "Ü", "U" },
                { "ö", "o" },
                { "ç", "c" },
                { "ş", "s" },
                { "ğ", "g" },
                { "ü", "u" },
                { "İ", "I" },
                { "ı", "i" }
            };
            ingilizceCumle = "";
            foreach (char harf in turkceCumle)
            {
                if (harfDictionary.ContainsKey(harf.ToString())) // harf Türkçe harf, ToString() ile harf char veri tipinde olduğu için
                                                                 // int olarak değil de string olarak kullanılmasını sağlıyoruz
                {
                    ingilizceCumle += harfDictionary[harf.ToString()]; // dictionary'de Türkçe harf olarak key (anahtar) olan
                                                                       // anahtar değer çiftinin value'sunu (değerini) kullanıyoruz
                                                                       // ve İngilizce cümleye ekliyoruz
                }
                else // harf Türkçe olmadığı için direkt olarak İngilizce cümleye ekliyoruz
                {
                    ingilizceCumle += harf.ToString();
                }
            }
            Console.WriteLine("Türkçe cümle: " + turkceCumle);
            Console.WriteLine("İngilizce cümle: " + ingilizceCumle);
            #endregion

            #region Recursive Methods
            Extras.RecursiveMethods.RecursiveMethodsProgram.Run();
            #endregion

            Console.ReadLine();
        }
    }

    #region Type Safe (Generic) Collections
    class Sehir
    {
        public Sehir()
        {

        }
        public Sehir(int id, string adi)
        {
            Id = id;
            Adi = adi;
        }
        public int Id { get; set; }
        public string Adi { get; set; }
    }
    #endregion
}
