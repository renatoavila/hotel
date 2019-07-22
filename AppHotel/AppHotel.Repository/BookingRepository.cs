using AppHotel.Domain.Entity;
using AppHotel.Repository.Base;
using AppHotel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Repository
{
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {
        public void Obter2Quartos()
        {
            throw new NotImplementedException();
        }
    }
}
