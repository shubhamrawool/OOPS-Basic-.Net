using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer()
            {
                FirstName = "Shubham",
                LastName = "Rawool"
            };
            string expected = "Shubham Rawool";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameOnlyLastNameTestInvalid()
        {
            //Arrange
            Customer customer = new Customer()
            {
                LastName = "Rawool"
            };
            string expected = "Rawool";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameOnlyFirstNameTestInvalid()
        {
            //Arrange
            Customer customer = new Customer()
            {
                FirstName = "Shubham"
            };
            string expected = "Shubham";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NoFullNameTestInvalid()
        {
            //Arrange
            Customer customer = new Customer()
            {
            };
            string expected = "";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
