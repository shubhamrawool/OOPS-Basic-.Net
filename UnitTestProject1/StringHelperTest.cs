using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class StringHelperTest
    {

        [TestMethod]
        public void InsertSpacesValidTest()
        {
            //Arrange
            var source = "TestMethodToTestCommonLayer";
            var target = "Test Method To Test Common Layer";
            

            //Act
            var result = source.InsertSpaces();

            //Assert
            Assert.AreEqual(target, result);
        }

        [TestMethod]
        public void InsertSpacesWithExistingSpaces()
        {
            //Arrange
            var source = "Test Method To Test Common Layer";
            var target = "Test Method To Test Common Layer";
            

            //Act
            var result = StringHelper.InsertSpaces(source);

            //Assert
            Assert.AreEqual(target, result);
        }
    }
}
