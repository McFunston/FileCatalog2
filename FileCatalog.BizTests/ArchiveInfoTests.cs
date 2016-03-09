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
            string expectedName = "test";
            System.IO.DriveType expectedMediaType = System.IO.DriveType.Fixed;
            string expectedlabel = "nolabel";
            
            //Act
            var archiveInfo = new ArchiveInfo("test", System.IO.DriveType.Fixed, "nolabel");
            
            //Assert
            Assert.AreEqual(expectedName, archiveInfo.Name);
            Assert.AreEqual(expectedMediaType, archiveInfo.DriveType);
            Assert.AreEqual(expectedlabel, archiveInfo.Label);
        }
    }
}