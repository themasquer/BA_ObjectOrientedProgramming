using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_ConstructorsInInheritance.Extras.Example
{
    abstract class AbstractClassExample
    {
        private string _baseField;

        protected AbstractClassExample(string baseField)
        {
            _baseField = baseField;
            Console.WriteLine("AbstractClassExample base constructor executed with " + _baseField);
        }

        public virtual void BaseMethod()
        {
            Console.WriteLine("AbstractClassExample base method executed with " + _baseField);
        }
    }
}
