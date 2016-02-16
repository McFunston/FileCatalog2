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
    public class FileListTests
    {
        [TestMethod()]
        public void FileListTest()
        {
            //Arrange

            //Act
            var testList = new FileList();
            //Assert

            Assert.IsNotNull(testList.ListofFiles);
        }
    }
}