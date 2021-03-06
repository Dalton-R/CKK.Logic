

namespace CKK.Logic.Models
{
    public class Product
    {
        public int Id;
        public string Name;
        public decimal Price;

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

        public decimal GetPrice()
        {
            return Price;
        }

        public void SetPrice(decimal price)
        {
            Price = price;
        }
    }
}
