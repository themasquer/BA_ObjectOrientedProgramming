using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using _014_AbstractClasses.Extras;
using _014_AbstractClasses.Extras.FileOperationExample;
using _014_AbstractClasses.Extras.ShapeExample;

namespace _014_AbstractClasses
{
    // inheritance amacıyla kullanılır. interface'lerle virtual method'ların birleşik kullanımı gibi düşünülebilir
    class Program
    {
        static void Main(string[] args)
        {
            //Database database = new Database(); // abstract class'lar da interface'ler gibi soyut olduklarından new'lenemez
            Database database = new SqlServerDatabase();
            database.databaseName = "SQL Server";
            database.DatabaseCompany = "Microsoft Company";
            database.Add();
            database.Update();
            database.Delete();
            //Console.WriteLine(database.DatabaseCompany + " - " + database.databaseName);
            Console.WriteLine(database.GetDatabaseInfo());

            database = new OracleDatabase();
            database.databaseName = "Oracle";
            database.DatabaseCompany = "Oracle Company";
            database.Add();
            database.Update();
            database.Delete();
            //Console.WriteLine(database.DatabaseCompany + " - " + database.databaseName);
            Console.WriteLine(database.GetDatabaseInfo());

            #region Shape Example
            ShapeExampleProgram shapeExampleProgram = new ShapeExampleProgram();
            shapeExampleProgram.Run();
            #endregion

            #region File Operation Example
            // Öğrenciler.txt C sürücüsü altında FileOperationExample klasörüne kopyalanmalıdır.
            // Program dosyayı bulamayınca hata verip durmasın diye try catch kullanıldı. Exceptions konusunda try catch anlatılacak.
            try
            {
                string path = @"C:\FileOperationExample\Öğrenciler.txt";
                Console.WriteLine("Path: " + path);
                FileOperationBase fileOperation = new FileOperation { Path = path };
                string fileContent = fileOperation.ReadFromFile();
                Console.WriteLine("File Content:\n" + fileContent);
                Console.Write("Enter New Name: ");
                string input = Console.ReadLine();
                fileOperation.WriteToFile(fileContent + "\n" + input);
                fileContent = fileOperation.ReadFromFile();
                Console.WriteLine("File Content:\n" + fileContent);
            }
            catch
            {
                Console.WriteLine(@"Öğrenciler.txt C:\FileOperationExample\ klasöründe bulunamadı!");
            }
            #endregion

            Console.ReadLine();
        }
    }

    abstract class Database 
    {
        public string databaseName; // field tanımlanabilir
        public string DatabaseCompany { get; set; } // property tanımlanabilir

        public void Add() // ekleme tüm veritabanlarında aynı. tamamlanmış method
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete(); // silme işlemi her bir veritabanı için farklı. tamamlanmamış method. içi dolu olmayan virtual method

        public virtual void Update() // güncelleme default olarak tüm veritabanlarında aynı ancak ezilebilir
        {
            Console.WriteLine("Updated by default");
        }

        public string GetDatabaseInfo()
        {
            return "Database Company: " + DatabaseCompany + ", Database Name: " + databaseName;
        }
    }

    class SqlServerDatabase : Database // Database'den başka bir class'dan ya da abstract'tan inherit edilemez. ancak birden çok interface implemente edilebilir
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SQL Server");
        }
    }

    class OracleDatabase : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }

        public override void Update()
        {
            Console.WriteLine("Updated by Oracle");
        }
    }
}
