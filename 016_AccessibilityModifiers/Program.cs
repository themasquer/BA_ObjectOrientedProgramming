using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _016_AccessibilityModifiers
{
    // accessibility modifier = visibility modifier
    // accessibilities (en dardan en genişe): private -> protected -> internal -> public
    // neden her yerde public kullanmıyoruz?
    // hem programcıyı yanlış yönlendirmemek yani erişmesi gerekmeyen field, property ya da method'lara erişim vermemek, hem de kodun okunurluğunu arttırmak için
    // least privilege: neye ihtiyaç varsa minimum olarak tanımlanmalı, eğer daha fazlasına ihtiyaç varsa arttırılmalı

    class Program
    {
        static void Main(string[] args)
        {
            #region Nested Classes
            Computer computer = new Computer();
            computer.ComputerManufacturer = "ASUS";
            Computer.CPU computerCpu = new Computer.CPU();
            computerCpu.CpuManufacturer = "Intel";
            computerCpu.Ghz = 4;
            Console.WriteLine("Computer: " + computer.ComputerManufacturer + ", CPU: " + computerCpu.CpuManufacturer + " " + computerCpu.Ghz + " GHz");

            Bilgisayar bilgisayar = new Bilgisayar() // nested class değildir!
            {
                BilgisayarUreticisi = "HP",
                Islemci = new Islemci()
                {
                    IslemciUreticisi = "AMD",
                    GHz = 3
                }
            };
            Console.WriteLine("Bilgisayar: " + bilgisayar.BilgisayarUreticisi + ", İşlemci: " + bilgisayar.Islemci.IslemciUreticisi + " " + bilgisayar.Islemci.GHz);
            #endregion

            Console.ReadLine();
        }
    }

    #region Private Accessibility Modifier
    class Customer
    {
        int id1_private; // default private
        private int id2_private;

        private int Id4_private { get; set; } // genelde kullanılmaz

        void Shop() // default private
        {
            id1_private = 1; // private değişkenlere sadece tanımlandığı scope yani blok içinde erişilebilir
            id2_private = 2;
            int id3_local; // Shop() method'u içinde private gibi davranır
            id3_local = 3;
            Id4_private = 4; // private özelliklere sadece tanımlandığı scope yani blok içinde erişilebilir
        }

        void Pay()
        {
            //id3_local = 3; // sadece Shop() method'u scope'u içinde tanımlandığından erişilemez
            id2_private = 2; // private değişkenlere sadece tanımlandığı scope yani blok içinde erişilebilir
            Id4_private = 4; // private özelliklere sadece tanımlandığı scope yani blok içinde erişilebilir
        }
    }

    class CustomerManager
    {
        void CreateCustomer()
        {
            Customer customer = new Customer();
            //customer.id1_private; // private olduğundan gelmeyecektir. diğer private değişkenlere de erişilemeyecektir.
                                    // private değişkenlere sadece tanımlandığı scope yani blok içinde erişilebilir
        }
    }
    #endregion

    #region Protected Accessibility Modifier
    class Person
    {
        protected int id1_protected; // tanımlandığı scope içerisinde private gibi davranır. inherit edildiği sınıflarda kullanılabilir
        protected int Id1_protected { get; set; } // tanımlandığı scope içerisinde private gibi davranır. inherit edildiği sınıflarda kullanılabilir
        private int id2_private;

        private void Work() // bu method Person scope'u içinde geçerlidir. sadece bu scope içinden çağrılabilir
        {
            id1_protected = 1;
            Id1_protected = 1;
            id2_private = 2;
        }

        protected void PersonWork() // PersonWork() method'u üzerinden Work() private method'una erişebiliyoruz
        {
            Work();
        }
    }

    class Worker : Person
    {
        void Work() // Person'daki Work() method'u private olduğu için inherit edilmeyecek.
                    // dolayısıyla Worker scope'unun içerisine aynı isimde olmasına rağmen Work() method'u tanımlayabiliyoruz
        {
            id1_protected = 1;
            Id1_protected = 1;
            //id2_private = 2; // private tanımlandığından inherit edilmeyecektir
        }

        void WorkerWork() // base class'taki inherit edilen protected PersonWork() method'unu bu method ile çağırabiliriz
        {
            PersonWork();
        }
    }
    #endregion

    #region Internal Accessibility Modifier
    internal class Animal // class başında birşey yazmadığından default'u internal'dır. bağlı olduğu proje yani assembly içerisinde referans ihtiyacı olmadan kullanabiliyoruz 
    {
        internal int id1_internal; // inheritance ile sub class'lara taşınır
        internal int Id1_internal { get; set; } // inheritance ile child class'lara taşınır

        internal void SetAnimal() // inheritance ile sub class'lara taşınır
        {
            id1_internal = 1;
            Id1_internal = 1;
        }
    }

    class Dog : Animal
    {
        void SetTheDog() 
        {
            id1_internal = 1;
            Id1_internal = 1;
        }

        void SetDog() // base class'taki inherit edilen internal SetAnimal() method'unu bu method ile çağırabiliriz
        {
            SetAnimal();
        }
    }
    #endregion

    #region Public Accessibility Modifier
    public class Vehicle // public ile hem bu proje yani assembly içerisinde, hem de diğer projelerde yani assembly'lerde bu projeye yani assembly'e referans vererek class'a erişebiliyoruz 
    {
        public int Id1_public { get; set; } // inheritance ile child class'lara taşınır
        public int id1_public; // inheritance ile sub class'lara taşınır

        public void Drive() // inheritance ile child class'lara taşınır
        {
            Id1_public = 1;
            id1_public = 1;
        }
    }

    public class Car : Vehicle
    {
        public void DriveTheCar()
        {
            Id1_public = 1;
            id1_public = 1;
        }

        public void DriveCar() // base class'taki inherit edilen public Drive() method'unu bu method ile çağırabiliriz
        {
            Drive();
        }
    }
    #endregion

    #region Nested Classes
    //private class Dog // private tanımlanamaz
    //{
    //}

    //protected class Dog // protected tanımlanamaz
    //{
    //}
    class Pet
    {
        private class Dog // bu şekilde private tanımlanabilir
        {
        }
    }

    class Computer // Amaç class'ları başka bir class içinde gruplamak.
    {
        public string ComputerManufacturer { get; set; }
        internal class CPU // class içinde olduğundan internal veya public yazılmazsa private olarak algılanacaktır ve hata verecektir!
        {
            public string CpuManufacturer { get; set; }
            public int Ghz { get; set; }
        }
    }

    // Genellikle class'lar nested olarak değil ayrı ayrı oluşturulur:
    public class Bilgisayar
    {
        public string BilgisayarUreticisi { get; set; }
        public Islemci Islemci { get; set; } // Nested class değildir.
                                             // Bilgisayar içerisinde Islemci tipinde bir özellik tanımlanmıştır.
                                             // Dolayısıyla oluşturulan bilgisayar objesinin içerisinde bir işlemci objesi olacaktır.
    }

    public class Islemci
    {
        public string IslemciUreticisi { get; set; }
        public double GHz { get; set; }
    }
    #endregion
}
