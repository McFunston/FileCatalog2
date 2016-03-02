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
    public class FileTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange
            DateTime DTTester = DateTime.Now;
            var expected = $"Name: test.txt Date Created: {DTTester} Path: c: Size: 1000";
            //Act
            File actual = new File("test.txt", DTTester, "c:", (long)1000, "txt");
            //Assert
            Assert.AreEqual(expected, actual.ToString());
        }
    }

}