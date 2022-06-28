using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes
{
    class EmployeeService // veya EmployeeManager (çok katmanlı mimarilerde bahsedilecek). Employee ile ilgili işlemler
    {
        public void Add()
        {
            Console.WriteLine("Employee Added!");
        }

        public void Update()
        {
            Console.WriteLine("Employee Updated!");
        }

        public void Delete()
        {
            Console.WriteLine("Employee Deleted!");
        }
    }
}
