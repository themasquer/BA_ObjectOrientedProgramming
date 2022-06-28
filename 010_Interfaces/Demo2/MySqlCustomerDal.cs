using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Demo2
{
    public class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL Add");
        }

        public void Delete()
        {
            Console.WriteLine("MySQL Delete");
        }

        public void Update()
        {
            Console.WriteLine("MySQL Update");
        }
    }
}
