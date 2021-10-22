using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class Product
    {
        public static int ID;
        public static string Name;
        public static decimal Price;

        public static int GetId()
        {
            return ID;
        }

        public static void SetId(int id)
        {
            ID = id;
        }

        public static string GetName()
        {
            return Name;
        }

        public static void SetName(string name)
        {
            Name = name;
        }

        public static decimal GetPrice()
        {
            return Price;
        }

        public static void SetPrice(decimal price)
        {
            Price = price;
        }
    }
}
