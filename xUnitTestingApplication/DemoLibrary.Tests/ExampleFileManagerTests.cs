using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Tests
{
    public class ExampleFileManagerTests
    {
        [Fact]
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = ExampleFileManager.ExampleLoadTextFile("This is a valid file name.");
            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void ExampleLoadTextFile_InvalidNameShouldFail()
        {
            Assert.Throws<FileNotFoundException>(() => ExampleFileManager.ExampleLoadTextFile(""));
        }
    }
}
