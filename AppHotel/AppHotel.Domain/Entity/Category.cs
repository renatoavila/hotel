using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Entity
{
    public class Category : Entity
    {
        public string Name { get; private set; }
        public Decimal Price { get; private set; }
         
        public Category(string name, decimal price)
        { 
            Name = name;
            Price = price;
        }
    }
}
