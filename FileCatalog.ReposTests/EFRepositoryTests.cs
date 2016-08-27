using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileCatalog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileCatalog.Biz;

namespace FileCatalog.Repositories.Tests
{
    [TestClass()]
    public class EFRepositoryTests
    {
        [TestMethod()]
        public void SaveTest()
        {
            //Arrange
            DateTime DTTester = DateTime.Now;
            var file = new File("test.txt", DTTester, "c:", (long)1000, "txt");
            var archiveInfo = new Archive("test", System.IO.DriveType.Fixed, "nolabel");
            //var listOfFiles = new List<IFile>();
            //listOfFiles.Add(file);
            //var catalog = new Catalog(archiveInfo, listOfFiles);

            //Act
            using (var ctx = new EFRepositoryContext())
            {
                ctx.Files.Add(file);
                ctx.Archives.Add(archiveInfo);
                ctx.SaveChanges();
            }
            //Assert
                Assert.Fail();
        }
    }
}