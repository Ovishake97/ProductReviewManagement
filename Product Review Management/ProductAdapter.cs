using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Product_Review_Management
{
   public class ProductAdapter
    {
        /// Method to print the top 3 products according to the ratings
        /// using linq command
        public static void RetrieveTopData(List<ProductReview> list) {
            var data = (from products in list
                        orderby products.rating descending
                        select products).Take(3);
            foreach (var element in data) {
                Console.WriteLine(element.productID);
                Console.WriteLine(element.rating);
                Console.WriteLine(element.review);
                Console.WriteLine("------------");
            }
        }
    }
}
