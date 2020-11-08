using System;
using System.Collections.Generic;

namespace Product_Review_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management system");
            List<ProductReview> productReviews = new List<ProductReview>();
            { new ProductReview() { productID = 1, userID = 1, rating = 4, review = "poor", isLike = false };
                new ProductReview() { productID = 2, userID = 3, rating = 6, review = "average", isLike = true };
                new ProductReview() { productID = 3, userID = 2, rating = 8, review = "good", isLike = true };
                new ProductReview() { productID = 4, userID = 7, rating = 5, review = "average", isLike = true };
                new ProductReview() { productID = 5, userID = 1, rating = 3, review = "poor", isLike = false };
                new ProductReview() { productID = 6, userID = 2, rating = 4, review = "poor", isLike = false };
                new ProductReview() { productID = 7, userID = 5, rating = 7, review = "good", isLike = true };
                new ProductReview() { productID = 8, userID = 3, rating = 9, review = "good", isLike = true };
                new ProductReview() { productID = 9, userID = 6, rating = 5, review = "average", isLike = true };
                new ProductReview() { productID = 10, userID = 4, rating = 6, review = "good", isLike = true };
                new ProductReview() { productID = 11, userID = 2, rating = 7, review = "good", isLike = true };
                new ProductReview() { productID = 12, userID = 8, rating = 4, review = "poor", isLike = false };
                new ProductReview() { productID = 13, userID = 6, rating = 5, review = "average", isLike = true };
                new ProductReview() { productID = 14, userID = 5, rating = 7, review = "good", isLike = true };
                new ProductReview() { productID = 15, userID = 7, rating = 4, review = "poor", isLike = false };
            };
            Console.WriteLine("Added succesfully");
        }
    }
}
