using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public AddressRepository addressRepository { get; set; }
        /// <summary>
        /// Retrieves one customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            if(customerId == 1)
            {
                customer.EmailAddress = "shubham@rawool.com";
                customer.FirstName = "Shubham";
                customer.LastName = "Rawool";
                customer.AddressList = addressRepository.RetrieveByCustomerID(customerId).ToList();
            }
            return customer;
        }

        /// <summary>
        /// Saves one customer.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
