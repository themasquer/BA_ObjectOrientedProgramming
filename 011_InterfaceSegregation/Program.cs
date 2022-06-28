using System;
using _011_InterfaceSegregation.Extras.AracExample;

namespace _011_InterfaceSegregation
{
    // bir şirket var ve çeşitli çalışanlar mevcut: yöneticiler, işçiler, robotlar
    // Object oriented development'ta SOLID Principles çok önemli!
    // Burada SOLID'in I'si yani Interface Segregation Principle'ı gerçekleştirdik

    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            IGetSalary[] getSalaries = new IGetSalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var getSalary in getSalaries)
            {
                getSalary.GetSalary();
            }

            #region Arac Example
            AracExampleProgram aracExampleProgram = new AracExampleProgram();
            aracExampleProgram.Run();
            #endregion

            Console.ReadLine();
        }
    }

    //interface IWorker // yanlış interface tanımı, türetilen tüm nesneler için ihtiyacı karşılamıyor
    //{
    //    void Work();
    //    void Eat();
    //    void GetSalary();
    //}

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }

    //class Manager : IWorker // yanlış interface tanımından dolayı türetilen tüm nesneler için ihtiyacı karşılamıyor
    //{
    //    public void Eat()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GetSalary()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Work()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    class Manager : IWorker, IEat, IGetSalary // interface multiple implementation
    {
        public void Eat()
        {
            Console.WriteLine("Manager eats");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager gets salary");
        }

        public void Work()
        {
            Console.WriteLine("Manager works");
        }
    }

    //class Worker : IWorker // yanlış interface tanımından dolayı türetilen tüm nesneler için ihtiyacı karşılamıyor
    //{
    //    public void Eat()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GetSalary()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Work()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    class Worker : IWorker, IEat, IGetSalary // interface multiple implementation
    {
        public void Eat()
        {
            Console.WriteLine("Worker eats");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker gets salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker works");
        }
    }

    //class Robot : IWorker // method tanımlarında sıkıntı var. Eat() ve GetSalary() olmaması gerek. böyle bir durumda bu method'ların içi kullanılmıyor diye boş bırakılmamalı
    //                      // yanlış interface tanımından dolayı türetilen tüm nesneler için ihtiyacı karşılamıyor
    //{
    //    public void Eat()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GetSalary()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Work()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot works");
        }
    }
}
