using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_ConstructorsInInheritance.Extras.Example
{
    class ClassExample : AbstractClassExample
    {
        private string _childField;

        public ClassExample(string baseField) : base(baseField)
        {
            Console.WriteLine("ClassExample constructor executed");
        }

        public void SubMethod(string childField)
        {
            _childField = childField;
            Console.WriteLine("ClassExample child method executed with " + _childField);
        }
    }
}
