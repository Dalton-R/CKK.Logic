using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    public interface IStore
    {
        List<StoreItem> Items { get; set; }

        StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (prod == null || quantity <= 0)
            {
                return null;
            }

            bool exists = false;
            int index = -1;

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].GetProduct() == prod)
                {
                    exists = true;
                    index = i;
                    break;
                }
            }

            if (exists)
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

        StoreItem RemoveStoreItem(int id, int quantity)
        {
            int index = -1;

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].GetProduct().GetId() == id)
                {
                    index = i;

                    Items[i].SetQuantity(Items[i].GetQuantity() - quantity);
                    if (Items[i].GetQuantity() < 0)
                    {
                        Items[i].SetQuantity(0);
                    }

                    break;
                }
            }

            if (index != -1)
            {
                return Items[index];
            }
            else
            {
                return null;
            }
        }

        StoreItem FindStoreItemById(int id)
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

        List<StoreItem> GetStoreItems()
        {
            return Items;
        }
    }
}
