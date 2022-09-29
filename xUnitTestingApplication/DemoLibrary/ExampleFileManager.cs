using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ExampleFileManager
    {
        public static string ExampleLoadTextFile(string file)
        {
            if (file.Length < 10)
            {
                throw new System.IO.FileNotFoundException("The file was of improper length.");
            }

            return "The file was loaded correctly";
        }
    }
}
