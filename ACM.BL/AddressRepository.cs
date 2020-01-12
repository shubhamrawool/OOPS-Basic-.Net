using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address();
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.City = "Mumbai";
                address.Country = "India";
                address.State = "Maharashtra";
                address.StreetLine1 = "SL1";
                address.StreetLine2 = "SL2";
                address.PostalCode = 1234;
            }
            return new Address(addressId);
        }

        public IEnumerable<Address> RetrieveByCustomerID(int customerId)
        {
            var addressList = new List<Address>();
            addressList.Add(new Address(1)
            {
                AddressType = 1,
                City = "Mumbai",
                Country = "India",
                State = "Maharashtra",
                StreetLine1 = "SL1",
                StreetLine2 = "SL2",
                PostalCode = 1234
            });
            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
