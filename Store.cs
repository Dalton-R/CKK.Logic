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
        public List<StoreItem> Items = new List<StoreItem>();

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

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if(prod == null || quantity <= 0)
            {
                return null;
            }

            bool exists = false;
            int index = -1;

            for(int i = 0; i < Items.Count; i++)
            {
                if (Items[i].GetProduct() == prod)
                {
                    exists = true;
                    index = i;
                    break;
                }
            }

            if(exists)
            {
                Items[index].SetQuantity(Items[index].GetQuantity() + quantity);
            }
            else
            {
                Items.Add(new StoreItem(prod, quantity));
                index = Items.Count - 1;
            }

            return Items[index];
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            int index = -1;

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].GetProduct().GetId() == id)
                {
                    index = i;

                    Items[i].SetQuantity(Items[i].GetQuantity() - quantity);
                    if(Items[i].GetQuantity() < 0)
                    {
                        Items[i].SetQuantity(0);
                    }

                    break;
                }
            }

            if(index != -1)
            {
                return Items[index];
            }
            else
            {
                return null;
            }
        }

        public StoreItem FindStoreItemById(int id)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].GetProduct().GetId() == id)
                {
                    return Items[i];
                }
            }

            return null;
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }
    }
}
