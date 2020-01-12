using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItem = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "Shubham.rawool@gmail.com",
                FirstName = "Shubham",
                LastName = "Rawool",
                AddressList = null
            };

            changedItem.Add(customer);

            var product = new Product(1)
            {
                ProductName = "P1",
                CurrentPrice = 100,
                ProductDescription = "P Description"
            };


            changedItem.Add(product);

            //Act;

            LoggingService.WriteToFile(changedItem);

            //Assert
            // Check Console output
        }
    }
}
