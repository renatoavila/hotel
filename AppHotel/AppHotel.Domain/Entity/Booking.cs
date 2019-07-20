using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Domain.Entity
{
    public class Booking : Entity
    {
        public HotelGuest HotelGuest { get; private set; }
        public DateTime DateStart { get; private set; }
        public DateTime DateEnd { get; private set; }
        public Room Room { get; private set; }

        public Booking(HotelGuest hotelGuest, DateTime dateStart, DateTime dateEnd, Room room)
        {
            HotelGuest = hotelGuest;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Room = room;
        }
    }
}
