using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        public int Id;
        public string Name;
        public Product Product1;
        public Product Product2;
        public Product Product3;

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void AddStoreItem(Product prod)
        {
            if (Product1 == null)
            {
                Product1 = prod;
            }
            else if (Product2 == null)
            {
                Product2 = prod;
            }
            else if (Product3 == null)
            {
                Product3 = prod;
            }
        }

        public void RemoveStoreItem(int productNum)
        {
            if (productNum == 1)
            {
                if (Product1 != null)
                {
                    Product1 = null;
                }
            }
            else if (productNum == 2)
            {
                if (Product2 != null)
                {
                    Product2 = null;
                }
            }
            else if (productNum == 3)
            {
                if (Product3 != null)
                {
                    Product3 = null;
                }
            }
        }

        public Product GetStoreItem(int productNum)
        {
            if (productNum == 1)
            {
                if (Product1 != null)
                {
                    return Product1;
                }
            }
            else if (productNum == 2)
            {
                if (Product2 != null)
                {
                    return Product2;
                }
            }
            else if (productNum == 3)
            {
                if (Product3 != null)
                {
                    return Product3;
                }
            }

            return null;
        }

        public Product FindStoreItemById(int id)
        {
            if (Product1 != null)
            {
                if (Product1.GetId() == id)
                {
                    return Product1;
                }
            }

            if (Product2 != null)
            {
                if (Product2.GetId() == id)
                {
                    return Product2;
                }
            }

            if (Product3 != null)
            {
                if (Product3.GetId() == id)
                {
                    return Product3;
                }
            }

            return null;
        }
    }
}