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
        public async void GetFileListFromPathTest()
        {
            //Arrange
            string expected = "Test.txt";
            //Act

            var testList = await FileListFactory.GetFileListFromPathAsync(@"C:\Users\Mica Funston\Documents\Visual Studio Projects\FileCatalog\FileCatalog.BizTests\Dummie Folder");
            string actual = testList.ListofFiles[0].Name;
            //Assert
            Assert.IsNotNull(testList);
            Assert.AreEqual(expected, actual);
        }
    }
}