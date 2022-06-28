using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _008_Classes.ArabalarProgramlariExample;
using _008_Classes.BilgisayarProgramiExample;
using _008_Classes.DiziClassExample;
using _008_Classes.ZarExample;

namespace _008_Classes // uzay: class kümesi, başka namespace altındaki class'lara ya bu namespace adı üzerinden ya da yukarıda using kullanılarak erişilebilir
{
    class Program
    {
        static void Main(string[] args)
        {
            // class'lar objelerin blueprint'leridir yani taslaklarıdır
            // genel anlamda çeşitli işlemleri gruplayarak gerçekleştirmemizi sağlar
            Person insan = new Person(); // sınıf üzerinden instance oluşturuyoruz. insan artık Person sınıfından türemiş bir objedir. insan objesini initialize ettik
            insan.Run();
            CustomerService service = new CustomerService();
            service.Add();
            service.Update();
            service.Delete();
            CustomerService customerService; // daha initialize etmedik, bu yüzden bu class'ın method'larına ulaşamayız. customerService'de c yani ilk kelimenin ilk harfi küçük, S yani ikinci kelimenin ilk harfi büyük, buna Camel case deniyor
            ProductService productService = new ProductService();
            productService.Add();
            productService.Update();
            productService.Delete();
            EmployeeService employeeService = new EmployeeService(); // _008_Classes namespace'i yani aynı namespace içinde olduğu için erişebiliyoruz
            employeeService.Add();
            employeeService.Update();
            employeeService.Delete();
            Customer customer = new Customer();
            customer.SetName("Çağıl");
            customer.SetSurname("Alsaç");
            customer.SetAge(39);
            Console.WriteLine("Customer Name: " + customer.GetName() + ", Customer Surname: " + customer.GetSurname() + ", Customer Age: " + customer.GetAge());
            Customer customer1 = new Customer();
            customer1.Id = 1; // property'deki set bloğu çalışır
            customer1.Name = "Leo";
            customer1.Surname = "Alsaç";
            customer1.City = "Ankara";
            customer1.Age = 6;
            customer1.country = "Türkiye"; // field public olduğu için erişebildik, yanlış kullanım!
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Ali",
                Surname = "Veli",
                City = "İzmir",
                Age = 25
            };
            Customer customer3 = new Customer
            {
                Id = 3,
                Name = "Ayşe",
                Surname = "Zeynep",
                City = "İstanbul",
                Age = 33
            };
            Console.WriteLine("Customer 1");
            Console.WriteLine("Id: " + customer1.Id // property'deki get bloğu çalışır
                + "; Name: " + customer1.Name + "; Surname: " + customer1.Surname + "; City: " + customer1.City + "; Age: " + customer1.Age);
            Console.WriteLine("Customer 2");
            Console.WriteLine("Id: " + customer2.Id + "; Name: " + customer2.Name + "; Surname: " + customer2.Surname + "; City: " + customer2.City + "; Age: " + customer2.Age);
            Console.WriteLine("Customer 3");
            Console.WriteLine("Id: " + customer3.Id + "; Name: " + customer3.Name + "; Surname: " + customer3.Surname + "; City: " + customer3.City + "; Age: " + customer3.Age);
            Customer_EncapsulationDemo customer4 = new Customer_EncapsulationDemo();
            customer4.kartNo_public = "1234 5678 9012 3456";
            Console.WriteLine("Customer 4 Kart No (public): " + customer4.kartNo_public);
            customer4.KartNo1 = "1234 5678 9012 3456";
            Console.WriteLine("Customer 4 Kart No: " + customer4.KartNo1);
            customer4.KartNo2 = "1234 5678 9012 3456";
            Console.WriteLine("Customer 4 Kart No: " + customer4.KartNo2);

            #region Encapsulation Demo
            // Amacımız eğer customer erkek ise adının başına Bay, kadın ise Bayan yazdırmak:
            Customer_EncapsulationDemo maleCustomer = new Customer_EncapsulationDemo()
            {
                ErkekMi = true,
                AdSoyad = "Çağıl Alsaç"
            };
            Console.WriteLine("Male Customer: " + maleCustomer.AdSoyad);
            var femaleCustomer = new Customer_EncapsulationDemo()
            {
                ErkekMi = false,
                AdSoyad = "Zeynep Başar"
            };
            Console.WriteLine("Female Customer: " + femaleCustomer.AdSoyad);
            var customer6 = new Customer_EncapsulationDemo()
            {
                AdSoyad = "Ayşe Yasemin"
            };
            Console.WriteLine("Customer: " + customer6.AdSoyad);
            #endregion

            #region ArabalarProgramlari Example
            //ArabalarProgramiV1 arabalarProgramiV1 = new ArabalarProgramiV1();
            //arabalarProgramiV1.Calistir();
            //ArabalarProgramiV2 arabalarProgramiV2 = new ArabalarProgramiV2();
            //arabalarProgramiV2.Calistir();
            //ArabalarProgramiV3 arabalarProgramiV3 = new ArabalarProgramiV3();
            //arabalarProgramiV3.Calistir();
            //ArabalarProgramiV4 arabalarProgramiV4 = new ArabalarProgramiV4();
            //arabalarProgramiV4.Calistir();
            //ArabalarProgramlariExampleV5.ArabalarProgramiV5 arabalarProgramiV5 = new ArabalarProgramlariExampleV5.ArabalarProgramiV5();
            //arabalarProgramiV5.Calistir();
            ArabalarProgramiVfinal arabalarProgramiFinal = new ArabalarProgramiVfinal();
            arabalarProgramiFinal.Calistir();
            #endregion

            #region Dizi Class Example
            // verilen diziye göre string ya da integer için çeşitli işlemler gerçekleştirme:
            Dizi dizi1 = new Dizi()
            {
                SiraliDizi = new string[] { "A", "B", "C", "D" }
            };
            for (int i = 0; i < dizi1.Boyut; i++)
            {
                Console.WriteLine(dizi1.SiraliDizi[i]);
            }
            Console.WriteLine(dizi1.DiziElemanlariniTopla());
            Console.WriteLine(dizi1.DiziElemanlarininOrtalamasi());
            Dizi dizi2 = new Dizi()
            {
                SiraliDizi = new string[] { "1", "2", "3" }
            };
            for (int i = 0; i < dizi2.Boyut; i++)
            {
                Console.WriteLine(dizi2.SiraliDizi[i]);
            }
            Console.WriteLine(dizi2.DiziElemanlariniTopla());
            Console.WriteLine(dizi2.DiziElemanlarininOrtalamasi());
            Dizi dizi3 = new Dizi()
            {
                SiraliDizi = new string[] { "1", "X", "3" }
            };
            for (int i = 0; i < dizi3.Boyut; i++)
            {
                Console.WriteLine(dizi3.SiraliDizi[i]);
            }
            Console.WriteLine(dizi3.DiziElemanlariniTopla());
            Console.WriteLine(dizi3.DiziElemanlarininOrtalamasi());
            Dizi dizi4 = new Dizi()
            {
                SiraliDizi = new string[] { "1", "2" }
            };
            dizi4.DiziElemanlariniGoster();
            Console.WriteLine(dizi4.DiziElemanlariniTopla());
            Console.WriteLine(dizi4.DiziElemanlarininOrtalamasi());
            #endregion

            #region Zar Example
            ZarManager zarManager = new ZarManager();
            Console.WriteLine("******");
            zarManager.ZarlariAt();
            zarManager.ZarlariGoster();
            Console.WriteLine("******");
            int zarAdedi = 2;
            zarManager.ZarlariAt(2);
            zarManager.ZarlariGoster();
            Console.WriteLine("******");
            int tekrarSayisi = 3;
            zarManager.ZarlariAt(tekrarSayisi, zarAdedi);
            zarManager.ZarlariGoster();
            Console.WriteLine("******");
            #endregion

            #region BilgisayarProgrami Example
            BilgisayarProgramiExample.BilgisayarProgrami bilgisayarProgrami = new BilgisayarProgrami();
            bilgisayarProgrami.Calistir();
            #endregion

            Console.ReadLine();
        }
    }

    class Person
    {
        public void Run() // behavior yani davranış
        {
            Console.WriteLine("Person is running...");
        }
    }

    class CustomerService // veya CustomerManager (çok katmanlı mimarilerde bahsedilecek). Customer ile ilgili işlemler
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Deleted!");
        }
    }

    class ProductService // veya ProductManager (çok katmanlı mimarilerde bahsedilecek). Product ile ilgili işlemler
    {
        public void Add()
        {
            Console.WriteLine("Product Added!");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }

        public void Delete()
        {
            Console.WriteLine("Product Deleted!");
        }
    }
}
