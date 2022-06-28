using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _020_ConstructorsInInheritance.Extras.Example;
using _020_ConstructorsInInheritance.Extras.FileOperationExample;

namespace _020_ConstructorsInInheritance
{
    // örneğin abstract bir class'ta her şey standart olarak tanımlanmış ancak sadece bir parametre farklılık gösteriyor, mesela connection string (SQL Server için farklı, Oracle için farklı).
    // sadece connection string'i base'e parametre olarak göndermemiz yeterlidir. geri kalan tüm standart işlemleri abstract sınıf gerçekleştirecektir

    class Program
    {
        static void Main(string[] args)
        {
            SubClass subClass = new SubClass("ChildField", "BaseField");
            subClass.BaseMethod();
            subClass.SubMethod();

            #region Abstract Class Example
            ClassExample classExample = new ClassExample("BaseField");
            classExample.BaseMethod();
            classExample.SubMethod("ChildField");
            #endregion

            #region File Operation Example
            string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string exeFileName = assemblyName + ".exe";
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = exePath.Replace(@"\bin\Debug\", @"\Extras\FileOperationExample\").Replace(exeFileName, "") + "Öğrenciler.txt";
            Console.WriteLine("Assembly Name: " + assemblyName);
            Console.WriteLine("Executable File Name: " + exeFileName);
            Console.WriteLine("Executable File Path: " + exePath);
            Console.WriteLine("Path: " + path);
            FileOperationBase fileOperation = new FileOperation(path);
            string fileContent = fileOperation.ReadFromFile();
            Console.WriteLine("File Content:\n" + fileContent);
            Console.Write("Enter New Name: ");
            string input = Console.ReadLine();
            fileOperation.WriteToFile(fileContent + "\n" + input);
            fileContent = fileOperation.ReadFromFile();
            Console.WriteLine("File Content:\n" + fileContent);
            #endregion

            Console.ReadLine();
        }
    }

    class BaseClass
    {
        private string _baseField;

        public BaseClass(string baseField)
        {
            _baseField = baseField;
            Console.WriteLine("BaseClass constructor executed with " + _baseField);
        }

        public void BaseMethod()
        {
            Console.WriteLine("Base method executed with " + _baseField);
        }
    }

    class SubClass : BaseClass
    {
        private string _childField;

        public SubClass(string childField, string baseField) : base(baseField) // base class'ın constructor'ını da çağırmamız gerekiyor
        {
            _childField = childField;
            Console.WriteLine("ChildClass constructor executed with " + _childField);
        }

        public void SubMethod()
        {
            Console.WriteLine("Child method executed with " + _childField);
        }
    }
}
