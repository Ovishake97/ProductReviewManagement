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
        /// Method to retrieve the records whose rating is greater than 3
        /// and product id is either 1 or 4 or 9
        public static void GetRecordsForRatings(List<ProductReview> list) {
            var data = (list.Where(r => r.rating > 3 && r.productID == 1 || r.productID == 4 || r.productID == 9));
            foreach (var element in data) {
                Console.WriteLine(element.productID);
                Console.WriteLine(element.rating);
                Console.WriteLine(element.review);
                Console.WriteLine("-----------");
            }
        }
    }
}
