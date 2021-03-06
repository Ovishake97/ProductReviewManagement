﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.Design;
using System.Data;

namespace Product_Review_Management
{
    public class ProductAdapter
    {
        /// Method to print the top 3 products according to the ratings
        /// using linq command
        public static void RetrieveTopData(List<ProductReview> list)
        {
            var data = (from products in list
                        orderby products.rating descending
                        select products).Take(3);
            foreach (var element in data)
            {
                Console.WriteLine(element.productID);
                Console.WriteLine(element.rating);
                Console.WriteLine(element.review);
                Console.WriteLine("------------");
            }
        }
        /// Method to retrieve the records whose rating is greater than 3
        /// and product id is either 1 or 4 or 9
        public static void GetRecordsForRatings(List<ProductReview> list)
        {
            var data = (list.Where(r => r.rating > 3 && r.productID == 1 || r.productID == 4 || r.productID == 9));
            foreach (var element in data)
            {
                Console.WriteLine(element.productID);
                Console.WriteLine(element.rating);
                Console.WriteLine(element.review);
                Console.WriteLine("-----------");
            }
        }
        /// Method to print only product id and reviews
        public static void GetProductIDAndReviews(List<ProductReview> list)
        {
            var data = (from products in list
                        select products);
            foreach (var element in data)
            {
                Console.WriteLine(element.productID);
                Console.WriteLine(element.review);
                Console.WriteLine("-----------");
            }

        }
        /// Method to skip top 5 records from the table and print the rest
        public static void SkipTopFiveRecords(List<ProductReview> list)
        {
            var data = (from products in list
                        orderby products.rating
                        select products).Skip(5);
            foreach (var element in data)
            {
                Console.WriteLine(element.productID);
                Console.WriteLine(element.userID);
                Console.WriteLine(element.rating);
                Console.WriteLine(element.review);
                Console.WriteLine("-----------");
            }

        }
        /// Method to get the count per productid
        public static void FindingCount(List<ProductReview> list)
        {
            var data = list.GroupBy(p => p.productID).Select(x => new { productID = x.Key, average = x.Count() });
            foreach (var elements in data)
            {
                Console.WriteLine("ProductID: " + elements.productID);
                Console.WriteLine("Count :" + elements.average);
            }
        }
        /// Method to retrieve the productids
        /// where the IsLike column is true
        public static void GetIsLikeTrue(DataTable table)
        {
            var datarow = table.AsEnumerable().Where(p => p.Field<string>("IsLike").ToLower().Equals("true"));
            DataTable result = datarow.CopyToDataTable<DataRow>();
            var data = from products in result.AsEnumerable()
                       select products.Field<string>("ProductID");
            foreach (string elements in data)
            {
                Console.WriteLine(elements);
            }
        }
        /// Getting average rating per productid
        public static void GetAverageRating(List<ProductReview> list) {

            var data = list.GroupBy(p => p.productID).Select(x => new { productID = x.Key, average = x.Average(r=>r.rating) });
            foreach (var elements in data)
            {
                Console.WriteLine("ProductID: " + elements.productID);
                Console.WriteLine("Average :" + elements.average);
            }
        }
        /// Method to retrieve all the data where the
        /// review is "nice"
        public static void GetNice(List<ProductReview> list) {
            var data = list.Where(p => p.review.ToLower().Equals("nice"));
            foreach (var element in data)
            {
                Console.WriteLine(element.productID);
                Console.WriteLine(element.userID);
                Console.WriteLine(element.rating);
                Console.WriteLine(element.review);
                Console.WriteLine("-----------");
            }
        }
        /// Method to retrieve all the data where the userId is 10
        public static void GetRowsForUserID(DataTable table) {
            var datarow = table.AsEnumerable().Where(p => p.Field<string>("UserID").Equals("10"));
            DataTable result = datarow.CopyToDataTable<DataRow>();
            Console.WriteLine("ProductID---||---UserID---||--Rating--||--Review--||--IsLike--");
            foreach (DataRow dataRow in result.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.Write("\t"+item);
                }
            }
        }
    }
}
