// namespace : Logical collection of .net types
// class, interface, structure, enum
// delegate, event

namespace Catalog
{
    public class Product
    {
        // public string name { get; set; }

        // public decimal price { get; set; }

        private string name;
        private decimal price;

        // constructor overloading
        public Product() // default constructor
        {
            this.name = string.Empty;
            this.price = 0.0m;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPrice(decimal price)
        {
            this.price = price;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }
}