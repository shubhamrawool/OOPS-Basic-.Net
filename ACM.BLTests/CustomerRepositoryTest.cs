using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "shubham@rawool.com",
                FirstName = "Shubham",
                LastName = "Rawool"
            };

            //act
            var actual = customerRepository.Retrieve(1);

            //assert
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}
