using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Entity
{
    public class Category
    {
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }

        public Category()
        {

        }
        public Category(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
