using AppHotel.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Business
{
    public interface IBookingBusinnes
    {
        void Save(Booking booking);

        void Get(Guid guid);

        void Get();

        void Remove(Guid guid);
    }
}
