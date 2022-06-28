using _010_Interfaces.Demo1;
using _010_Interfaces.Extras.ShapeExample;
using System;
using _010_Interfaces.Extras.MemeliExample;

namespace _010_Interfaces
{
    /* SOLID Principles:
    Single responsibility principle: A class should only have one job to do and should have only one reason to change.
    Open closed principle: A class should be open for extension but closed for changes.
    Liskov's substition principle: Derived classes should be substitutable for their base class.
    Interface segregation principle: There shouldn't be unnecessary methods in an interface that aren't being used in a class.
    Dependency inversion principle: Higher level classes should not be dependant on lower level classes. Classes must depend on abstractions, not concretions.
    */

    class Program
    {
        static void Main(string[] args)
        {
            #region Interface Intro
            CustomerService customerService = new CustomerService();
            Customer customer = new Customer() { Id = 1, FirstName = "Çağıl", LastName = "Alsaç", Address = "Ankara" };
            customerService.Add(customer);
            Student student = new Student();
            student.Id = 2;
            student.FirstName = "Leo";
            student.LastName = "Alsaç";
            student.Department = "Veterinary Medicine";
            StudentService studentService = new StudentService();
            studentService.Add(student);
            PersonService personService = new PersonService();
            personService.Add(customer);
            personService.Add(student);
            IPerson employee1 = new Employee() // interface implemente edilen class'lardan herhangi birine new'lenebilir
            {
                Id = 3,
                FirstName = "Angel",
                LastName = "Alsaç"
            };
            Employee employee2 = new Employee()
            {
                Id = 3,
                FirstName = "Angel",
                LastName = "Alsaç",
                Office = "İstanbul Office"
            };
            personService.Add(employee1);
            personService.Add(employee2);
            #endregion

            #region Interface Demo 1
            // interface'ler katmanlar arası geçişlerde yoğunca kullanılır. amaç katman bağımlılıklarını minimize etmek
            CustomerManager customerManager = new CustomerManager();
            ICustomerDal customerDalSql = new SqlServerCustomerDal(); // polymorphism: temel bir interface, abstract class ya da concrete class üzerinden ihtiyaca göre kendisinden türeyen
                                                                      // farklı concrete class'lar üzerinden farklı şekillerde nesneler oluşturmak.
                                                                      // customerDalSql 1. nesne, customerDalOracle 2. nesne
            customerManager.Add(customerDalSql);
            ICustomerDal customerDalOracle = new OracleCustomerDal();
            customerManager.Add(customerDalOracle);
            #endregion

            #region Interface Demo 2
            // bir şirkette elimizdeki veriyi hem SQL Server hem de Oracle veritabanına atmak istiyoruz
            Demo2.ICustomerDal[] customerDals = new Demo2.ICustomerDal[3]
            {
                new Demo2.SqlServerCustomerDal(),
                new Demo2.OracleCustomerDal(),
                new Demo2.MySqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            #endregion

            #region Shape Example
            ShapeExampleProgram shapeExampleProgram = new ShapeExampleProgram();
            shapeExampleProgram.Run();
            #endregion

            #region Memeli Example
            MemeliExampleProgram memeliExampleProgram = new MemeliExampleProgram();
            memeliExampleProgram.Run();
            #endregion

            Console.ReadLine();
        }
    }

    interface IPerson // interface'ler I ile başlar. kullanım amacı temel bir nesne oluşturup bundan türetilen tüm nesnelerde bu temel nesne yapısını implemente etmek. soyut (abstract) nesne.
                      // tek başına hiç bir anlam ifade etmez. bir interface hiç bir zaman new'lenemez.
                      // interface ve abstract gibi soyut nesneler new'lenemez
    {
        int Id { get; set; } // interface'ler yazılırken tamamen methodun ya da property'nin imzası yazılır. accessibility modifier'lar kullanılmaz
        string FirstName { get; set; }
        string LastName { get; set; }

        //string MiddleName; // field'lar yazılamaz
    }

    class Customer : IPerson // somut (concrete) nesne. interface içinde tanımladığımız property ve method'ları class içinde implemente etmek zorundayız. inheritance gibi kullanılıyor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; } // interface tanımında yok
    }

    class Student : IPerson // somut (concrete) nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; } // interface tanımında yok
    }

    class CustomerService // veya PersonManager => iş katmanı
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer with ID " + customer.Id + " added to database");
        }
    }

    class StudentService // veya StudentManager => iş katmanı
    {
        public void Add(Student student)
        {
            Console.WriteLine("Student with ID " + student.Id + " added to database");
        }
    }

    class PersonService // veya PersonManager => iş katmanı
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Person with ID " + person.Id + " added to database");
        }
    }

    class Employee : IPerson // somut (concrete) nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Office { get; set; } // interface tanımında yok
    }
}
