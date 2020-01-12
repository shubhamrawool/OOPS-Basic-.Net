using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Validates the order item data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (OrderItemId <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
        /// <summary>
        /// Retrieves the order item Data
        /// </summary>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Saves the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
