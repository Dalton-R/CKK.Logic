using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class ShoppingCartItem
    {
        public static Product Product;
        public static int Quantity;

        public ShoppingCartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public static int GetQuantity()
        {
            return Quantity;
        }

        public static void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public static Product GetProduct()
        {
            return Product;
        }

        public static void SetProduct(Product product)
        {
            Product = product;
        }
    }
}
