using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileCatalog.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCatalog.Biz.Tests
{
    [TestClass()]
    public class FileListFactoryTests
    {
        [TestMethod()]
        public void GetFileListFromPathTest()
        {
            //Arrange
            string expected = "Test.txt";
            //Act
            // This should really be done with "testList =  await FileListFactory... but it seems that unit tests can't be Async I could
            // create a helper method to do it asyncronously but that seems excessive
            // var testList = FileListFactory.GetFileListFromPathAsync(@"C:\Users\Mica Funston\Documents\Visual Studio Projects\FileCatalog\FileCatalog.BizTests\Dummie Folder");
            var testList = FileListFactory.GetFileListFromPathAsync(@"C:\Users\Natasha & Mica\Documents\Visual Studio Projects\FileCatalog2\FileCatalog.BizTests\Dummie Folder");
            string actual = testList.Result.ListofFiles[0].Name;
            //Assert
            Assert.IsNotNull(testList.Result);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FileListLengthTest()
        {
            //Arrange
            int expected = 1;
            //Act
            var testList = FileListFactory.GetFileListFromPathAsync(@"C:\Users\Mica Funston\Documents\Visual Studio Projects\FileCatalog\FileCatalog.BizTests\Dummie Folder");
            var actual = testList.Result.Length;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}