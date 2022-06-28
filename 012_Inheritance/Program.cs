using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Inheritance
{
    // inheritance: kalıtım veya miras
    // interface'ler de inheritance gibi kullanılsalar da aslında inheritance değildir, implementation'dır.
    // C#'ta tüm nesnelerin en üstteki base'i object class'ıdır yani tüm nesneler default olarak object class'ından türer.
    // ne zaman interface? ne zaman inheritance?
    // aşağıdaki people örneğinde inheritance kullanma zorunluluğumuz olmadığından ve interface'ler de yeni nesil programlama dillerinde inheritance gibi kullanılabildiğinden
    // interface kullanmak daha iyi olabilir. ancak kişisel olarak interface'leri sadece method tanımları ki bize bir protokol sunsun,
    // inheritance kullanacağımız abstract class'ları ise field, property ve default method implementasyonları ile birlikte method tanımları için kullanmayı tercih ediyorum.
    class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Çağıl";
            customer.LastName = "Alsaç";
            customer.City = "Ankara";

            Student student = new Student();
            student.Id = 2;
            student.FirstName = "Leo";
            student.LastName = "Alsaç";
            student.Department = "Veteriner Tıp";
            
            Person[] people = new Person[3]
            {
                new Person() // interface'lerin aksine Person concrete class olduğu için new'lenebilir. Person tek başına bir anlam ifade ediyor
                {
                    Id = 3,
                    FirstName = "Ali",
                    LastName = "Vefa"
                }, 
                new Customer()
                {
                    Id = 4,
                    FirstName = "Zeynep",
                    LastName = "Yasemin",
                    City = "İzmir"
                },
                new Student()
                {
                    Id = 5,
                    FirstName = "Muhittin",
                    LastName = "Yılmaz",
                    Department = "Mimarlık"
                }
            };
            foreach (var person in people)
            {
                Console.WriteLine("ID: " + person.Id + ", Name: " + person.FirstName + ", Surname: " + person.LastName);
            }
            student = people[2] as Student;
            Console.WriteLine("ID: " + student.Id + ", Name: " + student.FirstName + ", Surname: " + student.LastName + ", Department: " + student.Department);
            #endregion

            #region Inheritance with Interface
            ExtendedCustomer extendedCustomer = new ExtendedCustomer()
            {
                Id = 6,
                FirstName = "Zeki",
                LastName = "Metin",
                City = "İstanbul",
                Age = 50,
                CardNumber = "1234 5678 9012 3456"
            };
            Console.WriteLine("ID: " + extendedCustomer.Id + ", Name: " + extendedCustomer.FirstName + ", Surname: " + extendedCustomer.LastName + ", City: " + extendedCustomer.City
                              + ", Age: " + extendedCustomer.Age + ", Credit Card Number: " + extendedCustomer.CardNumber);
            #endregion

            #region Polymorphism
            Person student_Person = new Student()
            {
                Id = 1,
                FirstName = "Çağıl",
                LastName = "Alsaç",
                Department = "Bilgisayar"
            };
            Person customer_Person = new Customer()
            {
                Id = 2,
                FirstName = "Leo",
                LastName = "Alsaç",
                City = "Ankara"
            };
            Console.WriteLine("Id: " + student_Person.Id + ", First Name: " + student_Person.FirstName + ", Last Name: " + student_Person.LastName);
            Console.WriteLine("Id: " + customer_Person.Id + ", First Name: " + customer_Person.FirstName + ", Last Name: " + customer_Person.LastName);
            #endregion

            #region as ile Obje Tipi Dönüştürme
            Student student_AsExample = student_Person as Student;
            student_AsExample.Department = "Yazılım";
            Console.WriteLine("Id: " + student_AsExample.Id + ", First Name: " + student_AsExample.FirstName + ", Last Name: " + student_AsExample.LastName + ", Department: " + student_AsExample.Department);
            Customer customer_AsExample = customer_Person as Customer;
            customer_AsExample.City = "İstanbul";
            Console.WriteLine("Id: " + customer_AsExample.Id + ", First Name: " + customer_AsExample.FirstName + ", Last Name: " + customer_AsExample.LastName + ", City: " + customer_AsExample.City);
            #endregion

            #region Object'ten Otomatikman Miras Alma
            object[] personObjects = new object[2]
            {
                new Person()
                {
                    Id = 1,
                    FirstName = "Robert",
                    LastName = "DeNiro"
                },
                new Person()
                {
                    Id = 2,
                    FirstName = "Al",
                    LastName = "Pacino"
                }
            };
            // 1. yol:
            Person personObject;
            for (int i = 0; i < personObjects.Length; i++)
            {
                personObject = personObjects[i] as Person;
                Console.WriteLine("Id: " + personObject.Id + ", First Name: " + personObject.FirstName + ", Last Name: " + personObject.LastName);
            }
            // 2. yol:
            foreach (Person po in personObjects)
            {
                Console.WriteLine("Id: " + po.Id + ", First Name: " + po.FirstName + ", Last Name: " + po.LastName);
            }
            #endregion

            Console.ReadLine();
        }
    }

    #region Inheritance
    class Person //: object // yapılabilir çünkü C#'ta tüm class'lar otomatikman Object (object) class'ından miras alır
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Student : Person // Student'ın parent'ı (base'i) Person'dır. Student is a Person
    {
        // Person'daki özellikler buraya taşınacaktır

        // Yeni özellik de eklenebilir
        public string Department { get; set; }
    }

    class Customer : Person // Customer'ın parent'ı (base'i) Person'dır. Customer is a Person
    //class Customer : Person, Animal // interface'lerin aksine multiple inheritance yapılamaz! her bir object'in bir base'i olur!
    {
        // Person'daki özellikler buraya taşınacaktır

        // Yeni özellik de eklenebilir
        public string City { get; set; }
    }

    #region Inheritance with Interface
    interface IAge
    {
        int Age { get; set; }
    }

    interface ICreditCard
    {
        string CardNumber { get; set; }
    }

    class ExtendedCustomer : Customer, IAge, ICreditCard // önce varsa inheritance, sonra kaç tane varsa interface'ler yazılır
    {
        public int Age { get; set; }
        public string CardNumber { get; set; }
    }
    #endregion

    #endregion

    #region Is a Relationship
    class Person_IsAexample
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Student_IsAexample : Person_IsAexample
    {
        public string Department { get; set; }
    }

    class Customer_IsAexample : Person_IsAexample
    {
        public string City { get; set; }
    }
    #endregion

    #region Has a Relationship
    public class Person_HasAexample
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student_HasAexample Student { get; set; }
        public Customer_HasAexample Customer { get; set; }
    }

    public class Student_HasAexample
    {
        public string Department { get; set; }
    }
    public class Customer_HasAexample
    {
        public string City { get; set; }
    }
    #endregion
}
