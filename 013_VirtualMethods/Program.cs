using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlDatabase mySqlDatabase = new MySqlDatabase();
            mySqlDatabase.Add();
            mySqlDatabase.Update();
            mySqlDatabase.Delete();

            SqlServerDatabase sqlServerDatabase = new SqlServerDatabase();
            sqlServerDatabase.Add();

            Database oracleDatabase = new OracleDatabase();
            oracleDatabase.Delete();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add() // default olarak bu işlemi yapar, ihtiyaca göre override edilebilir. method ezilebilir demektir. interface'lerde yapılamaz
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete() // default olarak bu işlemi yapar, ihtiyaca göre override edilebilir. method ezilebilir demektir. interface'lerde yapılamaz
        {
            Console.WriteLine("Deleted by default");
        }

        public void Update()
        {
            Console.WriteLine("Updated by default");
        }
    }

    class SqlServerDatabase : Database // diyelim ki SQL Server için Add() method'unda farklı bir işlem yapacağız
    {
        public override void Add()
        {
            //base.Add(); // önce parent yani base'indeki Add() method'unu çağır. duruma göre çağrılabilir veya çağrılmayabilir
            Console.WriteLine("Added by SQL Server");
        }
    }

    class MySqlDatabase : Database
    {

    }

    class OracleDatabase : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
