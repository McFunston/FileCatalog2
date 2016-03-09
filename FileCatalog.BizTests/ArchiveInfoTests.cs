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
    public class ArchiveInfoTests
    {
        [TestMethod()]
        public void ArchiveInfoTest()
        {
            //Arrange
            var archiveInfo = new ArchiveInfo("test", System.IO.DriveType.Fixed, "nolabel");
            string expectedName = "test";
            System.IO.DriveType expectedMediaType = System.IO.DriveType.Fixed;
            string expectedlabel = "nolabel";
            //Act

            //Assert
            Assert.AreEqual(expectedName, archiveInfo.Name);
            Assert.AreEqual(expectedMediaType, archiveInfo.DriveType);
            Assert.AreEqual(expectedlabel, archiveInfo.Label);
        }
    }
}