using System;

namespace _018_Constructors.Extras
{
    static class FinalizersProgram // C#'ta destructor diye bir kavram yok. kavramın adı finalizer.
    {
        static public void Run()
        {
            /*
            Garbage Collector hafızada uygulama tarafından kullanılmayan objeleri toplar ve
            belli bir zaman sonra bu objeleri hafızadan siler.

            Dolayısıyla C# ile hafıza yönetimi Garbage Collector tarafından otomatik yönetilir.

            Bu örneğin düzgün çalışması için bu uygulama Release modda çalıştırılmalıdır.
            */

           MemoryOperations memoryOperations = new MemoryOperations();

           Product product = new Product();
           Customer customer = new Customer();

           memoryOperations.CleanMemory();
           // product ve customer nesnelerinin finalizer'ları çalışır.
           // Bu nesnelere bu scope içerisinde tekrar ulaşılmadığı için Garbage Collector tarafından hafızadan silinir.

           product = new Product();
           customer = new Customer();

           memoryOperations.CleanMemory();
           // sadece product nesnesinin finalizer'ı çalışır.
           // customer nesnesine bu scope içerisinde aşağıda tekrar ulaşıldığı için customer nesnesi Garbage Collector tarafından hafızadan silinmez.
           // Sadece product nesnesi bu scope içerisinde tekrar ulaşılmadığı için Garbage Collector tarafından hafızadan silinir.

           Console.WriteLine("Customer: " + customer.Id + ") " + customer.Name + " " + customer.Surname);
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }

        public Product()
        {
            Id = 0;
            Name = "";
            SerialNumber = "";
            Console.WriteLine("Product constructor executed.");
        }

        ~Product() // C#'ta destructor diye bir kavram yok. kavramın adı finalizer.
        {
            // nesne temizleme kodları...
            Console.WriteLine("Product finalizer executed."); // Garbage Collector nesneyi temizleyene kadar çalışmayacak
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer()
        {
            Id = 1;
            Name = "Çağıl";
            Surname = "Alsaç";
            Console.WriteLine("Customer constructor executed.");
        }

        ~Customer() // C#'ta destructor diye bir kavram yok. kavramın adı finalizer.
        {
            // nesne temizleme kodları...
            Console.WriteLine("Customer finalizer executed."); // Garbage Collector nesneyi temizleyene kadar çalışmayacak
        }
    }

    class MemoryOperations
    {
        public void CleanMemory()
        {
            Console.WriteLine("Begin MemoryOperations class CleanMemory method.");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("End MemoryOperations class CleanMemory method.");
        }
    }
}
