using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Interfaces.Demo2
{
    public class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Server Add");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Server Delete");
        }

        public void Update()
        {
            Console.WriteLine("SQL Server Update");
        }
    }
}
