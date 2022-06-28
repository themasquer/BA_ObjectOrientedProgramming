using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_ConstructorsInInheritance.Extras.FileOperationExample
{
    abstract class FileOperationBase
    {
        protected string Path { get; set; }

        protected FileOperationBase(string path)
        {
            Path = path;
        }

        public virtual string ReadFromFile()
        {
            return File.ReadAllText(Path);
        }

        public virtual void WriteToFile(string fileContent)
        {
            File.WriteAllText(Path, fileContent);
        }
    }
}
