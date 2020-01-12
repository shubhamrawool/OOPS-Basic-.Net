using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieves a single product.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            if(orderId == 1)
            {
                order.OrderDate = new DateTimeOffset();
            }
            return order;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        public bool Save(Order order)
        {
            return true;
        }
    }
}
