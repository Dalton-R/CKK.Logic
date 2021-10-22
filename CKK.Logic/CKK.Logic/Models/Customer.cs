using System;

namespace CKK.Logic.Models
{
    class Customer
    {
        public static int ID;
        public static string Name;
        public static string Address;

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

        public static string GetAddress()
        {
            return Address;
        }

        public static void SetAddress(string address)
        {
            Address = address;
        }
    }
}
