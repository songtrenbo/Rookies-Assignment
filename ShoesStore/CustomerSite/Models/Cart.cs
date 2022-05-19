using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.Models
{
    public class Cart
    {
        //List<CartItem> items = new List<CartItem>();
        //public IEnumerable<CartItem> Items
        //{
        //    get { return items; }
        //}
        //public void Add_Product_Cart(int productId, int quantity, double price)
        //{
        //        items.Add(new CartItem
        //        {
        //            id = productId,
        //            quantity = quantity,
        //            price = price
        //        });
        //}
        public int productId { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int quantity { get; set; }
        public int stock { get; set; }
        public string image { get; set; }
    }
    public class CartItem
    {
        public int id { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    }
}
