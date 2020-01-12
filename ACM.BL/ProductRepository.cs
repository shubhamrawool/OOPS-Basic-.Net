using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieves a single product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if(productId == 1)
            {
                product.ProductName = "Product 1";
                product.ProductDescription = "Desc For Product 1";
                product.CurrentPrice = 15M;
            }
            return product;
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        public bool Save(Product product)
        {
            bool success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Insert
                    }
                    else
                    {
                        // update
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
