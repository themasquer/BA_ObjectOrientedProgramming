using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _021_StaticClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Config.ConnectionString);
            Config.ConnectionTimeout = 30;
            Console.WriteLine(Config.ConnectionTimeout);

            Console.Write("Kullanıcı adı giriniz: ");
            string input = Console.ReadLine();
            Utilities.Validate(input);

            Manager.Manage_static();
            Manager manager = new Manager();
            manager.Manage();

            Console.WriteLine("Database: " + Database.name);
            //Database.Name = "Oracle"; // hata verecektir readonly olduğu için

            Console.ReadLine();
        }
    }

    static class Config // static nesneler new'lenmez. arka planda tek bir nesne oluşturulur ve tüm kullanıcılar tarafından bu nesneye erişilir.
                        // paylaşılan bir kaynak olup olmadığından emin olunmalı.
                        // static bir nesnenin tüm özellik ve methodları da static olmalıdır
                        // static nesneler stack memory'de tutulur. stack memory bilgisayarın memory'sinde bir program için ortak kullanılan ve değeri ile tipi değişmeyecek verileri tutan hafıza,
                        // heap memory ise run-time sırasında programın kullandığı ve değer ile tipi değişkenlik gösterecek hafıza.
                        // stack memory'de static ile tanımlanmış nesneler uygulama çalıştığı sürece saklanır,
                        // heap memory'de ise nesneler ya otomatik olarak Garbage Collector ile hafızadan temizlenir ya da kullanıcı ihtiyaç duyduğunda bu nesneleri hafızadan temizler
                        // Windows uygulamalarında static nesnelere uygulamanın her class'ından erişilebilir. Uygulama çalıştığı sürece tanımlanmış nesneler kullanılacaktır.
                        // Web uygulamalarında ise static nesnelere web sayfalarına giren her kullanıcı erişebilir. IIS ya da benzeri web server çalıştığı sürece tanımlanmış nesneler kullanılacaktır.
                        // kişisel kullanım olarak bir programın çok ender değişecek olan konfigürasyon'unu static bir nesnede tutmayı tercih ediyorum

    {
        //public static string connectionString = "SQL Server Connection String"; // public field olarak kullanılmamalı
        public static string ConnectionString => "SQL Server Connection String"; // sadece getter'ı olan bir property üzerinden tanımlanmalı

        public static int ConnectionTimeout { get; set; } // ihtiyaç olduğunda static bir property set edilip sonrasında değeri get edilebilir
    }

    static class Utilities
    {
        public static void Validate(string input) // kullanıcı tarafından girilen verilerin doğruluğu
        {
            //if (input.Trim().Equals(""))
            if (String.IsNullOrWhiteSpace(input)) // bu kullanım daha iyi çünkü input'un başındaki ve sonundaki boşlukları trim'leyip null veya "" kontrolü yapar
                Console.WriteLine("Please enter an input!");
            else
                Console.WriteLine("Validation for " + input + " is done");
        }
    }

    public class Manager
    {
        public static void Manage_static() // hiç instance üretmeden kullanılabilir
        {
            Console.WriteLine("Managed (static)");
        }

        public void Manage() // sadece instance üretilerek kullanılabilir
        {
            Console.WriteLine("Managed");
        }
    }

    static class Database
    {
        static Database() // static constructor. mutlaka çalışmasını istediğimiz kod bloğunu buraya yazıyoruz
        {
            name = "SQL Server";
        }

        public static readonly string name; // readonly olduğu için sadece constructor üzerinden set edilebilir
    }
}
