using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Entity
{
    public class HotelGuest : Entity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string Fone { get; private set; }

        public HotelGuest(string name, string email, string cpf, string fone)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
            Fone = fone;
        }
    }
}
