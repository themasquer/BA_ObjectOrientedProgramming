using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes
{
    public class Customer // müşteri bilgileri için class
    {
        #region Properties
        public int Id { get; set; } // Customer class'ının property'si yani özelliği  
        public string Name { get; set; } // property
        public string Surname { get; set; } // property
        public string City { get; set; } // property
        public int Age { get; set; } // property
        #endregion

        string _name; // Customer class'ının field'ı yani alanı
        string _surname; // field
        int age; // field

        // public field:
        public string country; // Customer class'ının field'ı yani alanı, yanlış kullanım!

        public void SetName(string name) // Customer class'ının behavior'u yani davranışı. Customer class'ının neler yapabileceği
        {
            _name = name;
        }

        public string GetName() // behavior
        {
            return _name;
        }

        public void SetSurname(string surname) // behavior
        {
            _surname = surname;
        }

        public string GetSurname() // behavior
        {
            return _surname;
        }

        public void SetAge(int age) // behavior
        {
            this.age = age; // this içinde bulunduğu class'tan türeyen objeyi refere eder yani Customer türündeki obje
        }

        public int GetAge() // behavior
        {
            return age;
        }
    }
}
