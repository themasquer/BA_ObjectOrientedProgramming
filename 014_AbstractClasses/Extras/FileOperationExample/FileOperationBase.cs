using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_AbstractClasses.Extras.FileOperationExample
{
    abstract class FileOperationBase
    {
        public string Path { get; set; }

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
