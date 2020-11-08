using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Review_Management
{
   public class ProductReview
    {
        public int productID { get; set; }
        public int userID { get; set; }
        public int rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }
    }
}
