using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
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
