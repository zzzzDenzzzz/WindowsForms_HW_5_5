using System;

namespace Task_2
{
    [Serializable]
    internal class Product
    {
        public string Name { get; set; }
        public string Specification { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(string name, string specification, string description, decimal price)
        {
            Name = name;
            Specification = specification;
            Description = description;
            Price = price;
        }
    }
}
