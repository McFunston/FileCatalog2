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
        public void GetFileListFromPathTestPass()
        {
            //Arrange
            string expected = "Test.txt";
            //Act
            // This should really be done with "testList =  await FileListFactory... but it seems that unit tests can't be Async I could
            // create a helper method to do it asyncronously but that seems excessive
            // var testList = FileListFactory.GetFileListFromPathAsync(@"C:\Users\Mica Funston\Documents\Visual Studio Projects\FileCatalog\FileCatalog.BizTests\Dummie Folder");
            var testList = FileListFactory.GetFileListFromPathAsync(@"C:\Dummie Folder");
            string actual = testList.Result.FileList[0].Name;
            //Assert
            Assert.IsNotNull(testList.Result.FileList);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetFileListFromPathTestFail1()
        {
            //Arrange
            var expectedSuccess = false;
            var expectedMessage = "The path that you selected was not found. Did you remove the media?";
            //Act

            var testList = FileListFactory.GetFileListFromPathAsync(@"m:\ther");
            var actualSuccess = testList.Result.Success;
            var actualMessage = testList.Result.ErrorMessage;
            //Assert
            Assert.AreEqual(expectedSuccess, actualSuccess);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod()]
        public void FileListLengthTest()
        {
            //Arrange
            int expected = 1;
            //Act
            //var testList = FileListFactory.GetFileListFromPathAsync(@"C:\Users\Mica Funston\Documents\Visual Studio Projects\FileCatalog\FileCatalog.BizTests\Dummie Folder");
            var testList = FileListFactory.GetFileListFromPathAsync(@"C:\Dummie Folder");
            var actual = testList.Result.FileList.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetArchiveInfoTest()
        {
            //Arrange 
            string expectedName = "test";
            var expectedDriveType = System.IO.DriveType.Fixed;

            //Act
            var actual = FileListFactory.GetArchiveInfo("test", @"C:\");

            //Assert
            Assert.AreEqual(expectedName, actual.Name);
            Assert.AreEqual(expectedDriveType, actual.DriveType);
        }
    }
}