using System;

namespace _018_Constructors.Extras
{
    static class IDisposableProgram
    {
        public static void Run()
        {
            Person person = new Person();
            person.Dispose(); // yapılması gereken ihtiyaç kalmadığında obje'nin Dispose() methodunu çağırmaktır. Garbage Collector objeyi memory'den temizlemeyi halleder
            person = null; // objeyi memory'den temizlemez, sadece referans değişkeni ile obje arasındaki bağlantıyı kaldırır. artık bu referans değişkenine kod üzerinden
                           // erişme run-time hatası verecektir
        }
    }

    class Person : IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person()
        {
            Console.WriteLine("Constructor executed.");
        }

        #region Dispose Operation
        protected bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
