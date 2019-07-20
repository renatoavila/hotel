using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Entity
{
    public class Room : Entity
    {
        public string Number { get; private set; }
        public Category Category { get; private set; }
        public decimal Price { get; private set; }

        public Room(string number, Category category, decimal price)
        {
            Number = number;
            Category = category;
            Price = price; 
        }
    }
}
