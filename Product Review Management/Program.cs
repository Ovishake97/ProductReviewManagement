using System;
using System.Collections.Generic;
using System.Data;

namespace Product_Review_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management system");
            List<ProductReview> productReviews = new List<ProductReview>();
               productReviews.Add(new ProductReview() { productID = 1, userID = 1, rating = 4, review = "poor", isLike = false });
               productReviews.Add (new ProductReview() { productID = 2, userID = 3, rating = 6, review = "average", isLike = true });
               productReviews.Add(new ProductReview() { productID = 3, userID = 2, rating = 8, review = "good", isLike = true });
               productReviews.Add(new ProductReview() { productID = 4, userID = 7, rating = 5, review = "average", isLike = true });
               productReviews.Add(new ProductReview() { productID = 5, userID = 1, rating = 3, review = "poor", isLike = false });
               productReviews.Add(new ProductReview() { productID = 6, userID = 2, rating = 4, review = "poor", isLike = false });
               productReviews.Add(new ProductReview() { productID = 7, userID = 5, rating = 7, review = "good", isLike = true });
               productReviews.Add(new ProductReview() { productID = 8, userID = 3, rating = 9, review = "good", isLike = true });
               productReviews.Add(new ProductReview() { productID = 9, userID = 6, rating = 5, review = "average", isLike = true });
               productReviews.Add(new ProductReview() { productID = 10, userID = 4, rating = 6, review = "good", isLike = true });
               productReviews.Add(new ProductReview() { productID = 11, userID = 2, rating = 7, review = "good", isLike = true });
               productReviews.Add(new ProductReview() { productID = 12, userID = 8, rating = 4, review = "poor", isLike = false });
               productReviews.Add(new ProductReview() { productID = 13, userID = 6, rating = 5, review = "average", isLike = true });
               productReviews.Add(new ProductReview() { productID = 14, userID = 5, rating = 7, review = "good", isLike = true });
               productReviews.Add(new ProductReview() { productID = 15, userID = 7, rating = 4, review = "poor", isLike = false });

            //Adding the elements from the list to a datatable
            DataTable productTable = new DataTable();
            productTable.Columns.Add("ProductID");
            productTable.Columns.Add("UserID");
            productTable.Columns.Add("Rating");
            productTable.Columns.Add("Review");
            productTable.Columns.Add("IsLike");
            foreach (var item in productReviews) {
                var row = productTable.NewRow();
                row["ProductID"] = Convert.ToString(item.productID);
                row["UserID"] = Convert.ToString(item.userID);
                row["Rating"] = Convert.ToString(item.rating);
                row["Review"] = item.review;
                row["IsLike"] = Convert.ToString(item.isLike);
                productTable.Rows.Add(row);
            }
            ProductAdapter.GetIsLikeTrue(productTable);
        }
    }
}
