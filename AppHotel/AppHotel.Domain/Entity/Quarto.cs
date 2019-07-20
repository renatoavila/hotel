using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Entity
{
    public class Quarto : Entity
    {
        public string Name { get; set; }
        public string Xandao { get; set; }
        public string Xandao2 { get; set; }
        public Decimal Price { get; set; }
         
        public Quarto(string name, decimal price, string xandao, string xandao2)
        { 
            Name = name;
            Price = price;
            Xandao = xandao;
            Xandao2 = xandao2;
        }
    }
}
