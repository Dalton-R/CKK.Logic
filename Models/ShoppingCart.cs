using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer customer;
        public Customer Customer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = Customer;
            }
        }
        private List<ShoppingCartItem> products = new List<ShoppingCartItem>();
        public List<ShoppingCartItem> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }

        public ShoppingCart(Customer cust)
        {
            Customer = cust;
        }

        public int GetCustomerId()
        {
            return Customer.GetId();
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (prod == null || quantity <= 0)
            {
                return null;
            }

            bool exists = false;
            int index = -1;

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].GetProduct() == prod)
                {
                    exists = true;
                    index = i;
                    break;
                }
            }

            if (exists)
            {
                Products[index].SetQuantity(Products[index].GetQuantity() + quantity);
            }
            else
            {
                Products.Add(new ShoppingCartItem(prod, quantity));
                index = Products.Count - 1;
            }

            return Products[index];
        }

        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            int index = -1;

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].GetProduct().GetId() == id)
                {
                    index = i;

                    Products[i].SetQuantity(Products[i].GetQuantity() - quantity);
                    if (Products[i].GetQuantity() < 0)
                    {
                        Products[i].SetQuantity(0);
                    }

                    break;
                }
            }

            if (index != -1)
            {
                if(Products[index].GetQuantity() == 0)
                {
                    ShoppingCartItem _new = Products[index];
                    Products.RemoveAt(index);
                    return _new;
                }
                else
                {
                    return Products[index];
                }
            }
            else
            {
                return null;
            }
        }

        public ShoppingCartItem GetProductById(int id)
        {
            for(int i = 0; i < Products.Count; i++)
            {
                if (Products[i].GetProduct().GetId() == id)
                {
                    return Products[i];
                }
            }

            return null;
        }

        public decimal GetTotal()
        {
            decimal _total = 0;

            foreach(ShoppingCartItem itm in Products)
            {
                _total += itm.GetTotal();
            }

            return _total;
        }

        public List<ShoppingCartItem> GetProducts()
        {
            return Products;
        }
    }
}
