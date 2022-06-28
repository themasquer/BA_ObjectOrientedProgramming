using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _019_DependencyInjection.Extras;

namespace _019_DependencyInjection
{
    /*
    Dependency injection is used for reducing and managing dependencies of classes or modules in object oriented development. 
    For example, with dependency injection we can change logging mechanism easily in a software project such that we can easily switch to database logging or file logging.
    The main reason is to make changes on an object without modifying the class. We use interfaces or abstractions to provide dependency injection.

    There are three types of dependency injection:
    I) Constructor injection: Passing newly created objects defined by an interface to the constructor of another class.
    II) Method injection: Passing newly created objects defined by an interface to the methods of another class.
    III) Property injection: Instead of using a constructor, we create a property for the class and use it.

    Tight coupling: If a system needs a specific concrete object to run, it is tightly dependant on that object.
    Loosely coupling: Other than dependency on a concrete object, if a system is dependant on an interface or abstract object, it is loosely coupled since different classes 
    can inherit that interface or abstraction.
    In loose coupling, we need what an object can and should do. With dependency injection, we can provide interfaces to the management objects therefore we can easily 
    change the object that inherits the interface by creating a new class with different structure that inherits the same interface.
     */

    class Program
    {
        static void Main(string[] args)
        {
            #region Property Injection
            ILogger logger = new DatabaseLogger();
            EmployeeManager employeeManager = new EmployeeManager() { Logger = logger }; // property injection
            employeeManager.Add();
            #endregion

            #region Constructor Injection
            ProductManager productManager = new ProductManager(new FileLogger()); // constructor injection
            productManager.Add();
            #endregion

            #region Method Injection
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new DatabaseLogger()); // method injection
            #endregion

            #region Araba ve Surucu
            ArabaVeSurucuProgram arabaVeSurucuProgram = new ArabaVeSurucuProgram();
            arabaVeSurucuProgram.Run();
            #endregion

            Console.ReadLine();
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    #region Property Injection
    class EmployeeManager
    {
        public ILogger Logger { get; set; } // property injection

        public void Add()
        {
            Logger.Log(); // property injection
            Console.WriteLine("Employee added");
        }
    }
    #endregion

    #region Constructor Injection
    class ProductManager
    {
        private ILogger _logger; // constructor injection

        public ProductManager(ILogger logger) // constructor injection
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log(); // constructor injection
            Console.WriteLine("Product added");
        }
    }
    #endregion

    #region Method Injection
    class CustomerManager
    {
        public void Add(ILogger logger) // method injection
        {
            logger.Log(); // method injection
            Console.WriteLine("Customer added");
        }
    }
    #endregion
}
