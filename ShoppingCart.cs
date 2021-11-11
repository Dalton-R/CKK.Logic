using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        public Customer Customer;
        public ShoppingCartItem Product1 = new ShoppingCartItem(null, 0);
        public ShoppingCartItem Product2 = new ShoppingCartItem(null, 0);
        public ShoppingCartItem Product3 = new ShoppingCartItem(null, 0);

        public ShoppingCart(Customer cust)
        {
            Customer = cust;
        }

        public int GetCustomerId()
        {
            if (Customer != null)
            {
                return Customer.GetId();
            }
            else
            {
                return 0;
            }
        }

        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            if (prod == null || quantity <= 0)
            {
                return null;
            }

            bool isAlreadyAdded = false;
            int prodNumber = 0;

            if (Product1.GetProduct() == prod)
            {
                isAlreadyAdded = true;
                prodNumber = 1;
            }
            if (Product2.GetProduct() == prod)
            {
                isAlreadyAdded = true;
                prodNumber = 2;
            }
            if (Product3.GetProduct() == prod)
            {
                isAlreadyAdded = true;
                prodNumber = 3;
            }


            if (isAlreadyAdded)
            {
                //return null;

                if (prodNumber == 1)
                {
                    Product1.SetQuantity(Product1.GetQuantity() + quantity);
                    return Product1;
                }
                else if (prodNumber == 2)
                {
                    Product2.SetQuantity(Product2.GetQuantity() + quantity);
                    return Product2;
                }
                else if (prodNumber == 3)
                {
                    Product3.SetQuantity(Product3.GetQuantity() + quantity);
                    return Product3;
                }
            }
            else
            {
                if (Product1.GetProduct() == null)
                {
                    Product1.SetProduct(prod);
                    Product1.SetQuantity(quantity);
                    return Product1;
                }
                else if (Product2.GetProduct() == null)
                {
                    Product2.SetProduct(prod);
                    Product2.SetQuantity(quantity);
                    return Product2;
                }
                else if (Product3.GetProduct() == null)
                {
                    Product3.SetProduct(prod);
                    Product3.SetQuantity(quantity);
                    return Product3;
                }
            }

            return null;
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            if (prod == null)
            {
                return null;
            }

            bool isAlreadyAdded = false;
            int prodNumber = 0;

            if (Product1.GetProduct() == prod)
            {
                isAlreadyAdded = true;
                prodNumber = 1;
            }
            if (Product2.GetProduct() == prod)
            {
                isAlreadyAdded = true;
                prodNumber = 2;
            }
            if (Product3.GetProduct() == prod)
            {
                isAlreadyAdded = true;
                prodNumber = 3;
            }


            if (isAlreadyAdded)
            {
                return null;

                if (prodNumber == 1)
                {
                    Product1.SetQuantity(Product1.GetQuantity() + 1);
                    return Product1;
                }
                else if (prodNumber == 2)
                {
                    Product2.SetQuantity(Product2.GetQuantity() + 1);
                    return Product2;
                }
                else if (prodNumber == 3)
                {
                    Product3.SetQuantity(Product3.GetQuantity() + 1);
                    return Product3;
                }
            }
            else
            {
                if (Product1.GetProduct() == null)
                {
                    Product1.SetProduct(prod);
                    Product1.SetQuantity(1);
                    return Product1;
                }
                else if (Product2.GetProduct() == null)
                {
                    Product2.SetProduct(prod);
                    Product2.SetQuantity(1);
                    return Product2;
                }
                else if (Product3.GetProduct() == null)
                {
                    Product3.SetProduct(prod);
                    Product3.SetQuantity(1);
                    return Product3;
                }
            }

            return null;
        }

        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (Product1.GetProduct() != null)
            {
                if (Product1.GetProduct() == prod)
                {
                    if (Product1.GetQuantity() >= quantity)
                    {
                        int newQuantity = Product1.GetQuantity() - quantity;

                        if (newQuantity == 0)
                        {
                            Product1.SetProduct(null);
                            Product1.SetQuantity(0);
                        }
                        else
                        {
                            Product1.SetQuantity(newQuantity);
                        }
                    }

                    return Product1;
                }
            }
            if (Product2.GetProduct() != null)
            {
                if (Product2.GetProduct() == prod)
                {
                    if (Product2.GetQuantity() >= quantity)
                    {
                        int newQuantity = Product2.GetQuantity() - quantity;

                        if (newQuantity == 0)
                        {
                            Product2.SetProduct(null);
                            Product2.SetQuantity(0);
                        }
                        else
                        {
                            Product2.SetQuantity(newQuantity);
                        }
                    }

                    return Product2;
                }
            }
            if (Product3.GetProduct() != null)
            {
                if (Product3.GetProduct() == prod)
                {
                    if (Product3.GetQuantity() >= quantity)
                    {
                        int newQuantity = Product3.GetQuantity() - quantity;

                        if (newQuantity == 0)
                        {
                            Product3.SetProduct(null);
                            Product3.SetQuantity(0);
                        }
                        else
                        {
                            Product3.SetQuantity(newQuantity);
                        }
                    }

                    return Product3;
                }
            }

            return null;
        }

        public ShoppingCartItem GetProductById(int id)
        {
            if (Product1.GetProduct() != null)
            {
                if (Product1.GetProduct().GetId() == id)
                {
                    return Product1;
                }
            }

            if (Product2.GetProduct() != null)
            {
                if (Product2.GetProduct().GetId() == id)
                {
                    return Product2;
                }
            }

            if (Product3.GetProduct() != null)
            {
                if (Product3.GetProduct().GetId() == id)
                {
                    return Product3;
                }
            }

            return null;
        }

        public decimal GetTotal()
        {
            decimal _total = 0;

            if (Product1.GetProduct() != null)
            {
                _total += Product1.GetTotal();
            }

            if (Product2.GetProduct() != null)
            {
                _total += Product2.GetTotal();
            }

            if (Product3.GetProduct() != null)
            {
                _total += Product3.GetTotal();
            }

            return _total;
        }

        public ShoppingCartItem GetProduct(int productNum)
        {
            if (productNum == 1)
            {
                if (Product1.GetProduct() != null)
                {
                    return Product1;
                }
            }
            else if (productNum == 2)
            {
                if (Product2.GetProduct() != null)
                {
                    return Product2;
                }
            }
            else if (productNum == 3)
            {
                if (Product3.GetProduct() != null)
                {
                    return Product3;
                }
            }

            return null;
        }
    }
}