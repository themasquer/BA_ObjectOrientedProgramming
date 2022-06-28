using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _018_Constructors.Extras;

namespace _018_Constructors
{
    class Program
    {
        // constructor bir class new'lendiğinde çalışan kod bloğudur
        // bir class'ın ihtiyaç duyduğu parametreler varsa ve class bu parametreleri kullanacaksa bunu constructor üzerinden sağlayabiliriz

        static void Main(string[] args)
        {
            CustomerManager customerManager1 = new CustomerManager(); // parametresiz bir şekilde bu constructor çalıştırılır
            customerManager1.List();
            CustomerManager customerManager2 = new CustomerManager(10); // parametreli bir şekilde bu constructor çalıştırılır
            customerManager2.List();

            Shop shop1 = new Shop() { Id = 1, Name = "Mediamarkt" };
            Shop shop2 = new Shop(2, "Vatan");

            #region Finalizers
            FinalizersProgram.Run();
            #endregion

            #region IDisposable
            IDisposableProgram.Run();
            #endregion

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 20; // private değişkenler _ ile tanımlanır, ilk değer ataması burada yapılmıştır

        public CustomerManager() // constructor adı class adı ile aynı olmalıdır
        {
            //_count = 20; // field ve property'lere ilk değer atamaları burada da yapılabilir
        }

        public CustomerManager(int count) // constructor overload
        {
            _count = count;
        }

        public void List()
        {
            Console.WriteLine("Listed " + _count + " items");
        }
    }

    class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Shop(int id = 0, string name = "") // default parametre kullanımı
        {
            Id = id;
            Name = name;
        }
    }
}
